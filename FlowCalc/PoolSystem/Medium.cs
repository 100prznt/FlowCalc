using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    /// <summary>
    /// Medienparameter
    /// </summary>
    [Serializable]
    [DebuggerDisplay("{DisplayName}")]
    public class Medium
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Name des Mediums
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Temperatur
        /// in [°C]
        /// </summary>
        public double Temperature { get; set; }

        /// <summary>
        /// Dichte
        /// in [kg/m^3]
        /// </summary>
        public double Density { get; set; }

        /// <summary>
        /// Dynamische Viskosität
        /// in [10E-6 kg/ms]
        /// </summary>
        public double DynamicViscosity { get; set; }

        /// <summary>
        /// Kinetische Viskosität
        /// in [10E-6 m^2/s]
        /// </summary>
        public double KineticViscosity { get; set; }

        public string DisplayName
        {
            get
            {
                return string.Format("{0} {1:F1} °C", Name, Temperature);
            }
        }

        #endregion Properties

        #region Static services
        //Siehe auch: https://srd.nist.gov/jpcrdreprint/1.555581.pdf

        /// <summary>
        /// <para>Wasser bei 5 °C</para>
        /// Stoffwerte übernommen von: http://www.uni-magdeburg.de/isut/LSS/Lehre/Arbeitsheft/IV.pdf
        /// </summary>
        public static Medium Water5
        {
            get
            {
                return new Medium()
                {
                    Name = "Wasser",
                    Temperature = 5,
                    Density = 999.97,
                    DynamicViscosity = 1518.7,
                    KineticViscosity = 1.519
                };
            }
        }

        /// <summary>
        /// <para>Wasser bei 10 °C</para>
        /// Stoffwerte übernommen von: http://www.uni-magdeburg.de/isut/LSS/Lehre/Arbeitsheft/IV.pdf
        /// </summary>
        public static Medium Water10
        {
            get
            {
                return new Medium()
                {
                    Name = "Wasser",
                    Temperature = 10,
                    Density = 999.7,
                    DynamicViscosity = 1306.4,
                    KineticViscosity = 1.307
                };
            }
        }

        /// <summary>
        /// <para>Wasser bei 15 °C</para>
        /// Stoffwerte übernommen von: http://www.uni-magdeburg.de/isut/LSS/Lehre/Arbeitsheft/IV.pdf
        /// </summary>
        public static Medium Water15
        {
            get
            {
                return new Medium()
                {
                    Name = "Wasser",
                    Temperature = 15,
                    Density = 999.1,
                    DynamicViscosity = 1138,
                    KineticViscosity = 1.139
                };
            }
        }

        /// <summary>
        /// <para>Wasser bei 20 °C</para>
        /// Stoffwerte übernommen von: http://www.uni-magdeburg.de/isut/LSS/Lehre/Arbeitsheft/IV.pdf
        /// </summary>
        public static Medium Water20
        {
            get
            {
                return new Medium()
                {
                    Name = "Wasser",
                    Temperature = 20,
                    Density = 998.21,
                    DynamicViscosity = 1002,
                    KineticViscosity = 1.004
                };
            }
        }

        /// <summary>
        /// <para>Wasser bei 25 °C</para>
        /// Stoffwerte übernommen von: http://www.uni-magdeburg.de/isut/LSS/Lehre/Arbeitsheft/IV.pdf
        /// </summary>
        public static Medium Water25
        {
            get
            {
                return new Medium()
                {
                    Name = "Wasser",
                    Temperature = 25,
                    Density = 997.05,
                    DynamicViscosity = 890.45,
                    KineticViscosity = 0.893
                };
            }
        }

        /// <summary>
        /// <para>Wasser bei 30 °C</para>
        /// Stoffwerte übernommen von: http://www.uni-magdeburg.de/isut/LSS/Lehre/Arbeitsheft/IV.pdf
        /// </summary>
        public static Medium Water30
        {
            get
            {
                return new Medium()
                {
                    Name = "Wasser",
                    Temperature = 30,
                    Density = 995.65,
                    DynamicViscosity = 797.68,
                    KineticViscosity = 0.801
                };
            }
        }

        /// <summary>
        /// <para>Wasser bei 35 °C</para>
        /// Stoffwerte übernommen von: http://www.uni-magdeburg.de/isut/LSS/Lehre/Arbeitsheft/IV.pdf
        /// </summary>
        public static Medium Water35
        {
            get
            {
                return new Medium()
                {
                    Name = "Wasser",
                    Temperature = 35,
                    Density = 994.03,
                    DynamicViscosity = 719.62,
                    KineticViscosity = 0.724
                };
            }
        }

        /// <summary>
        /// <para>Wasser bei 40 °C</para>
        /// Stoffwerte übernommen von: http://www.uni-magdeburg.de/isut/LSS/Lehre/Arbeitsheft/IV.pdf
        /// </summary>
        public static Medium Water40
        {
            get
            {
                return new Medium()
                {
                    Name = "Wasser",
                    Temperature = 40,
                    Density = 993.22,
                    DynamicViscosity = 653.25,
                    KineticViscosity = 0.658
                };
            }
        }

        /// <summary>
        /// <para>Wasser bei 45 °C</para>
        /// Stoffwerte übernommen von: http://www.uni-magdeburg.de/isut/LSS/Lehre/Arbeitsheft/IV.pdf
        /// </summary>
        public static Medium Water45
        {
            get
            {
                return new Medium()
                {
                    Name = "Wasser",
                    Temperature = 45,
                    Density = 990.21,
                    DynamicViscosity = 596.32,
                    KineticViscosity = 0.602
                };
            }
        }

        /// <summary>
        /// <para>Wasser bei 50 °C</para>
        /// Stoffwerte übernommen von: http://www.uni-magdeburg.de/isut/LSS/Lehre/Arbeitsheft/IV.pdf
        /// </summary>
        public static Medium Water50
        {
            get
            {
                return new Medium()
                {
                    Name = "Wasser",
                    Temperature = 50,
                    Density = 988.04,
                    DynamicViscosity = 547.08,
                    KineticViscosity = 0.554
                };
            }
        }
        #endregion Static services

        #region Constructor
        /// <summary>
        /// Empty constructor for Medium
        /// </summary>
        public Medium()
        {

        }

        #endregion Constructor

        #region Services

        #endregion Services
        
        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
