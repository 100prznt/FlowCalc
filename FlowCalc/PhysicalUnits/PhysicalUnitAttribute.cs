using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PhysicalUnits
{
    [AttributeUsage(AttributeTargets.Field)]
    public class PhysicalUnitAttribute : Attribute
    {
        public string Name { get; set; }

        public bool IsBaseUnit { get; set; }

        public double BaseOffset { get; set; }

        public double BaseFactor { get; set; }

        public PhysicalUnitAttribute(string name, bool baseUnit)
        {
            Name = name;

            if (baseUnit)
            {
                IsBaseUnit = true;
                BaseFactor = 0;
                BaseOffset = 0;
            }
            else
            {
                throw new InvalidOperationException("Angabe von Offset und Faktor erwartet.");
            }
        }

        public PhysicalUnitAttribute(string name, double factor, double offset = 0)
        {
            Name = name;
            BaseFactor = factor;
            BaseOffset = offset;
        }
    }
}
