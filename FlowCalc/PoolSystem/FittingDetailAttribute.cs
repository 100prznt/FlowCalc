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

        public int NominalDiameter { get; set; }

        public double InnerDiameter { get; set; }

        public double Zeta { get; set; }

        public FittingDetailAttribute(string name, int dn, double zeta, double diameter)
        {
            DisplayName = name;
            NominalDiameter = dn;
            Zeta = zeta;
            InnerDiameter = diameter;
        }
    }
}
