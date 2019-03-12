using FlowCalc.PhysicalUnits;
using FlowCalc.PoolSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public PipeCalcView()
        {
            InitializeComponent();

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
        }

        private void btn_Clac_Click(object sender, EventArgs e)
        {

            txt_FlowVelocity.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F);
            txt_FlowRate.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F);

            try
            {
                //TODO: TryParse in Pipe bereitstellen
                var l = double.Parse(txt_PipeLength.Text);    //m
                var di = double.Parse(txt_PipeDiameter.Text); //mm
                var k = double.Parse(txt_PipeRoughness.Text); //mm

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
