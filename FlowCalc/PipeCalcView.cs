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
        bool m_CalculationActive = false;

        public Pipe Pipe { get; set; }

        public Units CurrentFlowRateUnit { get; set; }
        public Units CurrentFlowVelocityUnit { get; set; }
        public Units CurrentPressureUnit { get; set; }

        public string WindowTitle
        {
            get
            {
#if DEBUG
                return typeof(MainView).Assembly.GetName().Name;
#else
                var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                return string.Concat(typeof(MainView).Assembly.GetName().Name, " ", versionInfo.ProductVersion);
#endif
            }
        }

        public PipeCalcView()
        {
            InitializeComponent();

            this.Text = WindowTitle + " - Druckabfall"; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            cmb_FlowRateUnit.ValueMember = nameof(DisplayUnit.DisplayName);
            cmb_FlowVelocityUnit.ValueMember = nameof(DisplayUnit.DisplayName);
            cmb_DeltaPUnit.ValueMember = nameof(DisplayUnit.DisplayName);

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
                    case Dimensions.Pressure:
                        cmb_DeltaPUnit.Items.Add(new DisplayUnit(unit));
                        break;
                }
            }

            var flowRateBaseUnit = new DisplayUnit(Dimensions.FlowRate.GetBaseUnit());
            var velocityBaseUnit = new DisplayUnit(Dimensions.Velocity.GetBaseUnit());
            var pressureBaseUnit = new DisplayUnit(Dimensions.Pressure.GetBaseUnit());

            cmb_FlowRateUnit.SelectedItem = flowRateBaseUnit;
            cmb_FlowVelocityUnit.SelectedItem = velocityBaseUnit;
            cmb_DeltaPUnit.SelectedItem = pressureBaseUnit;

            CurrentFlowRateUnit = flowRateBaseUnit.Unit;
            CurrentFlowVelocityUnit = velocityBaseUnit.Unit;
            CurrentPressureUnit = pressureBaseUnit.Unit;

            if (Properties.Settings.Default.CalcPipeDiameter > 0)
                txt_PipeDiameter.Text = Properties.Settings.Default.CalcPipeDiameter.ToString();
            if (Properties.Settings.Default.CalcPipeLength > 0)
                txt_PipeLength.Text = Properties.Settings.Default.CalcPipeLength.ToString();

                txt_PipeRoughness.Text = Controller.CurrentPresets.Roughness.ToString("F4");
        }

        private void btn_Clac_Click(object sender, EventArgs e)
        {
            m_CalculationActive = true;
            txt_FlowVelocity.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F);
            txt_FlowRate.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F);
            txt_DeltaP.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F);

            try
            {
                //TODO: TryParse in Pipe bereitstellen
                var l = double.Parse(txt_PipeLength.Text);    //m
                var di = double.Parse(txt_PipeDiameter.Text); //mm
                var k = double.Parse(txt_PipeRoughness.Text); //mm

                Properties.Settings.Default.CalcPipeDiameter = di;
                Properties.Settings.Default.CalcPipeLength = l;
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

                double deltaP = Pipe.CalcPressureDrop(Controller.CurrentPresets.Medium, UnitConverter.ToBase(flowRate, ((DisplayUnit)cmb_FlowRateUnit.SelectedItem).Unit));
                txt_DeltaP.Text = UnitConverter.ToUnit(deltaP, Dimensions.Pressure.GetBaseUnit(), ((DisplayUnit)cmb_DeltaPUnit.SelectedItem).Unit).ToString("f3");
                txt_DeltaP.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F, FontStyle.Bold);
            }
            else
            {
                MessageBox.Show("Zur Berechnung des Volumenstromes oder der Strömungsgeschwindigkeit muss einer der beiden Werte angegeben werden.\n\n" +
                    "Werden beide oder kein Wert angegeben erfolgt keine Berechnung.", "Hinweis zur Berechnung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            m_CalculationActive = false;
        }

        private void cmb_FlowRateUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_CalculationActive = true;
            var newUnit = (DisplayUnit)cmb_FlowRateUnit.SelectedItem;

            if (double.TryParse(txt_FlowRate.Text, out double flowRate))
            {
                txt_FlowRate.Text = UnitConverter.ToUnit(flowRate,
                    CurrentFlowRateUnit,
                    newUnit.Unit
                    ).ToString("f3");
            }

            CurrentFlowRateUnit = newUnit.Unit;
            m_CalculationActive = false;
        }

        private void cmb_FlowVelocityUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_CalculationActive = true;
            var newUnit = (DisplayUnit)cmb_FlowVelocityUnit.SelectedItem;

            if (double.TryParse(txt_FlowVelocity.Text, out double flowVelocity))
            {
                txt_FlowVelocity.Text = UnitConverter.ToUnit(flowVelocity,
                    CurrentFlowVelocityUnit,
                    newUnit.Unit
                    ).ToString("f3");
            }

            CurrentFlowVelocityUnit = newUnit.Unit;
            m_CalculationActive = false;
        }

        private void cmb_DeltaPUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newUnit = (DisplayUnit)cmb_DeltaPUnit.SelectedItem;

            if (double.TryParse(txt_DeltaP.Text, out double deltaP))
            {
                txt_DeltaP.Text = UnitConverter.ToUnit(deltaP,
                    CurrentPressureUnit,
                    newUnit.Unit
                    ).ToString("f3");
            }

            CurrentPressureUnit = newUnit.Unit;
        }

        private void txt_FlowVelocity_TextChanged(object sender, EventArgs e)
        {
            //if (!m_CalculationActive && !string.IsNullOrWhiteSpace(txt_FlowRate.Text))
            if (sender == ActiveControl && !string.IsNullOrWhiteSpace(txt_FlowRate.Text))
            {
                txt_FlowRate.Clear();
                txt_DeltaP.Clear();
            }
        }

        private void txt_FlowRate_TextChanged(object sender, EventArgs e)
        {
            //if (!m_CalculationActive && !string.IsNullOrWhiteSpace(txt_FlowVelocity.Text))
            if (sender == ActiveControl && !string.IsNullOrWhiteSpace(txt_FlowVelocity.Text))
            {
                txt_FlowVelocity.Clear();
                txt_DeltaP.Clear();
            }
        }
    }
}
