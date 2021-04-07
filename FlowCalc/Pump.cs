using csmatio.io;
using csmatio.types;
using FlowCalc.Mathematics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FlowCalc
{
    /// <summary>
    /// Pumpendefinition
    /// </summary>
    [Serializable]
    public class Pump
    {
        #region Constants

        public const char CSV_SEPERATOR = ';';
        public const char CSV_TEXT_QUALIFIER = '\"';
        public const int CSV_COL_COUNT = 3;
        #endregion Constants

        #region Member

        #endregion Member

        #region Properties
        /// <summary>
        /// Modellname der Pumpe
        /// </summary>
        [Category("Pumpe")]
        [DisplayName("Modell")]
        [XmlElement("Modell")]
        public string ModellName { get; set; }

        /// <summary>
        /// Pumpenhersteller
        /// </summary>
        [Category("Pumpe")]
        [DisplayName("Hersteller")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Nennvolumenstrom Q_N
        /// in [m^3/h]
        /// bei Nennförderhöhe
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Fördermenge in m³/h")]
        [Description("Nominale Fördermenge (Volumenstrom).")]
        [XmlElement("NominalQ")]
        public double NominalFlowRate { get; set; }

        /// <summary>
        /// Nenn Meter Wassersäule (Förderhöhe) H_N
        /// in [m WS]
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Förderhöhe in m WS")]
        [Description("Nominale Förderhöhe.")]
        [XmlElement("NominalH")]
        public double NominalDynamicHead { get; set; }

        /// <summary>
        /// Leistungsaufname Motor P_1
        /// in [kW]
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Leistungsaufnahme in kW (P1)")]
        [Description("Leistungaufnahme")]
        public double PowerInput { get; set; }

        /// <summary>
        /// Leistung an der Motorwelle P_2
        /// in [kW]
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Motorleistung in kW (P2)")]
        [Description("Leistung an der Motorwelle.")]
        public double PowerOutput { get; set; }


        /// <summary>
        /// Name des Erstellers der Pumpendefinition
        /// </summary>
        [Category("Metadaten")]
        [DisplayName("Autor")]
        [Description("Name des Erstellers der Pumpendefinition.")]
        [XmlElement("Author")]
        public string AuthorPumpFile { get; set; }

        /// <summary>
        /// Emailadresse des Erstellers der Pumpendefinition
        /// </summary>
        [Category("Metadaten")]
        [DisplayName("Autor Email")]
        [Description("Email Adresse des Erstellers der Pumpendefinition.")]
        [XmlElement("AuthorEmail")]
        public string AuthorEmailPumpFile { get; set; }

        /// <summary>
        /// Quelle der Pumpendaten
        /// </summary>
        [Category("Metadaten")]
        [DisplayName("Datenquelle (URL)")]
        [Description("Quelle der Pumpendaten, zum Beispiel Hersteller-Website.")]
        public string DataSourceUrl { get; set; }

        /// <summary>
        /// Leistungskurve
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Pumpenkennlinie")]
        [Description("Stützpunkte der Pumpenkennlinie.")]
        [Editor(typeof(IppCollectionEditor), typeof(UITypeEditor))]
        [XmlArrayItem("Ipp")]
        public PumpPerformancePoint[] PerformanceCurve { get; set; }

        /// <summary>
        /// Drehzahlabhängige Leistungskurven
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Drehzahlabhängige Pumpenkennlinien")]
        [Description("Im Datenblatt angegebene Pumpenkennlinien für bestimmte Motor Drehzahlen")]
        [XmlArrayItem("DynamicPerformanceCurve")]
        public PumpDynamicPerformanceCurve[] DynamicPerformanceCurves { get; set; }

        ///// <summary>
        ///// Maximale Meter Wassersäule (Förderhöhe)
        ///// in [m WS]
        ///// </summary>
        //[Category("Leistungsdaten")]
        //[DisplayName("Maximale Förderhöhe in m WS")]
        //[Description("Maximale Förderhöhe, Angabe wird anhand der Pumpenkennlinie automatisch generiert.")]
        //[XmlIgnore]
        //public double MaxTotalHead
        //{
        //    get
        //    {
        //        if (PerformanceCurve == null || PerformanceCurve.Length <= 0)
        //            return 0;
        //        else
        //            return PerformanceCurve.Max(x => x.TotalDynamicHead);
        //    }
        //}

        /// <summary>
        /// Pumpe mit variabler Drehzahl
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Pumpe mit variabler Drehzahl")]
        [Description("Die Pumpe ist eine Vario-Pumpe mit regelbarer Drehzahl.")]
        [XmlIgnore]
        public bool IsVarioPump
        {
            get
            {
                return (PerformanceCurve == null || PerformanceCurve.Length <= 0) && DynamicPerformanceCurves != null && DynamicPerformanceCurves.Length > 0;
            }
        }

        [XmlIgnore]
        public int MinRpm
        {
            get
            {
                if (IsVarioPump)
                    return DynamicPerformanceCurves.Min(x => x.Rpm);
                else
                    return 0;
            }
        }

        [XmlIgnore]
        public int MaxRpm
        {
            get
            {
                if (IsVarioPump)
                    return DynamicPerformanceCurves.Max(x => x.Rpm);
                else
                    return 0;
            }
        }

        [XmlIgnore]
        public Polynom UpperPerformanceCurveLimit
        {
            get
            {
                if (IsVarioPump)
                {
                    var minRpmCurve = DynamicPerformanceCurves.First(x => x.Rpm == DynamicPerformanceCurves.Min(y => y.Rpm)).PerformanceCurve;
                    var maxRpmCurve = DynamicPerformanceCurves.First(x => x.Rpm == DynamicPerformanceCurves.Max(y => y.Rpm)).PerformanceCurve;

                    


                    return Polynom.Polyfit(new double[2] { minRpmCurve.First().FlowRate, maxRpmCurve.First().FlowRate},
                        new double[2] { minRpmCurve.First().TotalDynamicHead, maxRpmCurve.First().TotalDynamicHead }, 1);
                }
                else
                    return null;
            }
        }

        [Browsable(false)]
        [XmlIgnore]
        public string FilePath { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Konstruktor
        /// </summary>
        public Pump()
        {

        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Pumpen Modell-Bezeichnung</param>
        /// <param name="manufracturer">Pumpen Hersteller</param>
        public Pump(string name, string manufracturer)
        {
            ModellName = name;
            Manufacturer = manufracturer;
        }

        #endregion Constructor

        #region Services
        /// <summary>
        /// Im Standard-Format (XML) speichern
        /// </summary>
        /// <param name="path">Pfad unter welchem die Datei angelegt wird</param>
        public void ToFile(string path)
        {
            ToXmlFile(path);
        }

        /// <summary>
        /// Im XML Format speichern
        /// </summary>
        /// <param name="path">Pfad unter welchem die Datei angelegt wird</param>
        public void ToXmlFile(string path)
        {
            var xs = new XmlSerializer(typeof(Pump));

            using (var sw = new StreamWriter(path))
            {
                xs.Serialize(sw, this);
            }
        }

        /// <summary>
        /// Im JSON Format speichern
        /// </summary>
        /// <param name="path">Pfad unter welchem die Datei angelegt wird</param>
        public void ToJsonFile(string path)
        {
            using (var sw = new StreamWriter(path))
            {
                sw.Write(JsonConvert.SerializeObject(this, Formatting.Indented));
                sw.Flush();
            }
        }

        /// <summary>
        /// Im CSV Format speichern
        /// </summary>
        /// <param name="path">Pfad unter welchem die Datei angelegt wird</param>
        public void ToCsvFile(string path)
        {
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(GenerateCsvLine(CSV_COL_COUNT, nameof(ModellName), ModellName));
                sw.WriteLine(GenerateCsvLine(CSV_COL_COUNT, nameof(Manufacturer), Manufacturer));
                sw.WriteLine(GenerateCsvLine(CSV_COL_COUNT, nameof(NominalFlowRate), NominalFlowRate));
                sw.WriteLine(GenerateCsvLine(CSV_COL_COUNT, nameof(NominalDynamicHead), NominalDynamicHead));
                sw.WriteLine(GenerateCsvLine(CSV_COL_COUNT, nameof(PowerOutput), PowerOutput));
                sw.WriteLine(GenerateCsvLine(CSV_COL_COUNT, nameof(AuthorPumpFile), AuthorPumpFile));
                sw.WriteLine(GenerateCsvLine(CSV_COL_COUNT, nameof(AuthorEmailPumpFile), AuthorEmailPumpFile));
                sw.WriteLine(GenerateCsvLine(CSV_COL_COUNT, nameof(PerformanceCurve), nameof(PumpPerformancePoint.TotalDynamicHead), nameof(PumpPerformancePoint.FlowRate)));

                sw.WriteLine();
                foreach (var ipp in PerformanceCurve)
                {
                    sw.WriteLine(GenerateCsvLine(CSV_COL_COUNT, null, ipp.TotalDynamicHead, ipp.FlowRate));
                }
                sw.Flush();
            }
        }

        /// <summary>
        /// Im Matlab (MAT) Format speichern
        /// </summary>
        /// <param name="path">Pfad unter welchem die Datei angelegt wird</param>
        public void ToMatFile(string path)
        {
            var mlList = new List<MLArray>();

            if (IsVarioPump)
            {
                foreach (var rpm in GetDefaultRpms())
                {
                    mlList.Add(new MLDouble("H_" + rpm, GetPerformanceHeadValues(rpm), 1));
                    mlList.Add(new MLDouble("Q_" + rpm, GetPerformanceFlowValues(rpm), 1));
                }
            }
            else
            {
                mlList.Add(new MLDouble("H", GetPerformanceHeadValues(), 1));
                mlList.Add(new MLDouble("Q", GetPerformanceFlowValues(), 1));
            }

            MatFileWriter mfw = new MatFileWriter(path, mlList, false);
        }

        /// <summary>
        /// Objekt aus xml-Datei generieren
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Pump FromFile(string path)
        {
            Pump pump;
            var xs = new XmlSerializer(typeof(Pump));

            using (var sr = new StreamReader(path))
            {
                pump = (Pump)xs.Deserialize(sr);
            }

            if (pump.IsVarioPump)
            {
                if (pump.DynamicPerformanceCurves.Select(x => x.Rpm).Distinct().Count() != pump.DynamicPerformanceCurves.Length)
                    throw new InvalidDataException("Leistungskurven für identische Drehzahl mehrfach definiert.");

                foreach (var pc in pump.DynamicPerformanceCurves)
                {
                    pc.PerformanceCurve = pc.PerformanceCurve.OrderBy(x => x.TotalDynamicHead).ToArray();

                    if (CheckRoutines.GetDirection(pc.GetPerformanceFlowValues()) == Direction.NotUnique)
                        throw new InvalidDataException($"Leistungskurve für {pc.Rpm} rpm ist unplausibel.");

                    if (CheckRoutines.GetDirection(pc.GetPerformanceFlowValues()) == Direction.Ascending)
                        throw new InvalidDataException($"Leistungskurve für {pc.Rpm} rpm ist unplausibel. Fördermenge steigt mit Förderhöhe.");
                }
            }
            else if (pump.PerformanceCurve == null || pump.PerformanceCurve.Length <= 0)
                throw new InvalidDataException("Leistungskurve konnte nicht geladen werden.");
            else
            {
                pump.PerformanceCurve = pump.PerformanceCurve.OrderBy(x => x.TotalDynamicHead).ToArray();

                if (CheckRoutines.GetDirection(pump.GetPerformanceFlowValues()) == Direction.NotUnique)
                    throw new InvalidDataException("Leistungskurve ist unplausibel.");

                if (CheckRoutines.GetDirection(pump.GetPerformanceFlowValues()) == Direction.Ascending)
                    throw new InvalidDataException("Leistungskurve ist unplausibel. Fördermenge steigt mit Förderhöhe.");
            }

            return pump;
        }

        public void ImportMatCurve(string path)
        {
            var mfr = new MatFileReader(path);
            var h = (mfr.GetMLArray("H") as MLDouble)?.GetArray();
            var q = (mfr.GetMLArray("Q") as MLDouble)?.GetArray();
            var hOpt = (mfr.GetMLArray("H_Opt") as MLDouble)?.GetArray();
            var qOpt = (mfr.GetMLArray("Q_Opt") as MLDouble)?.GetArray();

            var curve = new List<PumpPerformancePoint>();

            if (qOpt != null && hOpt != null && qOpt[0].Count() == hOpt[0].Count())
            {
                for (int i = 0; i < qOpt[0].Count(); i++)
                    curve.Add(new PumpPerformancePoint(hOpt[0][i], qOpt[0][i]));
            }
            else if (hOpt != null && q != null && hOpt[0].Count() == q[0].Count())
            {
                for (int i = 0; i < q.Count(); i++)
                    curve.Add(new PumpPerformancePoint(hOpt[0][i], q[0][i]));
            }
            else if (h != null && q != null && h[0].Count() == q[0].Count())
            {
                for (int i = 0; i < q[0].Count(); i++)
                    curve.Add(new PumpPerformancePoint(h[0][i], q[0][i]));
            }
            else
            {
                throw new InvalidDataException("Keine gültigen Daten in MAT-File vorhanden.");
            }
            
            PerformanceCurve = curve.ToArray();
        }

        public double[] GetPerformanceHeadValues(int? rpm = null)
        {
            if (rpm == 0 || rpm == null)
                return PerformanceCurve.Select(x => x.TotalDynamicHead).ToArray();
            else if (DynamicPerformanceCurves.Any(x => x.Rpm == rpm))
                return DynamicPerformanceCurves.First(x => x.Rpm == rpm).GetPerformanceHeadValues();
            else
            {
                var maxPerformanceFlowValues = DynamicPerformanceCurves.First(x => x.Rpm == DynamicPerformanceCurves.Max(y => y.Rpm)).PerformanceCurve.Select(x => x.FlowRate).ToArray();
                var p = GetPerformancePolynom((int)rpm);
                var pLim = UpperPerformanceCurveLimit;
                var result = new List<double>();
                var isLastPoint = true;
                foreach (var q in maxPerformanceFlowValues)
                {
                    var h = (p.Polyval(q));
                    if (h >= pLim.Polyval(q))
                        result.Add(h);
                    else if (isLastPoint)
                    {
                        isLastPoint = false;
                        var crossPoints =  p.GetCrossPoints(pLim);
                        if (crossPoints.Length == 1)
                            result.Add(p.Polyval(crossPoints[0]));
                    }
                }
                return result.ToArray();
            }
        }

        public double[] GetPerformanceFlowValues(int? rpm = null)
        {
            if (rpm == null)
                return PerformanceCurve.Select(x => x.FlowRate).ToArray();
            else if (DynamicPerformanceCurves.Any(x => x.Rpm == rpm))
                return DynamicPerformanceCurves.First(x => x.Rpm == rpm).GetPerformanceFlowValues();
            else
            {
                var maxPerformanceFlowValues = DynamicPerformanceCurves.First(x => x.Rpm == DynamicPerformanceCurves.Max(y => y.Rpm)).PerformanceCurve.Select(x => x.FlowRate).ToArray();
                var p = GetPerformancePolynom((int)rpm);
                var pLim = UpperPerformanceCurveLimit;
                var result = new List<double>();
                var isLastPoint = true;
                foreach (var q in maxPerformanceFlowValues)
                {
                    var h = (p.Polyval(q));
                    if (h >= pLim.Polyval(q))
                        result.Add(q);
                    else if (isLastPoint)
                    {
                        isLastPoint = false;
                        var crossPoints = p.GetCrossPoints(pLim);
                        if (crossPoints.Length == 1)
                            result.Add(crossPoints[0]);
                    }
                }
                return result.ToArray();


                //var maxRpmCurve = DynamicPerformanceCurves.First(x => x.Rpm == DynamicPerformanceCurves.Max(y => y.Rpm)).PerformanceCurve;
                //return maxRpmCurve.Select(x => x.FlowRate).ToArray();
            }
        }

        public Tuple<double[], double[]> GetPerformanceRange()
        {
            var minRpm = MinRpm;
            var maxRpm = MaxRpm;

            var pLower = GetPerformancePolynom(minRpm);
            var pUpper = GetPerformancePolynom(maxRpm);
            var pQCut = UpperPerformanceCurveLimit;

            var lowerCrossPoint = pLower.GetCrossPoints(pQCut);
            var upperCrossPoint = pUpper.GetCrossPoints(pQCut);

            if (lowerCrossPoint.Length != 1 || upperCrossPoint.Length != 1)
                throw new ArithmeticException("Mathematikfehler bei der Berechnung des Arbeitsbereiches.");

            var x = new List<double>();
            var y = new List<double>();

            //Kennlinie für kleinste Drehzahl
            for (double i = 0; i < lowerCrossPoint[0]; i += 0.25)
            {
                x.Add(i);
                y.Add(pLower.Polyval(i));
            }
            //Schnittpunkt KL kleinste Drehzahl mit oberem Q-Limit
            x.Add(lowerCrossPoint[0]);
            y.Add(pQCut.Polyval(lowerCrossPoint[0]));
            //Schnittpunkt KL maximale Drehzahl mit oberem Q-Limit
            x.Add(upperCrossPoint[0]);
            y.Add(pQCut.Polyval(upperCrossPoint[0]));

            //Kennlinie für maximale Drehzahl
            var xTemp = new List<double>();
            var yTemp = new List<double>();
            for (double i = 0; i < upperCrossPoint[0]; i += 0.25)
            {
                xTemp.Add(i);
                yTemp.Add(pUpper.Polyval(i));
            }
            xTemp.Reverse();
            yTemp.Reverse();
            x.AddRange(xTemp);
            y.AddRange(yTemp);
            x.Add(x.First());
            y.Add(y.First());

            return new Tuple<double[], double[]>(x.ToArray(), y.ToArray());
        }

        public int[] GetDefaultRpms()
        {
            if (IsVarioPump)
                return DynamicPerformanceCurves.Select(x => x.Rpm).ToArray();
            else
                return null;
        }

        public double GetMaxTotalHead(int? rpm = null)
        {
            return GetPerformanceHeadValues(rpm).Max();
        }

        public double GetInputPower(int rpm)
        {
            var x_n = DynamicPerformanceCurves.Select(x => (double)x.Rpm).ToArray();
            var y_P = DynamicPerformanceCurves.Select(x => x.PowerInput).ToArray();

            if (x_n.Count() != y_P.Count())
                throw new ArgumentException("Angegebene drehzahlabhängige Leistungsdaten unplausibel.");

            var p = Polynom.Polyfit(x_n, y_P, 2);

            return p.Polyval(rpm);
        }

        #endregion Services

        #region Internal services

        private Polynom GetPerformancePolynom(int rpm)
        {
            if (!IsVarioPump)
                return null;

            if (DynamicPerformanceCurves.Any(x => x.Rpm == rpm))
            {
                return DynamicPerformanceCurves.First(x => x.Rpm == rpm).GetPerformancePolynom();
            }

            var upperCurve = DynamicPerformanceCurves.First(x => x.Rpm > rpm);
            var lowerCurve = DynamicPerformanceCurves.Last(x => x.Rpm < rpm);

            var rpmDelta = upperCurve.Rpm - lowerCurve.Rpm;
            var rpmGap = rpm - lowerCurve.Rpm;

            var result = new Polynom(0, 0, 0, 0);

            for (int i = 0; i < 4; i++)
            {
                var coefficientDelta = upperCurve.GetPerformancePolynom().Coefficients[i] - lowerCurve.GetPerformancePolynom().Coefficients[i];

                result.Coefficients[i] = lowerCurve.GetPerformancePolynom().Coefficients[i] + coefficientDelta * rpmGap / rpmDelta;
            }

            return result;
        }

        

        private string GenerateCsvLine(params object[] items)
        {
            return GenerateCsvLine(0, items);
        }

        private string GenerateCsvLine(int cols, params object[] items)
        {
            if (cols == 0)
                cols = items.Length;
            else
                if (items.Length > cols)
                    throw new ArgumentException("Anzahl der übergebenen Elemente (" + items.Length + "), passt nicht in die vorgegebene Spaltenanzahl (" + cols + ").");
            
            var sb = new StringBuilder();

            foreach (var item in items)
            {
                if (item != null)
                {
                    if (item.GetType() == typeof(string))
                        sb.Append(CSV_TEXT_QUALIFIER + (string)item + CSV_TEXT_QUALIFIER);
                    else
                        sb.Append(item);
                }

                if (cols > 1)
                {
                    sb.Append(CSV_SEPERATOR);
                    cols--;
                }
            }

            if (cols > 1)
                sb.Append(string.Empty.PadLeft(cols, CSV_SEPERATOR));

            return sb.ToString();
        }

        #endregion Internal services

        #region Events


        #endregion Events
    }
}
