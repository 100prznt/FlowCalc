using FlowCalc.Mathematics;
using FlowCalc.PoolSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace FlowCalc
{
    public class Controller : INotifyPropertyChanged
    {
        #region Constants

        const string PRESETS_PATH = "FlowCalc.settings";

        #endregion Constants

        /// <summary>
        /// Aktuell geladene Voreinstellungen
        /// </summary>
        public static CalcPresets CurrentPresets;

        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Aktive Pumpe
        /// </summary>
        public Pump Pump { get; set; }

        /// <summary>
        /// Verfügbare Pumpe
        /// </summary>
        public List<Pump> Pumps { get; set; }

        /// <summary>
        /// Verfügbare Fittings
        /// </summary>
        public List<Fitting> Fittings { get; set; }

        /// <summary>
        /// Pfad zur aktuell verwendeten Pumpendefinition
        /// </summary>
        public string PumpDefinitionPath { get; set; }

        /// <summary>
        /// Aktueller Systemdruck
        /// in [bar]
        /// </summary>
        public double SystemPressure { get; set; }

        /// <summary>
        /// Aktuelle Wassersäule
        /// in [m]
        /// berechnet aus dem aktuellen Systemdruck
        /// </summary>
        public double SystemHead
        {
            get
            {
                return SystemPressure / 0.0980665;
            }
        }

        /// <summary>
        /// Aktueller Systemvolumenstrom
        /// in [m³/h]
        /// </summary>
        public double SystemFlowRate { get; set; }

        public Pipe SuctionPipe { get; set; }

        public double SuctionPressureDrop { get; set; }

        public int SuctionPressureDropCalcIterations { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for Controller
        /// </summary>
        public Controller()
        {
            if (File.Exists(PRESETS_PATH))
                CurrentPresets = CalcPresets.FromFile(PRESETS_PATH);
            else
            {
                CurrentPresets = CalcPresets.Default;
                CurrentPresets.ToFile(PRESETS_PATH);
            }
        }

        #endregion Constructor

        #region Services
        public void ApplyPresets(CalcPresets presets)
        {
            CurrentPresets = presets;
            CurrentPresets.ToFile(PRESETS_PATH);
        }

        /// <summary>
        /// Initialisiere neue Pumpe
        /// </summary>
        public void NewPump()
        {
            PumpDefinitionPath = null;
            Pump = new Pump();
        }

        /// <summary>
        /// Pumpendefinitionsdatei laden und in <see cref="Pump"/> ablegen
        /// </summary>
        /// <param name="path">Pafd zur Pumpendefinitionsdatei</param>
        /// <exception cref="InvalidDataException">Fehler beim laden der Pumpendefinitionsdatei</exception>
        public void LoadPump(string path)
        {
            Pump = Pump.FromFile(path);
            PumpDefinitionPath = path;

            NewPumpLoaded?.Invoke();
        }

        /// <summary>
        /// Alle Pumpen laden
        /// </summary>
        /// <param name="searchPath">Pfad in welchem Pumpen gesucht werden sollen</param>
        public void LoadPumps(string searchPath)
        {
            var pumps = new List<Pump>();

            if (Directory.Exists(searchPath))
            {
                var fileNames = Directory.GetFiles(searchPath);

                foreach (var fileName in fileNames)
                {
                    if (fileName.EndsWith(".xml") &!fileName.EndsWith("Blanko.xml"))
                    {
                        Debug.WriteLine("Deserialize " + fileName);
                        try
                        {
                            var pump = Pump.FromFile(fileName);
                            pump.FilePath = fileName;
                            pumps.Add(pump);
                        }
                        catch (Exception)
                        {
                            //Überspringen TODO: dirty
                        }
                    }
                }

                if (pumps.Count > 0)
                    Pumps = pumps;
            }
        }

        public void LoadFittings(string searchPath)
        {
            var fittings = new List<Fitting>();

            if (Directory.Exists(searchPath))
            {
                var fileNames = Directory.GetFiles(searchPath);

                foreach (var fileName in fileNames)
                {
                    if (fileName.EndsWith(".xml") & !fileName.EndsWith("Blanko.xml"))
                    {
                        Debug.WriteLine("Deserialize " + fileName);
                        try
                        {
                            var fitting = Fitting.FromFile(fileName);
                            fitting.FilePath = fileName;
                            fittings.Add(fitting);
                        }
                        catch (Exception)
                        {
                            //Überspringen TODO: dirty
                        }
                    }
                }

                if (fittings.Count > 0)
                    Fittings = fittings;
            }
        }

        public void CalcFlowRate(double pressure)
        {
            SystemPressure = pressure;

            if (SystemHead > Pump.MaxTotalHead)
            {
                ResetSystem();
                return;
            }

            var systemFlowRate = LinInterp.LinearInterpolation(Pump.GetPerformanceHeadValues(), Pump.GetPerformanceFlowValues(), SystemHead);

            if (SuctionPipe == null)
            {
                SystemFlowRate = systemFlowRate;
            }
            else
            {
                double pressureDrop = 0;
                double systemPressure = 0;
                //Iterative Berechnung, da Volumenstrom auch vom saugseitigen Druckverlust abhängt
                double s = -0.01; // Schrittweite für Antastung
                int i = 7; // Anzahl der Richtungswechsel
                double error = double.MaxValue;
                double lastError;
                while (i > 0)
                {
                    lastError = error;
                    systemFlowRate += s;
                    pressureDrop = SuctionPipe.CalcPressureDrop(CurrentPresets.Medium, systemFlowRate);

                    var performanceFlowValues = Pump.GetPerformanceFlowValues();
                    var performanceHeadValues = Pump.GetPerformanceHeadValues();
                    Array.Reverse(performanceFlowValues);
                    Array.Reverse(performanceHeadValues);

                    systemPressure = LinInterp.LinearInterpolation(performanceFlowValues, performanceHeadValues, systemFlowRate) * 0.0980665;

                    error = systemPressure - pressureDrop - pressure;

                    if (Math.Abs(error) >= Math.Abs(lastError))
                    {
                        s /= -10;
                        i--;
                    }

                    SuctionPressureDropCalcIterations++;
                }



                if (SystemHead > Pump.MaxTotalHead || double.IsInfinity(systemPressure) || double.IsInfinity(systemFlowRate) || double.IsInfinity(pressureDrop))
                    ResetSystem();
                else
                {
                    SystemPressure = systemPressure;
                    SystemFlowRate = systemFlowRate;
                    SuctionPressureDrop = -pressureDrop;
                }
            }
        }

        public void ResetSystem()
        {
            SuctionPipe = null;
            SystemPressure = 0;
            SystemFlowRate = 0;
            SuctionPressureDrop = 0;
            SuctionPressureDropCalcIterations = 0;
        }

        #endregion Services

        #region Internal services

        #endregion Internal services

        #region Events
        
        public Action NewPumpLoaded;

        #endregion Events

        #region INotifyPropertyChanged Member
        /// <summary>
        /// Helpmethod, to call the <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="propName">Name of changed property</param>
        protected void PropChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        /// <summary>
        /// Updated property values available
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
