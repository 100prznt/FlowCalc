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
        /// Rohrlänge
        /// in [m]
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Rohrrauheit
        /// in [mm]
        /// </summary>
        public double Roughness { get; set; }

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

        #region Constructor
        /// <summary>
        /// Konstruktor
        /// </summary>
        public Pipe()
        {

        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="l">Rohrlängein [m]</param>
        /// <param name="di">Innerer Rohrdurchmesser in [mm]</param>
        /// <param name="k">Rohrrauheit in [mm]</param>
        public Pipe(double l, double di, double k)
        {
            Length = l;
            Diameter = di;
            Roughness = k;
        }

        #endregion Constructor

        #region Services
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

        /// <summary>
        /// Druckverlust berechnen
        /// (es wird von einer turbulenten Strömung ausgegangen)
        /// </summary>
        /// <param name="medium">Stoffdaten</param>
        /// <param name="flowRate">Volumenstrom in [m^3/h]</param>
        /// <returns>Druckverlust in [bar]</returns>
        public double CalcPressureDrop(Medium medium, double flowRate)
        {
            double di = Diameter / 1000; // [m]
            double k = Roughness / 1000; // [m]
            double v = CalcFlowVelocity(flowRate); // [m/s]
            double kv = medium.KineticViscosity / 1E6; // [m^2/s]
            double re = v * di / kv;

            // Rohrreibungszahl (Lambda) nach Colebrook und White siehe: https://de.wikipedia.org/wiki/Rohrreibungszahl
            // Iterative Berechnung
            double lambda = 0.005; // Startwert für Lambda
            double s = 0.001; // Schrittweite für Antastung
            int i = 7; // Anzahl der Richtungswechsel

            double error = double.MaxValue - 1;
            double lastError = double.MaxValue;
            while (i > 0)
            {
                lastError = error;
                error = 1 / Math.Sqrt(lambda) - (-2 * Math.Log10((2.51 / (re * Math.Sqrt(lambda))) + (k / (3.71 * di))));

                if (Math.Abs(error) >= Math.Abs(lastError))
                {
                    s /= -10;
                    i--;
                }
                lambda += s;
            }


            // Druckverlust durch Rohrreibung
            // https://www.schweizer-fn.de/stroemung/druckverlust/druckverlust.php#druckverlustrohr
            double deltaP = (lambda * Length * medium.Density * Math.Pow(v, 2)) / (di * 2); // [Pa]

            double deltaP_Bar = deltaP / 1E5;

            return deltaP_Bar;
        }

        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
