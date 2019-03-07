using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    /// <summary>
    /// Medienparameter
    /// </summary>
    [Serializable]
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

        #endregion Properties

        #region Static services
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
