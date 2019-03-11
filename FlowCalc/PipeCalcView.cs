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


            cmb_FlowRateUnit.SelectedIndex = 2;
            cmb_FlowVelocityUnit.SelectedText = (new DisplayUnit(Dimensions.Velocity.GetBaseUnit())).DisplayName;
        }

        private void btn_Clac_Click(object sender, EventArgs e)
        {
            try
            {
                var l = double.Parse(txt_PipeLength.Text);    //m
                var di = double.Parse(txt_PipeDiameter.Text); //mm
                var k = double.Parse(txt_PipeRoughness.Text); //mm

                Pipe = new Pipe(l, di, k);
            }
            catch (Exception)
            {
                MessageBox.Show("Die eingegebenen Rohrdaten sind fehlerhaft.",
                    "Eingabe Fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
