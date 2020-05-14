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
    public partial class PipeSelectView : Form
    {
        public Pipe Pipe { get; set; }

        public Units CurrentFlowRateUnit { get; set; }
        public Units CurrentFlowVelocityUnit { get; set; }
        public Units CurrentPressureUnit { get; set; }

        PipeType m_PipeType = PipeType.Undefined;

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

        public PipeSelectView()
        {
            InitializeComponent();

            this.Text = WindowTitle + " - Rohrauswahl"; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            
        }

        private void PipeType_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_PoolPipe.Checked)
            {
                cbx_NominalDiameter.Items.Clear();
                cbx_NominalDiameter.Items.Add("32 mm");
                cbx_NominalDiameter.Items.Add("38 mm");

                cbx_NominalPressure.Items.Clear();
                cbx_NominalPressure.Enabled = false;
            }
            else if (rb_PvcPipe.Checked)
            {
                cbx_NominalDiameter.Items.Clear();
                cbx_NominalDiameter.Items.Add("50 mm");
                cbx_NominalDiameter.Items.Add("63 mm");

                cbx_NominalPressure.Items.Clear();
                cbx_NominalPressure.Enabled = true;
                cbx_NominalPressure.Items.Add("PN6");
                cbx_NominalPressure.Items.Add("PN10");
                cbx_NominalPressure.Items.Add("PN16");
            }
            else if (rb_PvcFlex.Checked)
            {
                cbx_NominalDiameter.Items.Clear();
                cbx_NominalDiameter.Items.Add("50 mm");
                cbx_NominalDiameter.Items.Add("63 mm");

                cbx_NominalPressure.Items.Clear();
                cbx_NominalPressure.Enabled = true;
                cbx_NominalPressure.Items.Add("PN6");
            }
        }

        //Controller.CurrentPresets.Roughness

        enum PipeType
        {
            Undefined,
            PvcPipe,
            PvcFlex,
            PoolPipe
        }
    }
}
