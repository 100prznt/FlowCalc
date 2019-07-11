using FlowCalc.PoolSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowCalc
{
    public partial class CalcView : Form
    {
        #region Members
        private Controller m_Controller;
        private ChartView m_ChartView;

        #endregion Members

        #region Constructor
        public CalcView()
        {
            InitializeComponent();

            m_Controller = new Controller();

            this.Text = m_Controller.WindowTitle; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            initPumpDgv();
            loadPumps();
            applyPumps();
        }

        #endregion Constructor

        private void close_FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutView = new AboutView()
            {
                RepoUrl = "https://github.com/100prznt/FlowCalc",
                AuthorEmail = "pool@100prznt.de"
            };

            aboutView.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var presetDgl = new PresetView()
            {
                Settings = Controller.CurrentPresets
            };

            if (presetDgl.ShowDialog() == DialogResult.OK)
            {
                m_Controller.ApplyPresets(presetDgl.Settings);
            }
        }

        private void initPumpDgv()
        {
            dgv_Pumps.AutoGenerateColumns = false;

            dgv_Pumps.Columns["col_PowerOut"].DefaultCellStyle.Format = "0.0# kW";
            dgv_Pumps.Columns["col_FlowRate"].DefaultCellStyle.Format = "0.0# m³/h";
            dgv_Pumps.Columns["col_DynHead"].DefaultCellStyle.Format = "0.0# m WS";
            dgv_Pumps.Columns["col_MaxTotalHead"].DefaultCellStyle.Format = "0.00 m WS";

            dgv_Pumps.Columns["col_PowerOut"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgv_Pumps.Columns["col_FlowRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgv_Pumps.Columns["col_DynHead"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgv_Pumps.Columns["col_MaxTotalHead"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
        }

        private void loadPumps()
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.PumpSearchPath) &&
                    Directory.Exists(Properties.Settings.Default.PumpSearchPath))
            {
                try
                {
                    m_Controller.LoadPumps(Properties.Settings.Default.PumpSearchPath);
                    var path = Properties.Settings.Default.PumpSearchPath;
                    if (!(path.Contains('/') || path.Contains('\\')))
                        path = Directory.GetCurrentDirectory() + "\\" + path;
                    //stl_PumpSearchDirectory.Text = "Suchverzeichnis: " + path;
                }
                catch (Exception)
                {
                    // Fehler beim automatischen Laden ignorieren
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void applyPumps()
        {
            dgv_Pumps.DataSource = m_Controller.Pumps;
        }

        private void btn_ShowPerformanceCurve_Click(object sender, EventArgs e)
        {
            m_Controller.ShowPumpPerformanceCurve(ref m_ChartView);
        }

        private void dgv_Pumps_SelectionChanged(object sender, EventArgs e)
        {
            m_Controller.Pump = (Pump)dgv_Pumps.CurrentRow.DataBoundItem;
            stat_Pump.Text = m_Controller.Pump.ToString();
        }

        private void btn_CalcFlowRate_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lbl_PipeSuctionPressureDrop, string.Empty);
            toolTip1.SetToolTip(txt_PipeSuctionPressureDrop, string.Empty);
            txt_SystemHead.ForeColor = Color.Black;

            if (cbx_CalcSuctionPipe.Checked)
            {
                try
                {
                    var l = double.Parse(txt_SuctionPiepLength.Text);
                    var di = double.Parse(txt_SuctionPipeDiameter.Text);

                    m_Controller.SuctionPipe = new Pipe(l, di, Controller.CurrentPresets.Roughness);

                    Properties.Settings.Default.SuctionPipeLength = l;
                    Properties.Settings.Default.SuctionPipeDiameter = di;
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
                stat_FlowRate.Text = m_Controller.SystemFlowRate.ToString("f2") + " m³/h";
                txt_SystemHead.Text = m_Controller.SystemHead.ToString("f2") + " m WS";

                if (cbx_CalcSuctionPipe.Checked)
                {
                    txt_PipeSuctionPressureDrop.Text = m_Controller.SuctionPressureDrop.ToString("f3") + " bar";
                    toolTip1.SetToolTip(lbl_PipeSuctionPressureDrop, "Wert in " + m_Controller.SuctionPressureDropCalcIterations + " Iterationen ermittelt");
                    toolTip1.SetToolTip(txt_PipeSuctionPressureDrop, "Wert in " + m_Controller.SuctionPressureDropCalcIterations + " Iterationen ermittelt");
                }

                if (m_Controller.SystemFlowRate <= 0)
                    MessageBox.Show("Der angegebene Systemdruck entspricht einer Förderhöhe, welche außerhalb der Pumpenkennlinie liegt.\n\n" +
                        "Es kann keine Fördermenge berechnet werden.", "Maximale Förderhöhe überschritten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Properties.Settings.Default.EnableSuctionPressureDrop = cbx_CalcSuctionPipe.Checked;
                    Properties.Settings.Default.SystemPressure = pressure;
                    Properties.Settings.Default.Save();

                    btn_ShowPowerPoint.Enabled = true;
                }
            }
        }

        private void btn_ShowPowerPoint_Click(object sender, EventArgs e)
        {
            m_Controller.ShowPowerPoint(ref m_ChartView);
        }

        private void cbx_CalcSuctionPipe_CheckedChanged(object sender, EventArgs e)
        {
            txt_SuctionPiepLength.Enabled = cbx_CalcSuctionPipe.Checked;
            txt_SuctionPipeDiameter.Enabled = cbx_CalcSuctionPipe.Checked;
        }

        private void btn_CalcLength_Click(object sender, EventArgs e)
        {
            var lengthCalcView = new PipeLengthCalcView(ref m_Controller);

            if (lengthCalcView.ShowDialog() == DialogResult.OK)
            {
                cbx_CalcSuctionPipe.Checked = true;
                txt_SuctionPiepLength.Text = lengthCalcView.TotalPipeLength.ToString("f2");
                txt_SuctionPipeDiameter.Text = lengthCalcView.PipeDiameter.ToString("f2");
            }
        }
    }
}
