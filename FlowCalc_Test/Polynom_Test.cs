using FlowCalc.Mathematics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FlowCalc_Test
{
    [TestClass]
    public class Polynom_Test
    {
        [TestMethod]
        public void Polyfit1()
        {
            var h = new double[7] { 0.4, 0.8, 1.15, 1.35, 1.45, 1.5, 1.52 };
            var q = new double[7] { 6, 5, 4, 3, 2, 1, 0 };

            var p = Polynom.Polyfit(q, h, 3);

            //Calculated with Matlab
            var expectedResult = new double[4] { 1.515, 0.009761904761905, -0.012857142857143, -0.003333333333333 };

            for (int i = 0; i < expectedResult.Length; i++)
                Assert.AreEqual(expectedResult[i], p.Coefficients[i], 1E-10);

        }

        [TestMethod]
        public void Polyval1()
        {
            var p = new Polynom(1.515, 0.009761904761905, -0.012857142857143, -0.003333333333333);

            var h = p.Polyval(3.5);

            Assert.AreEqual(1.24875, h, 1E-10);
        }
    }
}
