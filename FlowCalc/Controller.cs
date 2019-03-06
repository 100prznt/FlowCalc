using FlowCalc.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace FlowCalc
{
    public class Controller : INotifyPropertyChanged
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Geladene Pumpe
        /// </summary>
        public Pump Pump { get; set; }

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
        /// Aktueller Systemförderstrom
        /// in [m³/h]
        /// </summary>
        public double SystemFlowRate { get; set; }
        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for Controller
        /// </summary>
        public Controller()
        {

        }

        #endregion Constructor

        #region Services
        public void LoadPump(string path)
        {
            Pump = Pump.FromFile(path);

            PumpDefinitionPath = path;
        }

        public double CalcFlowRate(double pressure)
        {
            SystemPressure = pressure;

            if (SystemHead > Pump.MaxTotalHead)
                return 0;

            return LinInterp.LinearInterpolation(Pump.GetPerformanceHeadValues(), Pump.GetPerformanceFlowValues(), SystemHead);
        }

        #endregion Services

        #region Internal services

        #endregion Internal services

        #region Events


        #endregion Events

        #region INotifyPropertyChanged Member
        /// <summary>
        /// Helpmethod, to call the <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="propName">Name of changed property</param>
        protected void PropChanged([CallerMemberName] string propName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        /// <summary>
        /// Updated property values available
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
