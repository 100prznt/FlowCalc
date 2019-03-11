using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PhysicalUnits
{
    [AttributeUsage(AttributeTargets.Field)]
    public class PhysicalDimensionAttribute : Attribute
    {
        public Dimensions Dimension { get; set; }

        public PhysicalDimensionAttribute(Dimensions dimension)
        {
            Dimension = dimension;
        }
    }
}
