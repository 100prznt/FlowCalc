using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    public class PipeBase
    {
        #region Properties
        /// <summary>
        /// Innerer Rohrdurchmesser
        /// in [mm]
        /// </summary>
        public double Diameter { get; set; }

        /// <summary>
        /// Rohrlänge
        /// in [m]
        /// </summary>
        public double Length { get; set; }

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

        /// <summary>
        /// EINGABE PARAMETER
        /// Volumenstrom in [m^3/h]
        /// </summary>
        public double FlowRate { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PipeBase()
        {

        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="l">Rohrlänge in [m]</param>
        /// <param name="di">Innerer Rohrdurchmesser in [mm]</param>
        public PipeBase(double l, double di)
        {
            Length = l;
            Diameter = di;
        }

        #endregion Constructor

        #region Services
        /// <summary>
        /// Strömungsgeschwindigkeit berechnen
        /// </summary>
        /// <returns>Strömungsgeschwindigkeit in [m/s]</returns>
        public double CalcFlowVelocity() => CalcFlowVelocity(FlowRate);

        /// <summary>
        /// Strömungsgeschwindigkeit berechnen
        /// </summary>
        /// <param name="flowRate">Volumenstrom in [m^3/h]</param>
        /// <returns>Strömungsgeschwindigkeit in [m/s]</returns>
        public double CalcFlowVelocity(double flowRate)
        {
            double q = flowRate / 3600; // [m^3/s]
            double a = CrossArea / 1E6; // [m^2]

            return q / a;
        }

        /// <summary>
        /// Volumenstrom berechnen
        /// </summary>
        /// <param name="flowVelocity">Strömungsgeschwindigkeit in [m/s]</param>
        /// <returns>Volumenstrom in [m^3/h]</returns>
        public double CalcFlowRate(double flowVelocity)
        {
            double a = CrossArea / 1E6; // [m^2]
            double q = flowVelocity * a; // [m^3/s]

            return q * 3600;
        }

        #endregion Services
    }
}
