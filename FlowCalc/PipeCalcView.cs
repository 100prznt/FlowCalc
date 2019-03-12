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
    public partial class PipeCalcView : Form
    {
        public Pipe Pipe { get; set; }

        public Units CurrentFlowRateUnit { get; set; }
        public Units CurrentFlowVelocityUnit { get; set; }

        public string WindowTitle
        {
            get
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                return string.Concat(typeof(MainView).Assembly.GetName().Name, " ", versionInfo.ProductVersion);
            }
        }

        public PipeCalcView()
        {
            InitializeComponent();

            this.Text = WindowTitle; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            cmb_FlowRateUnit.ValueMember = nameof(DisplayUnit.DisplayName);
            cmb_FlowVelocityUnit.ValueMember = nameof(DisplayUnit.DisplayName);

            foreach (Units unit in Enum.GetValues(typeof(Units)))
            {
                switch (unit.GetDimension())
                {
                    case Dimensions.FlowRate:
                        cmb_FlowRateUnit.Items.Add(new DisplayUnit(unit));
                        break;
                    case Dimensions.Velocity:
                        cmb_FlowVelocityUnit.Items.Add(new DisplayUnit(unit));
                        break;
                }
            }

            var flowRateBaseUnit = new DisplayUnit(Dimensions.FlowRate.GetBaseUnit());
            var flowVelocityBaseUnit = new DisplayUnit(Dimensions.Velocity.GetBaseUnit());

            cmb_FlowRateUnit.SelectedItem = flowRateBaseUnit;
            cmb_FlowVelocityUnit.SelectedItem = flowVelocityBaseUnit;

            CurrentFlowRateUnit = flowRateBaseUnit.Unit;
            CurrentFlowVelocityUnit = flowVelocityBaseUnit.Unit;

            if (Properties.Settings.Default.CalcPipeDiameter > 0)
                txt_PipeDiameter.Text = Properties.Settings.Default.CalcPipeDiameter.ToString();
            //if (Properties.Settings.Default.CalcPipeLength > 0)
            //    txt_PipeLength.Text = Properties.Settings.Default.CalcPipeLength.ToString();
            //if (Properties.Settings.Default.CalcPipeRoughness > 0)
            //    txt_PipeRoughness.Text = Properties.Settings.Default.CalcPipeRoughness.ToString();
        }

        private void btn_Clac_Click(object sender, EventArgs e)
        {
            txt_FlowVelocity.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F);
            txt_FlowRate.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F);

            try
            {
                //TODO: TryParse in Pipe bereitstellen
                double.TryParse(txt_PipeLength.Text, out var l);    //m
                if (!double.TryParse(txt_PipeDiameter.Text, out var di)) //mm
                    throw new ArgumentException("Inner diameter is mandatory");
                double.TryParse(txt_PipeRoughness.Text, out var k); //mm

                Properties.Settings.Default.CalcPipeDiameter = di;
                Properties.Settings.Default.CalcPipeLength = l;
                Properties.Settings.Default.CalcPipeRoughness = k;
                Properties.Settings.Default.Save();

                Pipe = new Pipe(l, di, k);
            }
            catch (Exception)
            {
                MessageBox.Show("Die eingegebenen Rohrdaten sind fehlerhaft.",
                    "Eingabe Fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txt_FlowRate.Text) ^ string.IsNullOrWhiteSpace(txt_FlowVelocity.Text))
            {

                double flowRate = 0;
                double flowVelocity = 0;

                if (double.TryParse(txt_FlowRate.Text, out flowRate))
                {
                    flowVelocity = Pipe.CalcFlowVelocity(UnitConverter.ToBase(flowRate, ((DisplayUnit)cmb_FlowRateUnit.SelectedItem).Unit));
                    txt_FlowVelocity.Text = UnitConverter.ToUnit(flowVelocity, Dimensions.Velocity.GetBaseUnit(), ((DisplayUnit)cmb_FlowVelocityUnit.SelectedItem).Unit).ToString("f3");
                    txt_FlowVelocity.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F, FontStyle.Bold);
                }
                else if (double.TryParse(txt_FlowVelocity.Text, out flowVelocity))
                {
                    flowRate = Pipe.CalcFlowRate(UnitConverter.ToBase(flowVelocity, ((DisplayUnit)cmb_FlowVelocityUnit.SelectedItem).Unit));
                    txt_FlowRate.Text = UnitConverter.ToUnit(flowRate, Dimensions.FlowRate.GetBaseUnit(), ((DisplayUnit)cmb_FlowRateUnit.SelectedItem).Unit).ToString("f3");
                    txt_FlowRate.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F, FontStyle.Bold);
                }
            }
            else
            {
                MessageBox.Show("Zur Berechnung des Volumenstromes oder der Strömungsgeschwindigkeit muss einer der beiden Werte angegeben werden.\n\n" +
                    "Werden beide oder kein Wert angegeben erfolgt keine Berechnung.", "Hinweis zur Berechnung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void cmb_FlowVelocityUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newUnit = (DisplayUnit)cmb_FlowVelocityUnit.SelectedItem;

            if (double.TryParse(txt_FlowVelocity.Text, out double flowVelocity))
            {
                txt_FlowVelocity.Text = UnitConverter.ToUnit(flowVelocity,
                    CurrentFlowVelocityUnit,
                    newUnit.Unit
                    ).ToString("f3");
            }

            CurrentFlowVelocityUnit = newUnit.Unit;
        }
    }
}
