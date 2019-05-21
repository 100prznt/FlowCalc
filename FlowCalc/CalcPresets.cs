using FlowCalc.Mathematics;
using FlowCalc.PoolSystem;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FlowCalc
{
    /// <summary>
    /// Voreinstellungen für die Berechnung
    /// </summary>
    [Serializable]
    public class CalcPresets
    {
        public static readonly DoubleLimits RoughnessLimits = new DoubleLimits()
        {
            LowerLimit = 0,
            UpperLimit = 1
        };

        public static readonly DoubleLimits MetresAboveSeaLevelLimits = new DoubleLimits()
        {
            LowerLimit = -50,
            UpperLimit = 2500
        };

        #region Member
        double m_MetresAboveSeaLevel;
        double m_Roughness;

        #endregion Member

        #region Properties
        [XmlAnyElement("MediumComment")]
        public XmlComment MediumComment
        {
            get
            {
                return new XmlDocument().CreateComment("Changes made to the media parameters here are not taken into account by the program!");
            }
            set { }
        }

        /// <summary>
        /// Medium
        /// </summary>
        [Category("Medium")]
        [DisplayName("Medium")]
        public Medium Medium { get; set; }

        /// <summary>
        /// Höhe über dem Meeresspiegel (N.N.) in m
        /// </summary>
        [Category("Umgebung")]
        [DisplayName("Höhe über dem Meeresspiegel in m")]
        [XmlElement("Masl")]
        public double MetresAboveSeaLevel
        {
            get
            {
                return m_MetresAboveSeaLevel;
            }
            set
            {
                var res = value.CheckLimits(MetresAboveSeaLevelLimits);
                if (res == CheckLimitResult.ValuePassLimits)
                    m_MetresAboveSeaLevel = value;
                else
                    throw new ArgumentOutOfRangeException("MetresAboveSeaLevel not in limits! Checkresult: " + res);
            }
        }

        /// <summary>
        /// Rohrrauheit in [mm]
        /// </summary>
        [Category("Rohr")]
        [DisplayName("Rohrrauheit in mm")]
        public double Roughness
        {
            get
            {
                return m_Roughness;
            }
            set
            {
                var res = value.CheckLimits(RoughnessLimits);
                if (res == CheckLimitResult.ValuePassLimits)
                    m_Roughness = value;
                else
                    throw new ArgumentOutOfRangeException("Roughness not in limits! Checkresult: " + res);
            }
        }

        /// <summary>
        /// Standard-Voreinstellungen erzeugen
        /// </summary>
        [XmlIgnore]
        public static CalcPresets Default
        {
            get
            {
                var defalut = new CalcPresets()
                {
                    Medium = Medium.Water20,
                    MetresAboveSeaLevel = 0,
                    Roughness = 0.1
                };

                return defalut;
            }
        }

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
        /// Im XML Format speichern
        /// </summary>
        /// <param name="path">Pfad unter welchem die Datei angelegt wird</param>
        public void ToFile(string path)
        {
            var xs = new XmlSerializer(typeof(CalcPresets));

            using (var sw = new StreamWriter(path))
            {
                xs.Serialize(sw, this);
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
            var xs = new XmlSerializer(typeof(CalcPresets));

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
