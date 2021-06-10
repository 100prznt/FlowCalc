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
using System.Drawing.Imaging;
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

        public void CalcFlowRate(double pressure, int? rpm = null)
        {
            //for debugging only
            var sw = new Stopwatch();

            SystemPressure = pressure;

            if (SystemHead > Pump.GetMaxTotalHead(rpm))
            {
                ResetSystem();
                return;
            }

            var systemFlowRate = LinInterp.LinearInterpolation(Pump.GetPerformanceHeadValues(rpm), Pump.GetPerformanceFlowValues(rpm), SystemHead);

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

                sw.Start();
                while (i > 0)
                {
                    lastError = error;
                    systemFlowRate += s;
                    pressureDrop = SuctionPipe.CalcPressureDrop(CurrentPresets.Medium, systemFlowRate);

                    var performanceFlowValues = Pump.GetPerformanceFlowValues(rpm);
                    var performanceHeadValues = Pump.GetPerformanceHeadValues(rpm);
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
                sw.Stop();
                Debug.WriteLine($"SuctionPressureDropCalc Iterations: {SuctionPressureDropCalcIterations} Time: {sw.ElapsedMilliseconds} ms");

                //TODO: Pump.MaxTotalHead für VARIO Pumpe
                if (SystemHead > Pump.GetMaxTotalHead(rpm) || double.IsInfinity(systemPressure) || double.IsInfinity(systemFlowRate) || double.IsInfinity(pressureDrop))
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

        public void GeneratePdfReport(string path, double poolVolume, double filterDiameter, int? _rpm = null)
        {
            var chartView = new ChartView("");

            chartView.Width = 1692;
            chartView.Height = 1005;

            var powerInput = Pump.PowerInput;                
            string pumpName = Pump.ModellName;
            if (_rpm is int rpm)
            {
                pumpName = pumpName + $" @ {rpm} min^-1";
                powerInput = Pump.GetInputPower((int)rpm);

                var performanceRange = Pump.GetPerformanceRange();
                chartView.AddRange(Pump.ModellName, performanceRange.Item1, performanceRange.Item2);
            }

            chartView.AddCurve(pumpName, Pump.GetPerformanceFlowValues(_rpm), Pump.GetPerformanceHeadValues(_rpm));
            chartView.PowerPoint = new Tuple<double, double>(SystemFlowRate, SystemHead);

            var pklImage = chartView.GetChartImage();
            var filterArea = Math.PI * Math.Pow(filterDiameter, 2) / 400;


            // Create a new PDF document
            var document = new PdfDocument();
            document.Info.CreationDate = DateTime.Now;
            document.Info.Creator = GetTitle();
            if (!CurrentPresets.DisableUserName)
                document.Info.Author = CurrentPresets.UserName;
            document.Info.Title = "FlowCalc Report";
            document.Info.Keywords = "FlowCalc Pumpenkennlinie Volumenstrom Filtergeschwindigkeit";
            document.Info.Subject = $"{Pump.ModellName} @ {SystemHead:f2} mWS";
            
            document.PageLayout = PdfPageLayout.SinglePage;

            
            var pageA4 = new PdfPage();
            var unit = XGraphicsUnit.Millimeter;
            pageA4.Width = new XUnit(210, unit);
            pageA4.Height = new XUnit(297, unit);
            pageA4.Orientation = PdfSharp.PageOrientation.Portrait;

            // Create an empty page
            var page = document.AddPage(pageA4);


            // Get an XGraphics object for drawing
            var gfx = XGraphics.FromPdfPage(page);

            var font = new XFont("Barlow", 11, XFontStyle.Regular);

            #region Frame

            var framePen = new XPen(XColors.Black, 0.7);

            var s = new XPoint(new XUnit(5, unit), new XUnit(5, unit));

            //background
            var headerLeft = new XRect(s, new XPoint(new XUnit(210 / 2, unit), new XUnit(30, unit)));
            var headerBrushLeft = new XLinearGradientBrush(
                new XPoint(new XUnit(5, unit), new XUnit(5, unit)),
                new XPoint(new XUnit(210 / 2, unit), new XUnit(5, unit)),
                XColor.FromArgb(0xff, 0x2e, 0x64),
                XColor.FromArgb(0xe1, 0x00, 0x72)
                );
            var headerRight = new XRect(
                new XPoint(new XUnit(210 / 2, unit), new XUnit(5, unit)),
                new XPoint(new XUnit(205, unit), new XUnit(30, unit))
                );
            var headerBrushRight = new XLinearGradientBrush(
                new XPoint(new XUnit(210 / 2, unit), new XUnit(5, unit)),
                new XPoint(new XUnit(205, unit), new XUnit(5, unit)),
                XColor.FromArgb(0xe1, 0x00, 0x72),
                XColor.FromArgb(0xfa, 0x00, 0x41)
                );
            gfx.DrawRectangle(headerBrushLeft, headerLeft);
            gfx.DrawRectangle(headerBrushRight, headerRight);


            var footer = new XRect(
                new XPoint(new XUnit(5, unit), new XUnit(276, unit)),
                new XPoint(new XUnit(205, unit), new XUnit(292, unit))
                );
            var footerBrush = new XSolidBrush(XColor.FromArgb(0xf7, 0xf8, 0xf9));
            gfx.DrawRectangle(footerBrush, footer);

            var outerFrame = new XRect(s, new XPoint(new XUnit(205, unit), new XUnit(292, unit)));
            gfx.DrawRectangle(framePen, outerFrame);


            gfx.DrawLine(framePen,
                new XPoint(new XUnit(5, unit), new XUnit(30, unit)),
                new XPoint(new XUnit(205, unit), new XUnit(30, unit)));

            gfx.DrawString("FlowCalc Report", new XFont("Barlow", 32, XFontStyle.Bold), XBrushes.White,
              new XRect(s, new XPoint(new XUnit(205, unit), new XUnit(30, unit))),
              XStringFormats.Center);

            int footerCol = 62;

            gfx.DrawLine(framePen,
                new XPoint(new XUnit(5, unit), new XUnit(276, unit)),
                new XPoint(new XUnit(205, unit), new XUnit(276, unit)));
            gfx.DrawLine(framePen,
                new XPoint(new XUnit(footerCol, unit), new XUnit(276, unit)),
                new XPoint(new XUnit(footerCol, unit), new XUnit(292, unit)));
            gfx.DrawLine(framePen,
                new XPoint(new XUnit(210 - footerCol, unit), new XUnit(276, unit)),
                new XPoint(new XUnit(210 - footerCol, unit), new XUnit(292, unit)));
            
            var footerTextBrush = new XSolidBrush(XColor.FromArgb(0x18, 0x19, 0x37));

            var footerArea1 = new XRect(
                  new XPoint(new XUnit(5, unit), new XUnit(278, unit)),
                  new XPoint(new XUnit(footerCol, unit), new XUnit(284, unit)));

            page.AddWebLink(new PdfRectangle(footerArea1), @"http://www.100prznt.de/");

            gfx.DrawString("www.100prznt.de", font, footerTextBrush,
              footerArea1,
              XStringFormats.Center);
            gfx.DrawString("Elias Ruemmler", font, footerTextBrush,
              new XRect(
                  new XPoint(new XUnit(5, unit), new XUnit(284, unit)),
                  new XPoint(new XUnit(footerCol, unit), new XUnit(290, unit))),
              XStringFormats.Center);





            gfx.DrawString(GetTitle(), new XFont("Barlow", 16, XFontStyle.Bold), footerTextBrush,
              new XRect(
                  new XPoint(new XUnit(footerCol, unit), new XUnit(277, unit)),
                  new XPoint(new XUnit(210 - footerCol, unit), new XUnit(284, unit))),
              XStringFormats.Center);

            var footerArea4 = new XRect(
                  new XPoint(new XUnit(footerCol, unit), new XUnit(284, unit)),
                  new XPoint(new XUnit(210 - footerCol, unit), new XUnit(291, unit)));

            page.AddWebLink(new PdfRectangle(footerArea4), @"http://www.github.com/100prznt/Flowcalc");
            gfx.DrawString("www.github.com/100prznt/FlowCalc", font, footerTextBrush,
              footerArea4,
              XStringFormats.Center);

            if (CurrentPresets.DisableUserName)
            {
                gfx.DrawString(DateTime.Now.ToString(), font, footerTextBrush,
                  new XRect(
                      new XPoint(new XUnit(210 - footerCol, unit), new XUnit(276, unit)),
                      new XPoint(new XUnit(205, unit), new XUnit(292, unit))),
                  XStringFormats.Center);
            }
            else
            {
                gfx.DrawString(DateTime.Now.ToString(), font, footerTextBrush,
                  new XRect(
                      new XPoint(new XUnit(210 - footerCol, unit), new XUnit(278, unit)),
                      new XPoint(new XUnit(205, unit), new XUnit(284, unit))),
                  XStringFormats.Center);
                gfx.DrawString(CurrentPresets.UserName, font, footerTextBrush,
                  new XRect(
                      new XPoint(new XUnit(210 - footerCol, unit), new XUnit(284, unit)),
                      new XPoint(new XUnit(205, unit), new XUnit(290, unit))),
                  XStringFormats.Center);
            }
            #endregion Frame


            var p0 = new XFont("Barlow", 9, XFontStyle.Regular);
            var p = new XFont("Barlow", 10.5, XFontStyle.Regular);
            var h2 = new XFont("Barlow", 17, XFontStyle.Bold);
            var h3 = new XFont("Barlow", 13, XFontStyle.Bold);
            var p3 = new XFont("Barlow", 13, XFontStyle.Regular);

            var t1 = new XUnit(10, unit);
            var t2 = new XUnit(13, unit);
            var t3 = new XUnit(20, unit);
            var t10 = new XUnit(72, unit);
            var t16 = new XUnit(140, unit);

            int yLineH3 = 7;
            int yOffsH3 = -1;
            int yBd = 40;


            gfx.DrawString("System", h2, XBrushes.Black, new XPoint(t1, new XUnit(yBd + yOffsH3, unit)));
            var lineIdx = 1;
            gfx.DrawString("Pumpe:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            if (Pump.IsVarioPump)
                gfx.DrawString("Drehzahl:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            gfx.DrawString("Filterkessel Durchmesser:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            gfx.DrawString("Poolvolumen:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            gfx.DrawString("Saugseitige Rohrleitung:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            gfx.DrawString("Systemdruck (Filterkessel):", p3, XBrushes.Black, new XPoint(t2, new XUnit(yBd + yLineH3 * lineIdx++, unit)));

            lineIdx = 1;
            if (string.IsNullOrEmpty(Pump.Manufacturer))
                gfx.DrawString($"{Pump.ModellName}", h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            else
                gfx.DrawString($"{Pump.ModellName} ({Pump.Manufacturer})", h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            if (Pump.IsVarioPump)
                gfx.DrawString($"{_rpm} min^-1 (P1 = {powerInput:f3} kW)", h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            gfx.DrawString($"{filterDiameter:f0} mm (A = {filterArea:f1} cm²)", h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            gfx.DrawString($"{poolVolume:f1} m³", h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            if (SuctionPipe != null)
                gfx.DrawString(SuctionPipe.ToString(), h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            else
                gfx.DrawString("nicht angegeben", p3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * lineIdx++, unit)));
            gfx.DrawString($"{FilterPressure:f2} bar", h3, XBrushes.Black, new XPoint(t10, new XUnit(yBd + yLineH3 * lineIdx++, unit)));


            int yCalc = 89;
            if (Pump.IsVarioPump)
                yCalc = 92;

            gfx.DrawString("Berechnung", h2, XBrushes.Black, new XPoint(t1, new XUnit(yCalc + yOffsH3, unit)));

            gfx.DrawString("Pumpenvordruck:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yCalc + yLineH3, unit)));
            gfx.DrawString("Förderhöhe:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yCalc + yLineH3 * 2, unit)));
            gfx.DrawString("Volumenstrom:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yCalc + yLineH3 * 3, unit)));
            gfx.DrawString("Arbeitspunkt auf Pumpenkennlinie", p3, XBrushes.Black, new XPoint(t2, new XUnit(yCalc + yLineH3 * 4, unit)));

            if (SuctionPipe != null)
                gfx.DrawString($"{SuctionPressureDrop:f3} bar", h3, XBrushes.Black, new XPoint(t10, new XUnit(yCalc + yLineH3, unit)));
            else
                gfx.DrawString("0 bar (nicht berechnet)", p3, XBrushes.Black, new XPoint(t10, new XUnit(yCalc + yLineH3, unit)));
            gfx.DrawString($"{SystemHead:f2} mWS ({SystemPressure:f3} bar)", h3, XBrushes.Black, new XPoint(t10, new XUnit(yCalc + yLineH3 * 2, unit)));
            gfx.DrawString($"{SystemFlowRate:f2} m³/h", h3, XBrushes.Black, new XPoint(t10, new XUnit(yCalc + yLineH3 * 3, unit)));



            var stream = new MemoryStream();

            ImageCodecInfo pngEncoder = GetEncoder(ImageFormat.Png);
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);
            myEncoderParameters.Param[0] = myEncoderParameter;

            pklImage.Save(stream, pngEncoder, myEncoderParameters);
            stream.Position = 0;

            var pkl = XImage.FromStream(stream);

            var imageFrame = new XRect(
                new XPoint(t3, new XUnit(yCalc + 32, unit)),
                new XPoint(new XUnit(180, unit), new XUnit(yCalc + 127, unit)));
            gfx.DrawImage(pkl, imageFrame);


            var filter = new Pipe(1, filterDiameter, 0.01);
            var filterSpeed = filter.CalcFlowVelocity(SystemFlowRate) * 3600;
            var filterSpeedBrush = XBrushes.Green;
            if (Pump.IsVarioPump)
                filterSpeedBrush = XBrushes.DarkGray;
            else if (filterSpeed > 60 || filterSpeed < 40)
                filterSpeedBrush = XBrushes.Red;
            else if (filterSpeed > 55 || filterSpeed < 45)
                filterSpeedBrush = XBrushes.Orange;

            var tCycle1 = TimeSpan.FromHours(poolVolume / SystemFlowRate);
            var tCycle3 = TimeSpan.FromHours(poolVolume / SystemFlowRate *3);

            int yRes = 220;

            gfx.DrawString("Auswertung", h2, XBrushes.Black, new XPoint(t1, new XUnit(yRes + yOffsH3, unit)));

            gfx.DrawString("Umwälzzeiten", p3, XBrushes.Black, new XPoint(t2, new XUnit(yRes + yLineH3, unit)));
            gfx.DrawString("1-fach:", p3, XBrushes.Black, new XPoint(t10 - 50, new XUnit(yRes + yLineH3, unit)));
            gfx.DrawString("3-fach:", p3, XBrushes.Black, new XPoint(t10 - 50, new XUnit(yRes + yLineH3 * 2, unit)));
            gfx.DrawString("Filtergeschwindigkeit:", p3, XBrushes.Black, new XPoint(t2, new XUnit(yRes + yLineH3 * 3, unit)));


            if (tCycle1.TotalHours > 24)
                gfx.DrawString($"> 24 Stunden", h3, XBrushes.Red, new XPoint(t10, new XUnit(yRes + yLineH3, unit)));
            else
            {
                gfx.DrawString($"{tCycle1.Hours} Stunden {tCycle1.Minutes} Minuten", h3, XBrushes.Black, new XPoint(t10, new XUnit(yRes + yLineH3, unit)));
                if (powerInput > 0)
                    gfx.DrawString($"({tCycle1.TotalHours * powerInput:f1} kWh)", h3, XBrushes.Black, new XPoint(t16, new XUnit(yRes + yLineH3, unit)));
            }

            if (tCycle3.TotalHours > 24)
                gfx.DrawString($"> 24 Stunden", h3, XBrushes.Red, new XPoint(t10, new XUnit(yRes + yLineH3 * 2, unit)));
            else
            {
                gfx.DrawString($"{tCycle3.Hours} Stunden {tCycle3.Minutes} Minuten", h3, XBrushes.Black, new XPoint(t10, new XUnit(yRes + yLineH3 * 2, unit)));
                if (powerInput > 0)
                    gfx.DrawString($"({tCycle3.TotalHours * powerInput:f1} kWh)", h3, XBrushes.Black, new XPoint(t16, new XUnit(yRes + yLineH3 * 2, unit)));
            }

            gfx.DrawString($"{filterSpeed:f2} m/h", h3, filterSpeedBrush, new XPoint(t10, new XUnit(yRes + yLineH3 * 3, unit)));


            var tf = new XTextFormatter(gfx);

            tf.DrawString("Im privaten Poolbereich sollte die Filtergeschwindigkeit nicht über 50 m/h betragen.\r\n" + 
                "Mit einer langsameren Filtergeschwindigkeit von rund 30 m/h würde das Ergebnis der Filtration zwar verbessert werden. " +
                "Jedoch sind für Rückspülung (Reinigung des Filters) Spülgeschwindigkeiten von 50-60 m/h erforderlich. Da die Filterpumpe " +
                "in privaten Pool für Filtration und Rückspülung ausgelegt wird, wählt man als Kompromiss eine Filtergeschwindigkeit um 50 m/h.\r\n" +
                "Bei der tatsächlichen Laufzeit der Pumpe gilt es zu beachten, dass das Poolwasser am Tag eine gewisse Zeit bewegt werden sollte. Ein "+
                "guter Richtwert für eine Untergrenze wären 8 Stunden, unabhängig von der berechneten Umwälzzeit.",
                p0, XBrushes.Black,
              new XRect(
                  new XPoint(t2, new XUnit(yRes + yLineH3 * 4, unit)),
                  new XPoint(new XUnit(200, unit), new XUnit(276, unit))),
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

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
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
