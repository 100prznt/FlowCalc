using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc
{
    public enum MotorControllerTypes
    {
        /// <summary>
        /// Motor mit konstanter Drehzahl
        /// </summary>
        FixedRpm = 0,
        /// <summary>
        /// Motor mit einstellbarer Drehzahl
        /// </summary>
        RpmControlled,
        /// <summary>
        /// Motor mit einstellbarer Leistung (P1)
        /// </summary>
        PowerControlled
    }
}
