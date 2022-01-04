using FlowCalc.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FlowCalc
{
    [Serializable]
    [DebuggerDisplay("n = {Rpm} rpm; H_max = {MaxTotalHead}")]
    public class PumpDynamicPerformanceCurve
    {
        /// <summary>
        /// Drehzahl
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Motor Drehzahl")]
        public int Rpm { get; set; }

        /// <summary>
        /// Leistungsaufname Motor P_1
        /// in [kW]
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Leistungsaufnahme in kW (P1)")]
        [Description("Leistungaufnahme")]
        public double PowerInput { get; set; }

        /// <summary>
        /// Leistungsaufnahme in Abhängigkeit des Arbeitspunktes (Volumenstrom)
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Lastabhängige Leistungsaufnahme")]
        [Description("Leistungsaufnahme in Abhängigkeit des Arbeitspunktes definiert durch den Volumenstrom")]
        [XmlArrayItem("Ipp")] //interpolationpoint
        public PumpPowerPoint[] PowerInputCurve { get; set; }

        /// <summary>
        /// Leistungskurve
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Pumpenkennlinie")]
        [Description("Stützpunkte der Pumpenkennlinie.")]
        [Editor(typeof(IppCollectionEditor), typeof(UITypeEditor))]
        [XmlArrayItem("Ipp")]
        public PumpPerformancePoint[] PerformanceCurve { get; set; }

        /// <summary>
        /// Maximale Meter Wassersäule (Förderhöhe)
        /// in [m WS]
        /// </summary>
        [Category("Leistungsdaten")]
        [DisplayName("Maximale Förderhöhe in m WS")]
        [Description("Maximale Förderhöhe, Angabe wird anhand der Pumpenkennlinie automatisch generiert.")]
        [XmlIgnore]
        public double MaxTotalHead
        {
            get
            {
                if (PerformanceCurve == null || PerformanceCurve.Length <= 0)
                    return 0;
                else
                    return PerformanceCurve.Max(x => x.TotalDynamicHead);
            }
        }

        public Polynom GetPerformancePolynom()
        {
            return Polynom.Polyfit(GetPerformanceFlowValues(), GetPerformanceHeadValues(), 3);
        }

        public double[] GetPerformanceHeadValues()
        {
            return PerformanceCurve.Select(x => x.TotalDynamicHead).ToArray();
        }

        public double[] GetPerformanceFlowValues()
        {
            return PerformanceCurve.Select(x => x.FlowRate).ToArray();
        }
    }
}
