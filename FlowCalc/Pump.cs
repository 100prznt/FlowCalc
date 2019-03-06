using FlowCalc.Mathematics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Modellname der Pumpe
        /// </summary>
        public string ModellName { get; set; }

        /// <summary>
        /// Pumpenhersteller
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Nennvolumenstrom Q_N
        /// in [m^3/h]
        /// bei Nennförderhöhe
        /// </summary>
        public double NominalFlowRate { get; set; }

        /// <summary>
        /// Nenn Meter Wassersäule (Förderhöhe) H_N
        /// in [mWS]
        /// </summary>
        public double NominalDynamicHead { get; set; }

        /// <summary>
        /// Leistung an der Motorwelle P_2
        /// in [kW]
        /// </summary>
        public double PowerOutput { get; set; }

        /// <summary>
        /// Leistungskurve
        /// </summary>
        public List<PumpPerformancePoint> PerformanceCurve { get; set; }

        /// <summary>
        /// Maximale Meter Wassersäule (Förderhöhe)
        /// in [m]
        /// </summary>
        public double MaxTotalHead
        {
            get
            {
                if (PerformanceCurve == null || PerformanceCurve.Count <= 0)
                    return 0;
                else
                    return PerformanceCurve.Max(x => x.TotalDynamicHead);
            }
        }

        /// <summary>
        /// Name des Erstellers der Pumpendefinition
        /// </summary>
        public string AuthorPumpFile { get; set; }

        /// <summary>
        /// Emailadresse des Erstellers der Pumpendefinition
        /// </summary>
        public string AuthorEmailPumpFile { get; set; }

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

            PerformanceCurve = new List<PumpPerformancePoint>();
        }

        #endregion Constructor

        #region Services
        /// <summary>
        /// Als xml-Datei speichern
        /// </summary>
        /// <param name="path"></param>
        public void ToFile(string path)
        {
            //var xs = new XmlSerializer(typeof(Pump));

            //using (var sw = new StreamWriter(path))
            //{
            //    xs.Serialize(sw, this);
            //}


            using (var sw = new StreamWriter(path))
            {
                sw.Write(JsonConvert.SerializeObject(this, Formatting.Indented));
                sw.Flush();
            }
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

            pump.PerformanceCurve = pump.PerformanceCurve.OrderBy(x => x.TotalDynamicHead).ToList();

            if (CheckRoutines.GetDirection(pump.GetPerformanceFlowValues()) == Direction.NotUnique)
                throw new InvalidDataException("Leistungskurve ist unplausibel.");

            if (CheckRoutines.GetDirection(pump.GetPerformanceFlowValues()) == Direction.Ascending)
                throw new InvalidDataException("Leistungskurve ist unplausibel. Fördermenge steigt mit Förderhöhe");

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


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
