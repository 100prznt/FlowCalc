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
    [DebuggerDisplay("H = {TotalDynamicHead}; Q = {FlowRate}")]
    public class PumpPerformancePoint
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Meter Wassersäule (Förderhöhe) H
        /// in m WS
        /// </summary>
        [Category("Stützpunkt")]
        [DisplayName("Förderhöhe in m WS")]
        [XmlElement("H")]
        public double TotalDynamicHead { get; set; }

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
        public PumpPerformancePoint()
        {

        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="flow">Volumenstrom Q in [m^3/h]</param>
        /// <param name="head">Gesamtförderhöhe H in mWS</param>
        public PumpPerformancePoint(double head, double flow)
        {
            TotalDynamicHead = head;
            FlowRate = flow;
        }

        #endregion Constructor

        #region Services
        public override string ToString()
        {
            return "Stützpunkt " + TotalDynamicHead + " m WS";
        }

        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
