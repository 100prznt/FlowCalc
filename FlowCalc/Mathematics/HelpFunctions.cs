using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.Mathematics
{
    public class HelpFunctions
    {
        /// <summary>
        /// Schneidet alle Werte außerhalb der angegebenen Grenzen ab
        /// </summary>
        /// <param name="inputData">Eingangsdaten</param>
        /// <param name="lowerLimit">Untere Grenze</param>
        /// <param name="upperLimit">Obere Grenze</param>
        /// <returns></returns>
        public static double[] CutOutRange(double[] inputData, double lowerLimit, double upperLimit)
        {
            var outData = new List<double>();

            foreach (var value in inputData)
                if (value >= lowerLimit && value <= upperLimit)
                    outData.Add(value);

            return outData.ToArray();
        }
    }
}
