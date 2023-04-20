using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc
{
    /// <summary>
    /// Definition of standard pool pipes and hoses
    /// </summary>
    public enum PipeCategories
    {
        [Description("PVC Rohr")]
        PvcTube,
        [Description("PVC Flexschlauch")]
        PvcFlex,
        [Description("Poolschlauch")]
        PoolHose,
        [Description("Saugdruckschlauch")]
        SuckPressureHose
    }
}
