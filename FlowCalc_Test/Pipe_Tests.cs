using System;
using FlowCalc.PoolSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlowCalc_Test
{
    [TestClass]
    public class Pipe_Tests
    {
        [TestMethod]
        public void CalcFlowVelocity_Test()
        {
            var testPipe = new Pipe(1, 45.2, 0.1);

            // Vergleichsergebnis aus Druckverlust 7.0 (http://druckverlust.de)
            Assert.AreEqual(1.731, testPipe.CalcFlowVelocity(10),1E-3);
        }

        [TestMethod]
        public void CalcFlowRate_Test()
        {
            var testPipe = new Pipe(1, 45.2, 0.1);

            // Vergleichsergebnis aus Druckverlust 7.0 (http://druckverlust.de)
            Assert.AreEqual(10, testPipe.CalcFlowRate(1.731), 1E-3);
        }

        [TestMethod]
        public void CalcPressureDrop_Test()
        {
            var testPipe = new Pipe(1, 45.2, 0.1);
            
            // Vergleichsergebnis aus Druckverlust 7.0 (http://druckverlust.de)
            Assert.AreEqual(0.002, testPipe.CalcPressureDrop(Medium.Water20, 5), 1E-3);
        }
    }
}
