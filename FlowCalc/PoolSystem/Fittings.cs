using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    public enum Fittings
    {
        [FittingDetail("Bogen 90°", 40, 0.191, 42.6)]
        Dn40Elbow90,
        [FittingDetail("Winkel 90°", 40, 0.565, 50)]
        Dn40Angle90,
        [FittingDetail("Winkel 45°", 40, 0.565, 50)]
        Dn40Angle45,
        Dn40TPipe90,
        Dn40TPipe45,
        Dn40YPipe
    }
}
