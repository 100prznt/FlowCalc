using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    public class Elbow : BaseFitting
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Mittlerer Krümmungsradius des Rohrbogens
        /// in [mm]
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Krümmungswinkel des Rohrbogens
        /// in [Grad]
        /// </summary>
        public double Angle { get; set; }

        /// <summary>
        /// Druckverlustbeiwert
        /// </summary>
        public override double Zeta
        {
            get
            {
                var x = Radius / Diameter;
                if (x < 1 || x > 10)
                    throw new IndexOutOfRangeException("Gültigkeitsbereich für Zeta-Berechnung verletzt!");

                return 0;
            }
        }
        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for Elbow
        /// </summary>
        public Elbow()
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
