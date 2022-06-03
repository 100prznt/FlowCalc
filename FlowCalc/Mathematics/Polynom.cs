using MathNet.Numerics;
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
        /// Koeffizienten
        /// Beginnen Sie mit dem Offsetwert des Polynoms
        /// </summary>
        public double[] Coefficients { get; set; }

        public int Degree
        {
            get
            {
                return Coefficients.Length - 1;
            }
        }

        public Polynom(params double[] coefficients)
        {
            Coefficients = coefficients;
        }

        /// <summary>
        /// Berechnung y-Wert
        /// </summary>
        /// <param name="x">x-Wert</param>
        /// <returns>Berechneter y-Wert</returns>
        public double Polyval(double x)
        {
            double result = 0;

            for (int i = 0; i < Coefficients.Length; i++)
                result += Coefficients[i] * Math.Pow(x, i);
            return result;
        }

        public double[] GetRealRoots()
        {
            var roots = FindRoots.Polynomial(Coefficients);
            var realRoots = new List<double>();

            foreach (var r in roots)
            {
                if (r.IsReal())
                    realRoots.Add(r.Real);
            }
            return realRoots.ToArray(); ;
        }

        public double[] GetCrossPoints(Polynom crossingPolynom)
        {
            return (this - crossingPolynom).GetRealRoots();
        }

        public override string ToString()
        {
            var format = "+0.000;-0.000";
            var sb = new StringBuilder();


            for (int i = Coefficients.Length - 1; i > 1; i--)
            {
                if (i > 0)
                    sb.Append(Coefficients[i].ToString(format) + "x^" + (i - 1));
            }


            sb.Append($"{Coefficients[1].ToString(format)}x{Coefficients[0].ToString(format)}");

            return sb.ToString();
        }

        /// <summary>
        /// Polynom Fitting
        /// </summary>
        /// <param name="x">x-Werte</param>
        /// <param name="y">y-Werte</param>
        /// <param name="degree">Grad des Fits</param>
        /// <returns>Polynom mit Koeffizienten für ein Polynom p(x) vom Grad n, das sich am besten an die Daten in y anpasst.
        /// Die Koeffizienten in p sind in aufsteigenden Potenzen (Offset zuerst), und die Länge von p ist n+1</returns>
        public static Polynom Polyfit(double[] x, double[] y, int degree)
        {
            if (x.Length != y.Length)
                throw new ArgumentOutOfRangeException("Polyfit nicht möglich, da der X- und Y-Vektor verschiedene Längen haben!");

            if (degree > x.Length)
                throw new ArgumentOutOfRangeException("Polyfit nicht möglich, da der angegeben Fit-Grad mit der Länge der Eingangsdaten nicht erreicht werden kann!");


            var design = Matrix<double>.Build.Dense(x.Length, degree + 1, (i, j) => Math.Pow(x[i], j));
            return new Polynom()
            {
                Coefficients = MultipleRegression.QR(design, Vector<double>.Build.Dense(y)).ToArray()
            };
        }

        public static Polynom operator -(Polynom a, Polynom b)
        {
            var deg = new int[] { a.Degree, b.Degree }.Max();

            var aCoefficients = a.Coefficients;
            var bCoefficients = b.Coefficients;

            Array.Resize(ref aCoefficients, deg + 1);
            Array.Resize(ref bCoefficients, deg + 1);


            var result = new double[deg + 1];

            for (int i = 0; i < deg + 1; i++)
                result[i] = aCoefficients[i] - bCoefficients[i];

            return new Polynom(result);
        }
    }
}
