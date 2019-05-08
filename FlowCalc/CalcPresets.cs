using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace FlowCalc
{
    /// <summary>
    /// Voreinstellungen für die Berechnung
    /// </summary>
    [Serializable]
    public class CalcPresets
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Rohrrauheit in [mm]
        /// </summary>
        [Category("Rohr")]
        [DisplayName("Rohrrauheit in mm")]
        public string Roughness { get; set; }

        /// <summary>
        /// Wasertemperatur in [°C]
        /// </summary>
        [Category("Wasser")]
        [DisplayName("Temperatur in °C")]
        public double WaterTemperature { get; set; }

        /// <summary>
        /// Nennvolumenstrom Q_N
        /// in [m^3/h]
        /// bei Nennförderhöhe
        /// </summary>
        [Category("Umgebung")]
        [DisplayName("Höhe über dem Meeresspiegel in m")]
        [XmlElement("Masl")]
        public double MetresAboveSeaLevel { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Konstruktor
        /// </summary>
        public CalcPresets()
        {

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
            var xs = new XmlSerializer(typeof(CalcPresets));

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
        /// Objekt aus xml-Datei generieren
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static CalcPresets FromFile(string path)
        {
            CalcPresets presets;
            var xs = new XmlSerializer(typeof(Pump));

            using (var sr = new StreamReader(path))
            {
                presets = (CalcPresets)xs.Deserialize(sr);
            }

            return presets;
        }

        #endregion Services

        #region Internal services

        #endregion Internal services

        #region Events


        #endregion Events
    }
}
