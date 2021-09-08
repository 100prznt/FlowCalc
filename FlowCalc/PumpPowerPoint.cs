using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FlowCalc
{
    [Serializable]
    [DebuggerDisplay("P = {PowerInput}; Q = {FlowRate}")]
    public class PumpPowerPoint
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Gemessene Leistungsaufnahme P_1
        /// in [kW]
        /// </summary>
        [Category("Stützpunkt")]
        [DisplayName("Leistungsaufnahme in kW")]
        [XmlElement("H")]
        public double PowerInput { get; set; }

        /// <summary>
        /// Volumenstrom Q
        /// in [m^3/h]
        /// </summary>
        [Category("Stützpunkt")]
        [DisplayName("Fördermenge in m³/h")]
        [XmlElement("Q")]
        public double FlowRate { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PumpPowerPoint()
        {

        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="p1">Leistungsaufnahme P_1 in [kW]</param>
        /// <param name="flow">Volumenstrom Q in [m^3/h]</param>
        public PumpPowerPoint(double p1, double flow)
        {
            PowerInput = p1;
            FlowRate = flow;
        }

        #endregion Constructor

        #region Services
        public override string ToString()
        {
            return "Stützpunkt " + PowerInput + " kW";
        }

        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
