using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PhysicalUnits
{
    public class UnitConverter
    {
        public static double ToBase(double value, Units unit)
        {
            return value * unit.GetBaseFactor() + unit.GetBaseOffset();
        }

        public static double ToUnit(double value, Units inUnit, Units outUnit)
        {
            var siValue = ToBase(value, inUnit);
            return (siValue - outUnit.GetBaseOffset()) / outUnit.GetBaseFactor();
        }
    }
}
