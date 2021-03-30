using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearRegression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.Mathematics
{
    public class Polynom
    {
        /// <summary>
        /// Coefficients
        /// Start with the offsetvalue of the polynom
        /// </summary>
        public double[] Coefficients { get; set; }


        public Polynom(params double[] coefficients)
        {
            Coefficients = coefficients;
        }

        /// <summary>
        /// Polynomial evaluation
        /// </summary>
        /// <param name="x">x value</param>
        /// <returns>Calculated y value</returns>
        public double Polyval(double x)
        {
            double result = 0;

            for (int i = 0; i < Coefficients.Length; i++)
                result += Coefficients[i] * Math.Pow(x, i);
            return result;
        }

        /// <summary>
        /// Polynomial curve fitting
        /// </summary>
        /// <param name="x">x values</param>
        /// <param name="y">y values</param>
        /// <param name="degree">fit degree</param>
        /// <returns>Polynom with coefficients for a polynomial p(x) of degree n that is a best fit for the data in y.
        /// The coefficients in p are in acscending powers (offset first), and the length of p is n+1</returns>
        public static Polynom Polyfit(double[] x, double[] y, int degree)
        {
            if (x.Length != y.Length)
                throw new ArgumentOutOfRangeException("Polyfit nicht möglich, da der X- und Y-Vektor verschiedene Längen haben!");

            if (degree >= x.Length)
                throw new ArgumentOutOfRangeException("Polyfit nicht möglich, da der angegeben Fit-Grad mit der Länge der Eingangsdaten nicht erreicht werden kann!");


            var design = Matrix<double>.Build.Dense(x.Length, degree + 1, (i, j) => Math.Pow(x[i], j));
            return new Polynom()
            {
                Coefficients = MultipleRegression.QR(design, Vector<double>.Build.Dense(y)).ToArray()
            };
        }
    }
}
