using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.Mathematics
{
    public class LinInterp
    {
        public static double LinearInterpolation(double[] pX, double[] pY, double pXI)
        {
            double iMax = pX[pX.Length - 1];
            double iMin = pX[0];
            double dY1, dY2, dX1, dX2, dFak;
            int iPos, l, r;

            if (pXI <= iMin)    //extrapolieren nach unten
            {
                dY1 = pY[0]; dY2 = pY[1]; dX1 = pX[0]; dX2 = pX[1];
            }
            else if (pXI >= iMax)   //extrapolieren nach oben
            {
                dY1 = pY[pY.Length - 2];
                dY2 = pY[pY.Length - 1];
                dX1 = pX[pY.Length - 2];
                dX2 = pX[pY.Length - 1];
            }
            else     //interpolieren
            {
                l = 0;
                r = pX.Length - 1;

                while (l <= r)
                {
                    iPos = (l + r) / 2;
                    if (pXI == pX[iPos])
                        break;
                    else if (pXI < pX[iPos])
                        r = iPos - 1;
                    else
                        l = iPos + 1;
                }

                iPos = (l + r) >> 1;
                dY1 = pY[iPos];
                dY2 = pY[iPos + 1];
                dX1 = pX[iPos];
                dX2 = pX[iPos + 1];
            }

            dFak = (dY2 - dY1) / (dX2 - dX1);
            return dY1 + ((pXI - dX1) * dFak);
        }
    }
}
