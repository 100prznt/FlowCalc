using FlowCalc.PoolSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    public class Filter : PipeBase
    {
        #region Properties

        #endregion Properties

        #region Services

        /// <summary>
        /// Druckverlust berechnen
        /// </summary>
        /// <param name="medium">Stoffdaten</param>
        /// <param name="flowRate">Volumenstrom in [m^3/h]</param>
        /// <returns>Druckverlust in [bar]</returns>
        public double CalcPressureDrop(Medium medium, double flowRate)
        {
            var pd = double.NaN; //Druckverlust
            var zeta = double.NaN; //Widerstandsbeiwert
            var rho = medium.Density; //Dichte
            var w = double.NaN; //mittlere effektive Fluidgeschwindigkeit
            var h = double.NaN; //Höhe der Schicht
            var dh = double.NaN; //hydraulischer Durchmesser



            pd = zeta * (rho / 2) * Math.Pow(w, 2) * (h / dh);

            return pd;
        }

        #endregion Services
    }
}
