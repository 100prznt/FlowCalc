using FlowCalc.PhysicalUnits;
using FlowCalc.PoolSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowCalc
{
    public partial class CirculationCalcView : Form
    {
        public Pipe Pipe { get; set; }

        public Units CurrentFlowRateUnit { get; set; }
        public Units CurrentVolumeUnit { get; set; }
        public Units CurrentTimeUnit { get; set; }

        /// <summary>
        /// Flowrate in [m³/h]
        /// </summary>
        public double FlowRate { get; set; } = double.NaN;

        public string WindowTitle
        {
            get
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                return string.Concat(typeof(MainView).Assembly.GetName().Name, " ", versionInfo.ProductVersion);
            }
        }

        public CirculationCalcView()
        {
            InitializeComponent();

            this.Text = WindowTitle; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            cmb_FlowRateUnit.ValueMember = nameof(DisplayUnit.DisplayName);
            cmb_VolumeUnit.ValueMember = nameof(DisplayUnit.DisplayName);
            cmb_RunTimeUnit.ValueMember = nameof(DisplayUnit.DisplayName);

            foreach (Units unit in Enum.GetValues(typeof(Units)))
            {
                switch (unit.GetDimension())
                {
                    case Dimensions.FlowRate:
                        cmb_FlowRateUnit.Items.Add(new DisplayUnit(unit));
                        break;
                    case Dimensions.Volume:
                        cmb_VolumeUnit.Items.Add(new DisplayUnit(unit));
                        break;
                    case Dimensions.Time:
                        cmb_RunTimeUnit.Items.Add(new DisplayUnit(unit));
                        break;
                }
            }

            var flowRateBaseUnit = new DisplayUnit(Dimensions.FlowRate.GetBaseUnit());
            var volumeBaseUnit = new DisplayUnit(Dimensions.Volume.GetBaseUnit());
            var timeBaseUnit = new DisplayUnit(Dimensions.Time.GetBaseUnit());

            cmb_FlowRateUnit.SelectedItem = flowRateBaseUnit;
            cmb_VolumeUnit.SelectedItem = volumeBaseUnit;
            cmb_RunTimeUnit.SelectedItem = new DisplayUnit(Units.H);

            CurrentFlowRateUnit = flowRateBaseUnit.Unit;
            CurrentVolumeUnit = volumeBaseUnit.Unit;
            CurrentTimeUnit = Units.H;

            if (Properties.Settings.Default.CalcVolume > 0)
                txt_Volume.Text = Properties.Settings.Default.CalcVolume.ToString("f2");

        }

        public new void Show()
        {
            if (!double.IsNaN(FlowRate) && FlowRate > 0)
                txt_FlowRate.Text = FlowRate.ToString("f2");

            base.Show();
        }

        private void btn_Clac_Click(object sender, EventArgs e)
        {
            double vUser;
            double qUser;

            try
            {
                vUser = double.Parse(txt_Volume.Text); //cust. unit
                qUser = double.Parse(txt_FlowRate.Text); //cust. unit
            }
            catch (Exception)
            {
                MessageBox.Show("Die eingegebenen Daten sind fehlerhaft.",
                    "Eingabe Fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            var v = UnitConverter.ToUnit(vUser, CurrentVolumeUnit, Units.M3);
            var q = UnitConverter.ToUnit(qUser, CurrentFlowRateUnit, Units.M3_Per_H);

            var t = (v / q) * (int)nud_Count.Value;

            txt_RunTime.Text = UnitConverter.ToUnit(t, Units.H, CurrentTimeUnit).ToString("f1");

            if (nud_Count.Value == 1)
                lbl_ResultInfo.Text = "Pumpenlaufzeit um den angegebenen Wasserinhalt einmal umzuwälzen.";
            else
                lbl_ResultInfo.Text = "Pumpenlaufzeit um den angegebenen Wasserinhalt " + nud_Count.Value + "-mal umzuwälzen.";
        }

        private void cmb_FlowRateUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newUnit = (DisplayUnit)cmb_FlowRateUnit.SelectedItem;

            if (double.TryParse(txt_FlowRate.Text, out double flowRate))
            {
                txt_FlowRate.Text = UnitConverter.ToUnit(flowRate,
                    CurrentFlowRateUnit,
                    newUnit.Unit
                    ).ToString("f3");
            }

            CurrentFlowRateUnit = newUnit.Unit;
        }

        private void cmb_VolumeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newUnit = (DisplayUnit)cmb_VolumeUnit.SelectedItem;

            if (double.TryParse(txt_Volume.Text, out double volume))
            {
                txt_Volume.Text = UnitConverter.ToUnit(volume,
                    CurrentVolumeUnit,
                    newUnit.Unit
                    ).ToString("f3");
            }

            CurrentVolumeUnit = newUnit.Unit;
        }

        private void cmb_RunTimeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newUnit = (DisplayUnit)cmb_RunTimeUnit.SelectedItem;

            if (double.TryParse(txt_RunTime.Text, out double time))
            {
                txt_RunTime.Text = UnitConverter.ToUnit(time,
                    CurrentTimeUnit,
                    newUnit.Unit
                    ).ToString("f1");
            }

            CurrentTimeUnit = newUnit.Unit;
        }
    }
}
