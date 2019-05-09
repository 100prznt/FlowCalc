using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.Mathematics
{
    public static class CheckRoutines
    {
        /// <summary>
        /// Ermittelt die Richtung der Werte
        /// und prüft ob es keine Ausreiser gibt
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Direction GetDirection(double[] values)
        {
            bool descending = false;
            bool ascending = false;

            for (int i = 0; i < values.Length - 1; i++)
            {
                descending = values[i] > values[i + 1] ? true : descending;
                ascending = values[i] < values[i + 1] ? true : ascending;
            }

            if (descending == ascending)
                return Direction.NotUnique;
            else if (descending)
                return Direction.Descending;
            else
                return Direction.Ascending;
        }

        /// <summary>
        /// Prüft ob ein Wert innerhalb der vorgegebenen Grenzen liegt
        /// </summary>
        /// <param name="value">Zu prüfender Wert</param>
        /// <param name="limits">Vorgegebene Grenzen</param>
        public static CheckLimitResult CheckLimits(this double value, DoubleLimits limits)
        {
            var result = CheckLimitResult.ValuePassLimits;

            if (value < limits.LowerLimit)
                result = CheckLimitResult.ValueCrossLowerLimit;
            else if (value > limits.UpperLimit)
                result = CheckLimitResult.ValueCrossUpperLimit;

            return result;
        }
    }

    public struct DoubleLimits
    {
        public double UpperLimit;
        public double LowerLimit;
    }

    public enum CheckLimitResult
    {
        ValueCrossUpperLimit = -2,
        ValueCrossLowerLimit = -1,
        ValuePassLimits = 0
    }

    public enum Direction
    {
        /// <summary>
        /// Nicht eindeutig
        /// </summary>
        NotUnique,
        /// <summary>
        /// Absteigend
        /// </summary>
        Descending,
        /// <summary>
        /// Aufsteigend
        /// </summary>
        Ascending
    }
}
