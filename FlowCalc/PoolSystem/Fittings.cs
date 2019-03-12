using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    public enum Fittings
    {
        [FittingDetail("Winkel 45°", NominalDiameters.DN40, 0.5)]
        Dn40Angle45,
        [FittingDetail("Bogen 90°", NominalDiameters.DN40, 0.9)]
        Dn40Elbow90,
        [FittingDetail("Winkel 90°", NominalDiameters.DN40, 2.3)]
        Dn40Angle90,
        [FittingDetail("T-Sück gerader Durchgang", NominalDiameters.DN40, 0.28)]
        Dn40TPipeStraight,
        [FittingDetail("T-Sück Abzweig", NominalDiameters.DN40, 3.2)]
        Dn40TPipeRight,
        [FittingDetail("Winkel 45°", NominalDiameters.DN50, 0.4)]
        Dn50Angle45,
        [FittingDetail("Bogen 90°", NominalDiameters.DN50, 0.75)]
        Dn50Elbow90,
        //[FittingDetail("Winkel 90°", NominalDiameters.DN50, ??)]
        //Dn50Angle90,
        [FittingDetail("T-Sück gerader Durchgang", NominalDiameters.DN50, 0.24)]
        Dn50TPipeStraight,
        [FittingDetail("T-Sück Abzweig", NominalDiameters.DN50, 2.6)]
        Dn50TPipeRight,
    }
}
