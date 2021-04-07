using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc
{
    public class Filter
    {
        #region Properties
        /// <summary>
        /// Innerer Rohrdurchmesser
        /// in [mm]
        /// </summary>
        public double Diameter { get; set; }

        /// <summary>
        /// Filterbetthöhe
        /// in [mm]
        /// </summary>
        public double Height { get; set; }


        /// <summary>
        /// Rohrquerschnitt
        /// in mm^2
        /// </summary>
        public double CrossArea
        {
            get
            {
                return Math.PI * Math.Pow(Diameter, 2) / 4;
            }
        }

        #endregion Properties
    }
}
