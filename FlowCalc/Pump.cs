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
        /// Leistung an der Motorwelle P_2
        /// in [kW]
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Motorleistung in kW")]
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
        /// Leistungskurve
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Pumpenkennlinie")]
        [Description("Stützpunkte der Pumpenkennlinie.")]
        [Editor(typeof(IppCollectionEditor), typeof(UITypeEditor))]
        [XmlArrayItem("Ipp")]
        public PumpPerformancePoint[] PerformanceCurve { get; set; }

        /// <summary>
        /// Maximale Meter Wassersäule (Förderhöhe)
        /// in [m WS]
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Maximale Förderhöhe in m WS")]
        [Description("Maximale Förderhöhe, Angabe wird anhand der Pumpenkennlinie automatisch generiert.")]
        [XmlIgnore]
        public double MaxTotalHead
        {
            get
            {
                if (PerformanceCurve == null || PerformanceCurve.Length <= 0)
                    return 0;
                else
                    return PerformanceCurve.Max(x => x.TotalDynamicHead);
            }
        }

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
            var h = new MLDouble("H", GetPerformanceHeadValues(), 1);
            var q = new MLDouble("Q", GetPerformanceFlowValues(), 1);

            var mlList = new List<MLArray>
            {
                h,
                q
            };

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

            pump.PerformanceCurve = pump.PerformanceCurve.OrderBy(x => x.TotalDynamicHead).ToArray();

            if (pump.PerformanceCurve == null || pump.PerformanceCurve.Length <= 0)
                throw new InvalidDataException("Leistungskurve konnte nicht geladen werden.");

            if (CheckRoutines.GetDirection(pump.GetPerformanceFlowValues()) == Direction.NotUnique)
                throw new InvalidDataException("Leistungskurve ist unplausibel.");

            if (CheckRoutines.GetDirection(pump.GetPerformanceFlowValues()) == Direction.Ascending)
                throw new InvalidDataException("Leistungskurve ist unplausibel. Fördermenge steigt mit Förderhöhe.");

            return pump;
        }

        public double[] GetPerformanceHeadValues()
        {
            return PerformanceCurve.Select(x => x.TotalDynamicHead).ToArray();
        }

        public double[] GetPerformanceFlowValues()
        {
            return PerformanceCurve.Select(x => x.FlowRate).ToArray();
        }

        #endregion Services

        #region Internal services
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
