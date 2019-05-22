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
        [PhysicalDimension(Dimensions.FlowRate)]
        [PhysicalUnit("ml/min", 0.00006)]
        Ml_Per_Min,
        [PhysicalDimension(Dimensions.Velocity)]
        [PhysicalUnit("m/s", true)]
        M_Per_S,
        [PhysicalDimension(Dimensions.Velocity)]
        [PhysicalUnit("cm/s", 0.01)]
        Cm_Per_S,
        [PhysicalDimension(Dimensions.Pressure)]
        [PhysicalUnit("Bar", true)]
        Bar,
        [PhysicalDimension(Dimensions.Pressure)]
        [PhysicalUnit("mBar", 0.001)]
        MBar,
        [PhysicalDimension(Dimensions.Pressure)]
        [PhysicalUnit("Pa", 0.00001)]
        Pa,
        [PhysicalDimension(Dimensions.Pressure)]
        [PhysicalUnit("kPa", 0.01)]
        KPa,
        [PhysicalDimension(Dimensions.Pressure)]
        [PhysicalUnit("m WS", 0.0980665)]
        MWs,
        [PhysicalDimension(Dimensions.Volume)]
        [PhysicalUnit("m³", true)]
        M3,
        [PhysicalDimension(Dimensions.Volume)]
        [PhysicalUnit("l", 0.001)]
        L,
        [PhysicalDimension(Dimensions.Length)]
        [PhysicalUnit("m", true)]
        M,
        [PhysicalDimension(Dimensions.Ratio)]
        [PhysicalUnit("%", true)]
        Percent,

    }
}
