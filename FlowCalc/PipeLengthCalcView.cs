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
    public partial class PipeLengthCalcView : Form
    {
        public string WindowTitle
        {
            get
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                return string.Concat(typeof(MainView).Assembly.GetName().Name, " ", versionInfo.ProductVersion);
            }
        }

        public PipeLengthCalcView()
        {
#if (!DEBUG)
            throw new NotImplementedException("Hier wird im Moment gearbeitet, bitte letztes Stable Release verwenden.");
#endif
            InitializeComponent();

            this.Text = WindowTitle; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;
        }

        private void generateFittingButtons()
        {
            Controls["box_FittingButtons"].Controls.Clear();

            var yOffset = 30;
            int i = 1;
            NominalDiameters dn = NominalDiameters.NotSpecified;
            if (rbtn_Dn40.Checked)
                dn = NominalDiameters.DN40;
            else if (rbtn_Dn50.Checked)
                dn = NominalDiameters.DN50;

            foreach (Fittings unit in Enum.GetValues(typeof(Fittings)))
            {
                if (unit.GetNominalDiameter() == dn)
                {
                    var btn = new Button()
                    {
                        Name = "btn_" + unit.ToString(),
                        Tag = unit,
                        Text = unit.GetDisplayName(),
                        Size = new Size(150, 23),
                        Location = new Point(20, 5 + yOffset * i)
                    };
                    btn.Click += btn_Fitting_Click;

                    Controls["box_FittingButtons"].Controls.Add(btn);

                    i++;
                }
            }
        }

        private void btn_Fitting_Click(object sender, EventArgs e)
        {
            var fitting = (Fittings)((Button)sender).Tag;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateFittingButtons();
        }

        private void rbtn_Dn_CheckedChanged(object sender, EventArgs e)
        {
            generateFittingButtons();
        }
    }
}
