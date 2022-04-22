using System;
using FlowCalc.PhysicalUnits;
using FlowCalc.PoolSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlowCalc_Test
{
    [TestClass]
    public class PhysicalUnits_Tests
    {
        [TestCategory("FlowRate")]
        [TestMethod]
        public void L_Per_H_ToBase2_Test()
        {
            Assert.AreEqual(6, UnitConverter.ToBase(6000, Units.L_Per_H), 1E-9);
        }

        [TestCategory("FlowRate")]
        [TestMethod]
        public void L_Per_Min_ToBase_Test()
        {
            Assert.AreEqual(10.05, UnitConverter.ToBase(167.5, Units.L_Per_Min), 1E-9);
        }

        [TestCategory("FlowRate")]
        [TestMethod]
        public void Ml_Per_Min_ToBase_Test()
        {
            Assert.AreEqual(10.05, UnitConverter.ToBase(167500, Units.Ml_Per_Min), 1E-9);
        }

        [TestCategory("FlowRate")]
        [TestMethod]
        public void L_Per_H_ToBase_Test()
        {
            Assert.AreEqual(10.05, UnitConverter.ToBase(10050, Units.L_Per_H), 1E-9);
        }

        [TestCategory("FlowRate")]
        [TestMethod]
        public void L_Per_H_To_L_Per_Min()
        {
            Assert.AreEqual(10.05, UnitConverter.ToUnit(603, Units.L_Per_H, Units.L_Per_Min), 1E-9);
        }

        [TestCategory("FlowRate")]
        [TestMethod]
        public void L_Per_Min_To_L_Per_H()
        {
            Assert.AreEqual(10.05, UnitConverter.ToUnit(0.1675, Units.L_Per_Min, Units.L_Per_H), 1E-9);
        }

        [TestCategory("Velocity")]
        [TestMethod]
        public void Cm_Per_S_ToBase_Test()
        {
            Assert.AreEqual(10.05, UnitConverter.ToBase(1005, Units.Cm_Per_S), 1E-9);
        }

        [TestCategory("Pressure")]
        [TestMethod]
        public void MBar_ToBase_Test()
        {
            Assert.AreEqual(10.05, UnitConverter.ToBase(10050, Units.MBar), 1E-9);
        }

        [TestCategory("Pressure")]
        [TestMethod]
        public void Pa_ToBase_Test()
        {
            Assert.AreEqual(10.05, UnitConverter.ToBase(1005000, Units.Pa), 1E-9);
        }

        [TestCategory("Pressure")]
        [TestMethod]
        public void KPa_ToBase_Test()
        {
            Assert.AreEqual(10.05, UnitConverter.ToBase(1005, Units.KPa), 1E-9);
        }

        [TestCategory("Pressure")]
        [TestMethod]
        public void Mws_ToBase_Test()
        {
            Assert.AreEqual(10.05, UnitConverter.ToBase(102.4814794042818, Units.MWs), 1E-9);
        }

    }
}
