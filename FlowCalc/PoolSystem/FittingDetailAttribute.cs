using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    [AttributeUsage(AttributeTargets.Field)]
    public class FittingDetailAttribute : Attribute
    {
        public string DisplayName { get; set; }

        /// <summary>
        /// Nennweite
        /// </summary>
        public NominalDiameters NominalDiameter { get; set; }

        /// <summary>
        /// Zeta-Wert (Druckverlustbeiwert)
        /// </summary>
        public double Zeta { get; set; }

        /// <summary>
        /// Äquivalente Länge
        /// in [m]
        /// </summary>
        public double EquivalentLength { get; set; }

        public FittingDetailAttribute(string name, NominalDiameters dn, double equivalentLength)
        {
            DisplayName = name;
            NominalDiameter = dn;
            EquivalentLength = equivalentLength;
        }
    }
}
