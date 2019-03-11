using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PhysicalUnits
{
    public enum Units
    {
        [PhysicalDimension(Dimensions.FlowRate)]
        [PhysicalUnit("m³/h", true)]
        [Description("Desc")]
        M3_Per_H,
        [PhysicalDimension(Dimensions.FlowRate)]
        [PhysicalUnit("l/h", 0.001)]
        L_Per_H,
        [PhysicalDimension(Dimensions.FlowRate)]
        [PhysicalUnit("l/min", 0.06)]
        L_Per_Min,
        [PhysicalDimension(Dimensions.Velocity)]
        [PhysicalUnit("m/s", true)]
        M_Per_S,
        [PhysicalDimension(Dimensions.Velocity)]
        [PhysicalUnit("cm/s", 0.01)]
        Cm_Per_S
    }
}
