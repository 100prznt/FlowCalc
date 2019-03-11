using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PhysicalUnits
{
    public static class DimensionExtensions
    {
        public static Units GetBaseUnit(this Dimensions dim)
        {
            foreach (Units unit in Enum.GetValues(typeof(Units)))
            {
                if (unit.GetDimension() == dim && unit.IsBase())
                    return unit;
            }

            throw new InvalidOperationException("Keine Basiseinheit zur Größe (" + dim + ") verfügbar.");

        }
    }
}
