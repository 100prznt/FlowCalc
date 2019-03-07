using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    public class Pipe
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Innerer Rohrdurchmesser
        /// in [mm]
        /// </summary>
        public double Diameter { get; set; }

        /// <summary>
        /// Rohrquerschnitt
        /// in mm^2
        /// </summary>
        public double CrossArea
        {
            get
            {
                return Math.Pow(Diameter, 2) * (4 / Math.PI);
            }
        }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for Pipe
        /// </summary>
        public Pipe()
        {

        }

        #endregion Constructor

        #region Services
        /// <summary>
        /// Berechnet die Strömungsgeschwindigkeit
        /// </summary>
        /// <param name="flowRate">Volumenstrom in [m^3/h]</param>
        /// <returns>Strömungsgeschwindigkeit in [m/s]</returns>
        public double CalcFlowVelocity(double flowRate)
        {
            double q = flowRate / 3600; // [m^3/s]
            double a = CrossArea / 1E6; // [m^2]

            return q / a;
        }

        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
