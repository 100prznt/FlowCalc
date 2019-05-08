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
        #region Constants
        /// <summary>
        /// Standard Suchpfad für Pumpendefinitionen
        /// </summary>
        const string DEFAULT_PUMPDEF_PATH = @"PumpDefinitions";

        /// <summary>
        /// Standard Suchpfad für Fittingdefinitionen
        /// </summary>
        const string DEFAULT_FITTINGDEF_PATH = @"FittingDefinitions";

        #endregion Constats

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

            //Events anhängen

            m_Controller.NewPumpLoaded += applyPumpDefinition;

            var sdf = Properties.Settings.Default.PumpSearchPath;

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.PumpSearchPath) && Directory.Exists(DEFAULT_PUMPDEF_PATH))
            {
                Properties.Settings.Default.PumpSearchPath = DEFAULT_PUMPDEF_PATH;
                Properties.Settings.Default.Save();
            }

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.FittingsSearchPath) && Directory.Exists(DEFAULT_FITTINGDEF_PATH))
            {
                Properties.Settings.Default.FittingsSearchPath = DEFAULT_FITTINGDEF_PATH;
                Properties.Settings.Default.Save();
            }

            //Letzte Pumpe laden
            if (File.Exists(Properties.Settings.Default.PumpDefinitionPath))
            {
                try
                {
                    m_Controller.LoadPump(Properties.Settings.Default.PumpDefinitionPath);
                }
                catch (Exception)
                {
                    // Fehler beim automatischen Laden ignorieren
                }
            }

            if (File.Exists("PumpDefinitionEditor.exe"))
                editorStartenToolStripMenuItem.Enabled = true;

            loadPumps();
            loadFittings();

            cbx_CalcSuctionPipe.Checked = Properties.Settings.Default.EnableSuctionPressureDrop;
            if (Properties.Settings.Default.SuctionPipeDiameter > 0)
                txt_SuctionPipeDiameter.Text = Properties.Settings.Default.SuctionPipeDiameter.ToString("f2");
            if (Properties.Settings.Default.SuctionPipeLength > 0)
                txt_SuctionPiepLength.Text = Properties.Settings.Default.SuctionPipeLength.ToString("f2");
            if (Properties.Settings.Default.SystemPressure > 0)
                txt_SystemPressure.Text = Properties.Settings.Default.SystemPressure.ToString("f2");
        }

        private void btn_LoadPump_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_Controller.LoadPump(openFileDialog1.FileName);
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

            double pumpHeigth = 0;
            if (double.TryParse(txt_PumpHeight.Text, out pumpHeigth))
            {
                Properties.Settings.Default.PumpHeight = pumpHeigth;
                Properties.Settings.Default.Save();
            }


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
                {
                    Properties.Settings.Default.EnableSuctionPressureDrop = cbx_CalcSuctionPipe.Checked;
                    Properties.Settings.Default.SystemPressure = pressure;
                    Properties.Settings.Default.Save();

                    btn_ShowPowerPoint.Enabled = true;
                }
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
            Properties.Settings.Default.PumpDefinitionPath = m_Controller.PumpDefinitionPath;
            Properties.Settings.Default.Save();

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
            Process.Start("mailto:" + m_Controller.Pump.AuthorEmailPumpFile);
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

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadFittings()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.PumpSearchPath) &&
                    Directory.Exists(Properties.Settings.Default.PumpSearchPath))
                {
                    try
                    {
                        m_Controller.LoadFittings(Properties.Settings.Default.FittingsSearchPath);
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
            catch (Exception)
            {
                // Fehler beim automatischen Laden ignorieren
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        

        private void loadPumps()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
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
                        stl_PumpSearchDirectory.Text = "Suchverzeichnis: " + path;
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

                if (m_Controller.Pumps != null && m_Controller.Pumps.Count > 0)
                {
                    var pumps = new List<ToolStripItem>();
                    foreach (var pump in m_Controller.Pumps)
                    {
                        Debug.WriteLine("Add menuitem (" + pump.ModellName + ")");
                        pumps.Add(new ToolStripMenuItem(pump.ModellName, null, selectPump)
                        {
                            Tag = pump.FilePath
                        });
                    }
                    auswahlPumpeToolStripMenuItem.Enabled = true;
                    auswahlPumpeToolStripMenuItem.DropDownItems.AddRange(pumps.ToArray());
                }
                else
                    auswahlPumpeToolStripMenuItem.Enabled = false;
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

        private void selectPump(object sender, EventArgs e)
        {
            string pumpFileName = (string)((ToolStripMenuItem)sender).Tag;

            m_Controller.LoadPump(pumpFileName);
        }

        private void volumenstromFließgeschwindigkeitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var calcView = new PipeCalcView();
            calcView.Show();
        }

        private void editorStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("PumpDefinitionEditor.exe");
        }

        private void überToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var aboutView = new AboutView()
            {
                RepoUrl = "https://github.com/100prznt/FlowCalc",
                AuthorEmail = "pool@100prznt.de"
            };

            aboutView.ShowDialog();
        }

        private void äquivalenteRohrlängeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lengthCalcView = new PipeLengthCalcView(ref m_Controller);

            lengthCalcView.Show();
        }

        private void searchPathPumpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.PumpSearchPath = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();

                loadPumps();
            }
        }

        private void searchPathFittingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FittingsSearchPath = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();

                loadFittings();
            }
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

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
