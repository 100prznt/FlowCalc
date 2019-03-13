using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FlowCalc.PoolSystem
{
    /// <summary>
    /// Pumpendefinition
    /// </summary>
    [DebuggerDisplay("{DisplayName} {Diameter} L_Ä={EquivalentLength} m")]
    [Serializable]
    public class Fitting
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Anzeigename des Fittings
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Eindeutiger Name
        /// entspricht Dateiname der Definition
        /// </summary>
        public string UniqueName
        {
            get
            {
                var fileName = FilePath.Split('\\', '/').Last();
                return fileName.Substring(0, fileName.Length - 4); //Extension (.xml) entfernen
            }
        }

        public NominalDiameters Diameter { get; set; }

        /// <summary>
        /// Zeta-Wert (Druckverlustbeiwert)
        /// </summary>
        public double Zeta { get; set; }

        /// <summary>
        /// Äquivalente Länge
        /// in [m]
        /// </summary>
        public double EquivalentLength { get; set; }

        [Browsable(false)]
        [XmlIgnore]
        public string FilePath { get; set; }

        /// <summary>
        /// Quellangabe
        /// </summary>
        public string Source { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Konstruktor
        /// </summary>
        public Fitting()
        {

        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Anzeige Name</param>
        /// <param name="diameter">Nenndurchmesser</param>
        public Fitting(string name, NominalDiameters diameter)
        {
            DisplayName = name;
            Diameter = diameter;
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
            var xs = new XmlSerializer(typeof(Fitting));

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
        public static Fitting FromFile(string path)
        {
            Fitting fitting;
            var xs = new XmlSerializer(typeof(Fitting));

            using (var sr = new StreamReader(path))
            {
                fitting = (Fitting)xs.Deserialize(sr);
            }

            return fitting;
        }

        #endregion Services

        #region Internal services

        #endregion Internal services

        #region Events


        #endregion Events
    }
}
