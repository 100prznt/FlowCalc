using FlowCalc.PoolSystem;
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
    public partial class MainView : Form
    {
        Controller m_Controller;
        ChartView m_ChartView;

        public string WindowTitle
        {
            get
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                return string.Concat(typeof(MainView).Assembly.GetName().Name, " ",versionInfo.ProductVersion);
            }
        }

        public MainView()
        {
            InitializeComponent();

            this.Text = WindowTitle; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;
            lbl_PumpFileAuthor.Text = "";

            m_Controller = new Controller();

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.PumpDefinitionPath) &&
                File.Exists(Properties.Settings.Default.PumpDefinitionPath))
            {
                try
                {
                    m_Controller.LoadPump(Properties.Settings.Default.PumpDefinitionPath);
                    applyPumpDefinition();
                }
                catch (Exception)
                {
                    // Fehler beim automatischen Laden ignorieren
                }
            }
        }

        private void btn_LoadPump_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_Controller.LoadPump(openFileDialog1.FileName);

                    applyPumpDefinition();

                    Properties.Settings.Default.PumpDefinitionPath = openFileDialog1.FileName;
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Laden fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_CalcFlowRate_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lbl_PipeSuctionPressureDrop, string.Empty);
            txt_SystemHead.ForeColor = Color.Black;

            if (cbx_CalcSuctionPipe.Checked)
            {
                try
                {
                    var l = double.Parse(txt_SuctionPiepLength.Text);
                    var di = double.Parse(txt_SuctionPipeDiameter.Text);

                    m_Controller.SuctionPipe = new Pipe(l, di, 0.1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Die eingegebenen Daten zur Berechnung des saugseitigen Druckabfalls fehlen oder sind fehlerhaft.\n\nSaugseitiger Druckabfall kann nicht berechnet werden.",
                        "Eingabe Fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbx_CalcSuctionPipe.Checked = false;
                }
            }
            else
                m_Controller.SuctionPipe = null;

            double pressure = 0;

            if (double.TryParse(txt_SystemPressure.Text, out pressure))
            {
                m_Controller.CalcFlowRate(pressure);
                txt_SystemFlowRate.Text = m_Controller.SystemFlowRate.ToString("f2") + " m³/h";
                txt_SystemHead.Text = m_Controller.SystemHead.ToString("f2") + " m WS";

                if (cbx_CalcSuctionPipe.Checked)
                {
                    txt_PipeSuctionPressureDrop.Text = m_Controller.SuctionPressureDrop.ToString("f3") + " bar";
                    toolTip1.SetToolTip(lbl_PipeSuctionPressureDrop, "Wert in " + m_Controller.SuctionPressureDropCalcIterations + " Iterationen ermittelt");
                }

                if (m_Controller.SystemFlowRate <= 0)
                MessageBox.Show("Der angegebene Systemdruck entspricht einer Förderhöhe, welche außerhalb der Pumpenkennlinie liegt.\n\n" +
                    "Es kann keine Fördermenge berechnet werden.", "Maximale Förderhöhe überschritten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    btn_ShowPowerPoint.Enabled = true;
            }
        }

        private void applyPumpDefinition()
        {
            txt_PumpModel.Text = m_Controller.Pump.ModellName;
            txt_PumpManufracturer.Text = m_Controller.Pump.Manufacturer;
            txt_PumpPowerOut.Text = m_Controller.Pump.PowerOutput + " kW";
            txt_PumpNominalFlowRate.Text = m_Controller.Pump.NominalFlowRate + " m³/h";
            txt_PumpNominalHead.Text = m_Controller.Pump.NominalDynamicHead + " m WS";
            txt_PumpMaxHead.Text = m_Controller.Pump.MaxTotalHead.ToString("f2") + " m WS";

            lbl_PumpFileAuthor.Text = m_Controller.Pump.AuthorPumpFile;
            toolTip1.SetToolTip(lbl_PumpFileAuthor, m_Controller.Pump.AuthorEmailPumpFile);

            this.Text = string.Concat(WindowTitle, " - ", m_Controller.PumpDefinitionPath);

            clearSystemOutput();
            btn_ShowPumpCurve.Enabled = true;
        }

        private void clearSystemOutput()
        {
            txt_SystemFlowRate.Clear();
            txt_SystemHead.Clear();

            txt_PipeSuctionPressureDrop.Clear();
            toolTip1.SetToolTip(lbl_PipeSuctionPressureDrop, string.Empty);
        }

        private void lbl_PumpFileAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl_PumpFileAuthor.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("mailto:" + m_Controller.Pump.AuthorEmailPumpFile);
        }

        private void btn_ShowPumpCurve_Click(object sender, EventArgs e)
        {
            if (m_ChartView == null || !m_ChartView.Visible)
                m_ChartView = new ChartView("Anzeige Pumpenkennlinie");

            m_ChartView.AddCurve(m_Controller.Pump.ModellName, m_Controller.Pump.GetPerformanceFlowValues(), m_Controller.Pump.GetPerformanceHeadValues());

            m_ChartView.Show();
        }

        private void btn_ShowPowerPoint_Click(object sender, EventArgs e)
        {
            if (m_ChartView == null || !m_ChartView.Visible)
                m_ChartView = new ChartView("Anzeige Arbeitspunkt auf Pumpenkennlinie");

            m_ChartView.AddCurve(m_Controller.Pump.ModellName, m_Controller.Pump.GetPerformanceFlowValues(), m_Controller.Pump.GetPerformanceHeadValues());
            m_ChartView.PowerPoint = new Tuple<double, double>(m_Controller.SystemFlowRate, m_Controller.SystemHead);

            m_ChartView.Show();
        }

        private void cbx_CalcSuctionPipe_CheckedChanged(object sender, EventArgs e)
        {
            txt_SuctionPiepLength.Enabled = cbx_CalcSuctionPipe.Checked;
            txt_SuctionPipeDiameter.Enabled = cbx_CalcSuctionPipe.Checked;
        }
    }
}
