using FlowCalc.Mathematics;
using FlowCalc.PoolSystem;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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
        /// Benutzerdefinierter Anwendername
        /// </summary>
        public string Username { get; set; }

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
        /// Aktueller Druck nach der Pumpe (Filterdruck)
        /// in [bar]
        /// </summary>
        public double FilterPressure { get; set; }

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

            GlobalFontSettings.FontResolver = new Report.BarlowFontResolver();
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

        public void GeneratePdfReport(string path, double poolVolume, double filterDiameter)
        {
            var chartView = new ChartView("");

            chartView.AddCurve(Pump.ModellName, Pump.GetPerformanceFlowValues(), Pump.GetPerformanceHeadValues());
            chartView.PowerPoint = new Tuple<double, double>(SystemFlowRate, SystemHead);

            var pklImage = chartView.GetChartImage();





            #region Frame
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.CreationDate = DateTime.Now;
            document.Info.Creator = GetTitle();
            if (!CurrentPresets.DisableUserName)
                document.Info.Author = CurrentPresets.UserName;
            document.Info.Title = "FlowCalc Report";
            document.Info.Keywords = "FlowCalc Pumpenkennlinie Volumenstrom Filtergeschwindigkeit";
            document.Info.Subject = $"{Pump.ModellName} @ {SystemHead.ToString("f2")} mWS";
            
            document.PageLayout = PdfPageLayout.SinglePage;

            
            PdfPage pageA4 = new PdfPage();
            pageA4.Width = new XUnit(210, XGraphicsUnit.Millimeter);
            pageA4.Height = new XUnit(297, XGraphicsUnit.Millimeter);
            pageA4.Orientation = PdfSharp.PageOrientation.Portrait;

            // Create an empty page
            PdfPage page = document.AddPage(pageA4);

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Barlow", 12, XFontStyle.Regular);



            XPen framePen = new XPen(XColors.Black, 0.7);

            XPoint s = new XPoint(new XUnit(5, XGraphicsUnit.Millimeter), new XUnit(5, XGraphicsUnit.Millimeter));

            //background
            XRect headerLeft = new XRect(s, new XPoint(new XUnit(210 / 2, XGraphicsUnit.Millimeter), new XUnit(30, XGraphicsUnit.Millimeter)));
            XLinearGradientBrush headerBrushLeft = new XLinearGradientBrush(
                new XPoint(new XUnit(5, XGraphicsUnit.Millimeter), new XUnit(5, XGraphicsUnit.Millimeter)),
                new XPoint(new XUnit(210 / 2, XGraphicsUnit.Millimeter), new XUnit(5, XGraphicsUnit.Millimeter)),
                XColor.FromArgb(0xff, 0x2e, 0x64),
                XColor.FromArgb(0xe1, 0x00, 0x72)
                );
            XRect headerRight = new XRect(
                new XPoint(new XUnit(210 / 2, XGraphicsUnit.Millimeter), new XUnit(5, XGraphicsUnit.Millimeter)),
                new XPoint(new XUnit(205, XGraphicsUnit.Millimeter), new XUnit(30, XGraphicsUnit.Millimeter))
                );
            XLinearGradientBrush headerBrushRight = new XLinearGradientBrush(
                new XPoint(new XUnit(210 / 2, XGraphicsUnit.Millimeter), new XUnit(5, XGraphicsUnit.Millimeter)),
                new XPoint(new XUnit(205, XGraphicsUnit.Millimeter), new XUnit(5, XGraphicsUnit.Millimeter)),
                XColor.FromArgb(0xe1, 0x00, 0x72),
                XColor.FromArgb(0xfa, 0x00, 0x41)
                );
            gfx.DrawRectangle(headerBrushLeft, headerLeft);
            gfx.DrawRectangle(headerBrushRight, headerRight);


            XRect footer = new XRect(
                new XPoint(new XUnit(5, XGraphicsUnit.Millimeter), new XUnit(276, XGraphicsUnit.Millimeter)),
                new XPoint(new XUnit(205, XGraphicsUnit.Millimeter), new XUnit(292, XGraphicsUnit.Millimeter))
                );
            XBrush footerBrush = new XSolidBrush(XColor.FromArgb(0xf7, 0xf8, 0xf9));
            gfx.DrawRectangle(footerBrush, footer);

            XRect outerFrame = new XRect(s, new XPoint(new XUnit(205, XGraphicsUnit.Millimeter), new XUnit(292, XGraphicsUnit.Millimeter)));
            gfx.DrawRectangle(framePen, outerFrame);


            gfx.DrawLine(framePen,
                new XPoint(new XUnit(5, XGraphicsUnit.Millimeter), new XUnit(30, XGraphicsUnit.Millimeter)),
                new XPoint(new XUnit(205, XGraphicsUnit.Millimeter), new XUnit(30, XGraphicsUnit.Millimeter)));

            gfx.DrawString("FlowCalc Report", new XFont("Barlow", 32, XFontStyle.Bold), XBrushes.White,
              new XRect(s, new XPoint(new XUnit(205, XGraphicsUnit.Millimeter), new XUnit(30, XGraphicsUnit.Millimeter))),
              XStringFormats.Center);


            gfx.DrawLine(framePen,
                new XPoint(new XUnit(5, XGraphicsUnit.Millimeter), new XUnit(276, XGraphicsUnit.Millimeter)),
                new XPoint(new XUnit(205, XGraphicsUnit.Millimeter), new XUnit(276, XGraphicsUnit.Millimeter)));
            gfx.DrawLine(framePen,
                new XPoint(new XUnit(60, XGraphicsUnit.Millimeter), new XUnit(276, XGraphicsUnit.Millimeter)),
                new XPoint(new XUnit(60, XGraphicsUnit.Millimeter), new XUnit(292, XGraphicsUnit.Millimeter)));
            gfx.DrawLine(framePen,
                new XPoint(new XUnit(210 - 60, XGraphicsUnit.Millimeter), new XUnit(276, XGraphicsUnit.Millimeter)),
                new XPoint(new XUnit(210 - 60, XGraphicsUnit.Millimeter), new XUnit(292, XGraphicsUnit.Millimeter)));
            XBrush footerTextBrush = new XSolidBrush(XColor.FromArgb(0x18, 0x19, 0x37));
            gfx.DrawString("www.100prznt.de", font, footerTextBrush,
              new XRect(
                  new XPoint(new XUnit(5, XGraphicsUnit.Millimeter), new XUnit(276, XGraphicsUnit.Millimeter)),
                  new XPoint(new XUnit(60, XGraphicsUnit.Millimeter), new XUnit(292, XGraphicsUnit.Millimeter))),
              XStringFormats.Center);
            gfx.DrawString(GetTitle(), new XFont("Barlow", 16, XFontStyle.Bold), footerTextBrush,
              new XRect(
                  new XPoint(new XUnit(60, XGraphicsUnit.Millimeter), new XUnit(276, XGraphicsUnit.Millimeter)),
                  new XPoint(new XUnit(210 - 60, XGraphicsUnit.Millimeter), new XUnit(292, XGraphicsUnit.Millimeter))),
              XStringFormats.Center);
            if (CurrentPresets.DisableUserName)
            {
                gfx.DrawString(DateTime.Now.ToString(), font, footerTextBrush,
                  new XRect(
                      new XPoint(new XUnit(210 - 60, XGraphicsUnit.Millimeter), new XUnit(276, XGraphicsUnit.Millimeter)),
                      new XPoint(new XUnit(205, XGraphicsUnit.Millimeter), new XUnit(292, XGraphicsUnit.Millimeter))),
                  XStringFormats.Center);
            }
            else
            {
                gfx.DrawString(DateTime.Now.ToString(), font, footerTextBrush,
                  new XRect(
                      new XPoint(new XUnit(210 - 60, XGraphicsUnit.Millimeter), new XUnit(276, XGraphicsUnit.Millimeter)),
                      new XPoint(new XUnit(205, XGraphicsUnit.Millimeter), new XUnit(284, XGraphicsUnit.Millimeter))),
                  XStringFormats.Center);
                gfx.DrawString(CurrentPresets.UserName, font, footerTextBrush,
                  new XRect(
                      new XPoint(new XUnit(210 - 60, XGraphicsUnit.Millimeter), new XUnit(284, XGraphicsUnit.Millimeter)),
                      new XPoint(new XUnit(205, XGraphicsUnit.Millimeter), new XUnit(292, XGraphicsUnit.Millimeter))),
                  XStringFormats.Center);
            }
            #endregion Frame


            XFont p = new XFont("Barlow", 10, XFontStyle.Regular);

            XFont h2 = new XFont("Barlow", 16, XFontStyle.Bold | XFontStyle.Underline);
            XFont h3 = new XFont("Barlow", 13, XFontStyle.Bold);
            XFont p3 = new XFont("Barlow", 13, XFontStyle.Regular);
            XFont h4 = new XFont("Barlow", 11, XFontStyle.Regular);

            var t1 = new XUnit(10, XGraphicsUnit.Millimeter);
            var t2 = new XUnit(13, XGraphicsUnit.Millimeter);
            var t3 = new XUnit(20, XGraphicsUnit.Millimeter);
            var t4 = new XUnit(40, XGraphicsUnit.Millimeter);
            var t6 = new XUnit(60, XGraphicsUnit.Millimeter);
            var t7 = new XUnit(70, XGraphicsUnit.Millimeter);
            var t8 = new XUnit(86, XGraphicsUnit.Millimeter);
            var t10 = new XUnit(100, XGraphicsUnit.Millimeter);

            int yLineH3 = 7;
            int yOffsH3 = -1;
            int yBd = 40;

            gfx.DrawString("System", h2, XBrushes.Black, new XPoint(t1, new XUnit(yBd + yOffsH3, XGraphicsUnit.Millimeter)));

            gfx.DrawString("Pumpe:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yBd + yLineH3, XGraphicsUnit.Millimeter)));
            gfx.DrawString("Filterkessel Durchmesser:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yBd + yLineH3 * 2, XGraphicsUnit.Millimeter)));
            gfx.DrawString("Poolvolumen:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yBd + yLineH3 * 3, XGraphicsUnit.Millimeter)));
            gfx.DrawString("Saugseitige Rohrleitung:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yBd + yLineH3 * 4, XGraphicsUnit.Millimeter)));
            gfx.DrawString("Systemdruck (Filterkessel):", p3, XBrushes.Black, new XPoint(t2, new XUnit(yBd + yLineH3 * 5, XGraphicsUnit.Millimeter)));

            gfx.DrawString($"{Pump.ModellName} ({Pump.Manufacturer})", h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3, XGraphicsUnit.Millimeter)));
            gfx.DrawString(filterDiameter.ToString("f0") + " mm", h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * 2, XGraphicsUnit.Millimeter)));
            gfx.DrawString(poolVolume.ToString("f1") + " m³", h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * 3, XGraphicsUnit.Millimeter)));
            if (SuctionPipe != null)
                gfx.DrawString(SuctionPipe.ToString(), h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * 4, XGraphicsUnit.Millimeter)));
            gfx.DrawString(FilterPressure.ToString("f2") + " bar", h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * 5, XGraphicsUnit.Millimeter)));


            int yCalc = 89;

            gfx.DrawString("Berechnung", h2, XBrushes.Black, new XPoint(t1, new XUnit(yCalc + yOffsH3, XGraphicsUnit.Millimeter)));

            gfx.DrawString("Pumpenvordruck:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yCalc + yLineH3, XGraphicsUnit.Millimeter)));
            gfx.DrawString("Förderhöhe:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yCalc + yLineH3 * 2, XGraphicsUnit.Millimeter)));
            gfx.DrawString("Volumenstrom:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yCalc + yLineH3 * 3, XGraphicsUnit.Millimeter)));
            gfx.DrawString("Arbeitspunkt auf Pumpenkennlinie", p3, XBrushes.Black, new XPoint(t2, new XUnit(yCalc + yLineH3 * 4, XGraphicsUnit.Millimeter)));

            if (SuctionPipe != null)
                gfx.DrawString(SuctionPressureDrop.ToString("f3") + " bar", h3, XBrushes.Black, new XPoint(t10, new XUnit(yCalc + yLineH3, XGraphicsUnit.Millimeter)));
            gfx.DrawString($"{SystemHead.ToString("f2")} mWS ({SystemPressure.ToString("f3")} bar)", h3, XBrushes.Black, new XPoint(t10, new XUnit(yCalc + yLineH3 * 2, XGraphicsUnit.Millimeter)));
            gfx.DrawString(SystemFlowRate.ToString("f2") + " m³/h", h3, XBrushes.Black, new XPoint(t10, new XUnit(yCalc + yLineH3 * 3, XGraphicsUnit.Millimeter)));



            var stream = new System.IO.MemoryStream();
            pklImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;

            XImage pkl = XImage.FromStream(stream);

            XRect imageFrame = new XRect(
                new XPoint(t3, new XUnit(yCalc + 32, XGraphicsUnit.Millimeter)),
                new XPoint(new XUnit(180, XGraphicsUnit.Millimeter), new XUnit(yCalc + 127, XGraphicsUnit.Millimeter)));
            gfx.DrawImage(pkl, imageFrame);


            var filter = new Pipe(1, filterDiameter, 0.01);
            var filterSpeed = filter.CalcFlowVelocity(SystemFlowRate) * 3600;
            var filterSpeedBrush = XBrushes.Green;
            if (filterSpeed > 60 || filterSpeed < 40)
                filterSpeedBrush = XBrushes.Red;
            else if (filterSpeed > 55 || filterSpeed < 45)
                filterSpeedBrush = XBrushes.Orange;

            var tCycle1 = TimeSpan.FromHours(poolVolume / SystemFlowRate);
            var tCycle3 = TimeSpan.FromHours(poolVolume / SystemFlowRate *3);

            int yRes = 225;

            gfx.DrawString("Auswertung", h2, XBrushes.Black, new XPoint(t1, new XUnit(yRes + yOffsH3, XGraphicsUnit.Millimeter)));

            gfx.DrawString("Umwälzzeiten", p3, XBrushes.Black, new XPoint(t2, new XUnit(yRes + yLineH3, XGraphicsUnit.Millimeter)));
            gfx.DrawString("1-fach:", p3, XBrushes.Black, new XPoint(t10 - 50, new XUnit(yRes + yLineH3, XGraphicsUnit.Millimeter)));
            gfx.DrawString("3-fach:", p3, XBrushes.Black, new XPoint(t10 - 50, new XUnit(yRes + yLineH3 * 2, XGraphicsUnit.Millimeter)));
            gfx.DrawString("Filtergeschwindigkeit:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yRes + yLineH3 * 3, XGraphicsUnit.Millimeter)));

            gfx.DrawString($"{tCycle1.Hours} Stunden {tCycle1.Minutes} Minuten", h3, XBrushes.Black, new XPoint(t10, new XUnit(yRes + yLineH3, XGraphicsUnit.Millimeter)));
            gfx.DrawString($"{tCycle3.Hours} Stunden {tCycle3.Minutes} Minuten", h3, XBrushes.Black, new XPoint(t10, new XUnit(yRes + yLineH3 * 2, XGraphicsUnit.Millimeter)));
            gfx.DrawString(filterSpeed.ToString("f2") + " m/h", h3, filterSpeedBrush, new XPoint(t10, new XUnit(yRes + yLineH3 * 3, XGraphicsUnit.Millimeter)));


            XTextFormatter tf = new XTextFormatter(gfx);

            tf.DrawString("Im privaten Poolbereich sollte die Filtergeschwindigkeit nicht über 50 m/h betragen.\r\n" + 
                "Mit einer langsameren Filtergeschwindigkeit von rund 30 m/h würde das Ergebnis der Filtration zwar verbessert werden. " +
                "Jedoch sind für Rückspülung (Reinigung des Filters) Spülgeschwindigkeiten von 50-60 m/h erforderlich. Da die Filterpumpe " + 
                "in privaten Pool für Filtration und Rückspülung ausgelegt wird, wählt man als Kompromiss eine Filtergeschwindigkeit um 50 m/h.",
                p, XBrushes.Black,
              new XRect(
                  new XPoint(t2, new XUnit(yRes + yLineH3 * 4 - 4, XGraphicsUnit.Millimeter)),
                  new XPoint(new XUnit(200, XGraphicsUnit.Millimeter), new XUnit(276, XGraphicsUnit.Millimeter))),
              XStringFormats.TopLeft);


            // Save the document
            document.Save(path);
            // Start a viewer.
            Process.Start(path);
        }

        #endregion Services

        #region Internal services
        public string GetTitle()
        {
#if DEBUG
                return typeof(MainView).Assembly.GetName().Name + " [DEBUG]";
#else
                var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                return string.Concat(typeof(MainView).Assembly.GetName().Name, " ", versionInfo.ProductVersion);
#endif
            
        }

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
