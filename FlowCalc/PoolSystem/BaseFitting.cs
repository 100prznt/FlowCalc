using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    /// <summary>
    /// Rohrbogen
    /// </summary>
    public abstract class BaseFitting
    {
        /// <summary>
        /// Name der Armatur bzw. des Formstückes
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Innendurchmesser
        /// in [mm]
        /// </summary>
        public double Diameter { get; set; }

        /// <summary>
        /// Rohrrauheit
        /// in [mm]
        /// </summary>
        public double Roughness { get; set; }

        /// <summary>
        /// Druckverlustbeiwert
        /// </summary>
        public abstract double Zeta { get; }
    }
}
