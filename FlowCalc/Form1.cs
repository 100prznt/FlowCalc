using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowCalc
{
    public partial class Form1 : Form
    {
        Controller m_Controller;

        public string WindowTitle
        {
            get
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                return string.Concat(typeof(Form1).Assembly.GetName().Name, " ",versionInfo.ProductVersion);
            }
        }

        public Form1()
        {
            InitializeComponent();

            this.Text = WindowTitle; //Title

            m_Controller = new Controller();

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.PumpDefinitionPath) &&
                File.Exists(Properties.Settings.Default.PumpDefinitionPath))
            {
                m_Controller.LoadPump(Properties.Settings.Default.PumpDefinitionPath);
                applyPumpDefinition();
            }
        }

        private void btn_LoadPump_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_Controller.LoadPump(openFileDialog1.FileName);
                applyPumpDefinition();

                Properties.Settings.Default.PumpDefinitionPath = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void btn_CalcFlowRate_Click(object sender, EventArgs e)
        {
            txt_SystemHead.ForeColor = Color.Black;

            double pressure = 0;

            if (double.TryParse(txt_SystemPressure.Text, out pressure))
            {
                var flowRate = m_Controller.CalcFlowRate(pressure);
                txt_SystemFlowRate.Text = flowRate.ToString("f2") + " m³/h";
                txt_SystemHead.Text = m_Controller.SystemHead.ToString("f2") + " m";

                if (flowRate <= 0)
                    MessageBox.Show("Der angegebene Systemdruck entspricht einer Förderhöhe, welche außerhalb der Pumpenkennlinie liegt.\n\n" +
                        "Es kann keine Fördermenge berechnet werden.", "Maximale Förderhöhe überschritten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void applyPumpDefinition()
        {
            txt_PumpModel.Text = m_Controller.Pump.ModellName;
            txt_PumpManufracturer.Text = m_Controller.Pump.Manufacturer;
            txt_PumpPowerOut.Text = m_Controller.Pump.PowerOutput + " kW";
            txt_PumpNominalFlowRate.Text = m_Controller.Pump.NominalFlowRate + " m³/h";
            txt_PumpNominalHead.Text = m_Controller.Pump.NominalDynamicHead + " m";
            txt_PumpMaxHead.Text = m_Controller.Pump.MaxTotalHead + " m";

            lbl_PumpFileAuthor.Text = m_Controller.Pump.AuthorPumpFile;
            toolTip1.SetToolTip(lbl_PumpFileAuthor, m_Controller.Pump.AuthorEmailPumpFile);

            this.Text = string.Concat(WindowTitle, " - ", m_Controller.PumpDefinitionPath);

            clearSystemOutput();
        }

        private void clearSystemOutput()
        {
            txt_SystemFlowRate.Clear();
            txt_SystemHead.Clear();
        }

        private void lbl_PumpFileAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl_PumpFileAuthor.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("mailto:" + m_Controller.Pump.AuthorEmailPumpFile);
        }
    }
}
