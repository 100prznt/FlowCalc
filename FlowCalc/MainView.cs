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

        /// <summary>
        /// Standard Suchpfad für Rohrleitungsdefinitionen
        /// </summary>
        const string DEFAULT_PIPEDEF_PATH = @"PipeDefinitions";

        #endregion Constats

        Controller m_Controller;
        ChartView m_ChartView;

        public string WindowTitle
        {
            get
            {
#if DEBUG
                return typeof(MainView).Assembly.GetName().Name + " [DEBUG]";
#else
                var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                return string.Concat(typeof(MainView).Assembly.GetName().Name, " ", versionInfo.ProductVersion);
#endif
            }
        }

        public MainView(string[] args)
        {
            InitializeComponent();

            m_Controller = new Controller();

            if (args.Any(x => string.Equals(x, "devmode", StringComparison.OrdinalIgnoreCase)))
                m_Controller.DevModeEnabled = true;
            else
                entwicklungToolStripMenuItem.Visible = false;

            this.Text = WindowTitle; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;
            lbl_PumpFileAuthor.Text = "";


            //Events anhängen

            m_Controller.NewPumpLoaded += applyPumpDefinition;

            m_Controller.PropertyChanged += M_Controller_PropertyChanged;

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

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.PipeSearchPath) && Directory.Exists(DEFAULT_PIPEDEF_PATH))
            {
                Properties.Settings.Default.PipeSearchPath = DEFAULT_PIPEDEF_PATH;
                Properties.Settings.Default.Save();
            }

            //Letzte Pumpe laden
            if (File.Exists(Properties.Settings.Default.PumpDefinitionPath))
            {
                try
                {
                    m_Controller.LoadPump(Properties.Settings.Default.PumpDefinitionPath);
                }
                catch (Exception ex)
                {
                    // Fehler beim automatischen Laden ignorieren
                }
            }

            if (m_Controller.IsPumpEditorAvailable)
                editorStartenToolStripMenuItem.Enabled = true;



            loadPumps();
            loadFittings();
            loadPipes();

            //Letzte Leitungs-Definition laden
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.LastPipeDimensionUniqueName))
            {
                var pipe = m_Controller.DefaultPipeDimensions.FirstOrDefault(x => string.Equals(x.UniqueName, Properties.Settings.Default.LastPipeDimensionUniqueName, StringComparison.OrdinalIgnoreCase));
                m_Controller.SelectedPipe = pipe;
            }

            cbx_CalcSuctionPipe.Checked = Properties.Settings.Default.EnableSuctionPressureDrop;

            if (Properties.Settings.Default.SuctionPipeLength > 0)
                txt_SuctionPiepLength.Text = Properties.Settings.Default.SuctionPipeLength.ToString("F2");
            if (Properties.Settings.Default.SystemPressure > 0)
                txt_SystemPressure.Text = Properties.Settings.Default.SystemPressure.ToString("F2");

        }

        private void M_Controller_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Controller.SelectedPipe))
            {
                txt_PipeName.Text = m_Controller.SelectedPipe.DisplayName;
                txt_SuctionPipeDiameter.Text = m_Controller.SelectedPipe.InnerDiameter.ToString("F2") + " mm";
                txt_SuctionPiepRoughness.Text = m_Controller.SelectedPipe.Roughness.ToString("F3") + " mm";
            }
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
            toolTip1.SetToolTip(txt_PipeSuctionPressureDrop, string.Empty);
            txt_SystemHead.ForeColor = Color.Black;

            if (cbx_CalcSuctionPipe.Checked)
            {
                try
                {
                    var l = double.Parse(txt_SuctionPiepLength.Text);
                    //var di = double.Parse(txt_SuctionPipeDiameter.Text);
                    //var k = double.Parse(txt_SuctionPiepRoughness.Text);
                    
                    m_Controller.SuctionPipe = new Pipe(l, m_Controller.SelectedPipe);

                    Properties.Settings.Default.SuctionPipeLength = l;
                    //Properties.Settings.Default.SuctionPipeDiameter = di;
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
                m_Controller.FilterPressure = pressure;
                if (m_Controller.Pump.IsVarioPump)
                    m_Controller.CalcFlowRate(pressure, tb_Rpm.Value);
                else
                    m_Controller.CalcFlowRate(pressure);
                txt_SystemFlowRate.Text = m_Controller.SystemFlowRate.ToString("f2") + " m³/h";
                txt_SystemHead.Text = m_Controller.SystemHead.ToString("f2") + " m WS";

                if (cbx_CalcSuctionPipe.Checked)
                {
                    txt_PipeSuctionPressureDrop.Text = m_Controller.SuctionPressureDrop.ToString("f3") + " bar";
                    toolTip1.SetToolTip(lbl_PipeSuctionPressureDrop, "Wert in " + m_Controller.SuctionPressureDropCalcIterations + " Iterationen ermittelt");
                    toolTip1.SetToolTip(txt_PipeSuctionPressureDrop, "Wert in " + m_Controller.SuctionPressureDropCalcIterations + " Iterationen ermittelt");


                    var suctionPipeFlowSpeed = m_Controller.SuctionPipe.CalcFlowVelocity(m_Controller.SystemFlowRate);
                    if (suctionPipeFlowSpeed > 1.5)
                    {
                        //toolTip_Warning.SetToolTip(lbl_PipeSuctionFlowSpeed, "Die Fließgeschwindigkeit in der Saugleitung liegt über dem vom BSW empfohlenen Wert (1,5 m/s).");
                        

                        txt_PipeSuctionFlowSpeed.BackColor = Color.LightPink;
                    }
                    else
                    {
                        //toolTip1.SetToolTip(lbl_PipeSuctionFlowSpeed, "Die Fließgeschwindigkeit in der Saugleitung liegt im vom BSW empfohlenem Bereich (< 1,5 m/s).");
                        
                        txt_PipeSuctionFlowSpeed.BackColor = Color.LightGreen;
                    }
                    txt_PipeSuctionFlowSpeed.Text = suctionPipeFlowSpeed.ToString("f3") + " m/s";

                }

                if (m_Controller.SystemFlowRate <= 0)
                {
                    if (m_Controller.Pump.IsVarioPump && tb_Rpm.Value < m_Controller.Pump.MaxRpm)
                    {
                        MessageBox.Show("Der angegebene Systemdruck entspricht einer Förderhöhe, welche außerhalb der Pumpenkennlinie liegt. Es kann keine Fördermenge berechnet werden.\n\n" +
                            $"Gegebenfalls muss die Drehzahl (akt. {tb_Rpm.Value} min^-1) der Vario-Pumpe erhöht werden.", "Maximale Förderhöhe überschritten", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Der angegebene Systemdruck entspricht einer Förderhöhe, welche außerhalb der Pumpenkennlinie liegt.\n\n" +
                            "Es kann keine Fördermenge berechnet werden.", "Maximale Förderhöhe überschritten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Properties.Settings.Default.EnableSuctionPressureDrop = cbx_CalcSuctionPipe.Checked;
                    Properties.Settings.Default.SystemPressure = pressure;
                    Properties.Settings.Default.Save();

                    btn_ShowPowerPoint.Enabled = true;
                    btn_GenerateReport.Enabled = true;
                }
            }
        }

        private void applyPumpDefinition()
        {
            txt_PumpModel.Text = m_Controller.Pump.ModellName;
            txt_PumpManufracturer.Text = m_Controller.Pump.Manufacturer;
            if (m_Controller.Pump.PowerInput <= 0)
                txt_PumpPowerIn.Text = "-";
            else
                txt_PumpPowerIn.Text = m_Controller.Pump.PowerInput + " kW";
            if (m_Controller.Pump.PowerOutput <= 0)
                txt_PumpPowerOut.Text = "-";
            else
                txt_PumpPowerOut.Text = m_Controller.Pump.PowerOutput + " kW";
            txt_PumpNominalFlowRate.Text = m_Controller.Pump.NominalFlowRate + " m³/h";
            txt_PumpNominalHead.Text = m_Controller.Pump.NominalDynamicHead + " m WS";
            int? rpm = null;
            if (m_Controller.Pump.IsVarioPump)
            {
                gb_VarioPump.Enabled = true;
                tb_Rpm.Minimum = m_Controller.Pump.MinRpm;
                rpm = m_Controller.Pump.MaxRpm;
                tb_Rpm.Maximum = (int)rpm;
                tb_Rpm.Value = (int)rpm;
            }
            else
            {
                gb_VarioPump.Enabled = false;
                tb_Rpm.Maximum = 1000;
                tb_Rpm.Minimum = 0;
                tb_Rpm.Value = 0;
                lbl_Rpm.Text = "0 min^-1";
                txt_PumpRpmPowerIn.Clear();
                txt_PumpRpmHead.Clear();
            }
            txt_PumpMaxHead.Text = m_Controller.Pump.GetMaxTotalHead(rpm).ToString("f2") + " m WS";

            lbl_PumpFileAuthor.Text = m_Controller.Pump.AuthorPumpFile;
            lbl_PumpDataSourceUrl.Text = m_Controller.Pump.DataSourceUrl;
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
            if (m_Controller.Pump.AuthorEmailPumpFile.Contains("@"))
                Process.Start("mailto:" + m_Controller.Pump.AuthorEmailPumpFile);
            else
                Process.Start(m_Controller.Pump.AuthorEmailPumpFile);
        }

        private void btn_ShowPumpCurve_Click(object sender, EventArgs e)
        {
            if (m_ChartView == null || !m_ChartView.Visible)
                m_ChartView = new ChartView("Anzeige Pumpenkennlinie");

            int? rpm = null;
            var pumpName = m_Controller.Pump.ModellName;

            if (m_Controller.Pump.IsVarioPump)
            {
                rpm = tb_Rpm.Value;
                pumpName = pumpName + $" ({rpm} min^-1)";

                var performanceRange = m_Controller.Pump.GetPerformanceRange();
                m_ChartView.AddRange(m_Controller.Pump.ModellName, performanceRange.Item1, performanceRange.Item2);
            }

            m_ChartView.AddCurve(pumpName, m_Controller.Pump.GetPerformanceFlowValues(rpm), m_Controller.Pump.GetPerformanceHeadValues(rpm));

            m_ChartView.Show();
        }

        private void btn_ShowPowerPoint_Click(object sender, EventArgs e)
        {
            if (m_ChartView == null || !m_ChartView.Visible)
                m_ChartView = new ChartView("Anzeige Arbeitspunkt auf Pumpenkennlinie");

            int? rpm = null;
            string pumpName = m_Controller.Pump.ModellName;
            if (m_Controller.Pump.IsVarioPump)
            {
                rpm = tb_Rpm.Value;
                pumpName = pumpName + $" @ {rpm} min^-1";

                var performanceRange = m_Controller.Pump.GetPerformanceRange();
                m_ChartView.AddRange(m_Controller.Pump.ModellName, performanceRange.Item1, performanceRange.Item2);
            }
            m_ChartView.AddCurve(pumpName, m_Controller.Pump.GetPerformanceFlowValues(rpm), m_Controller.Pump.GetPerformanceHeadValues(rpm));
            m_ChartView.PowerPoint = new Tuple<double, double>(m_Controller.SystemFlowRate, m_Controller.SystemHead);

            m_ChartView.Show();
        }

        private void cbx_CalcSuctionPipe_CheckedChanged(object sender, EventArgs e)
        {
            txt_SuctionPiepLength.Enabled = cbx_CalcSuctionPipe.Checked;
            //txt_SuctionPipeDiameter.Enabled = cbx_CalcSuctionPipe.Checked;
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

        private void loadPipes()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.PipeSearchPath) &&
                    Directory.Exists(Properties.Settings.Default.PipeSearchPath))
                {
                    try
                    {
                        m_Controller.LoadPipes(Properties.Settings.Default.PipeSearchPath);
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
            var presetDgl = new PresetView()
            {
                Settings = Controller.CurrentPresets
            };

            if (presetDgl.ShowDialog() == DialogResult.OK)
            {
                m_Controller.ApplyPresets(presetDgl.Settings);
            }
        }

        private void poolvolumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var volumeCalcView = new VolumeCalcView();

            volumeCalcView.Show();
        }

        private void umwälzleistungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var circulationCalcView = new CirculationCalcView()
            {
                FlowRate = m_Controller.SystemFlowRate
            };

            circulationCalcView.Show();
        }

        private void dokumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/100prznt/FlowCalc/");
        }

        private void filtergeschwindigkeitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filterSpeedCalcView = new FilterSpeedCalcView()
            {
                FlowRate = m_Controller.SystemFlowRate
            };

            filterSpeedCalcView.Show();
        }

        private void btn_SelectPipe_Click(object sender, EventArgs e)
        {
            var pipeSelectView = new PipeSelectView(m_Controller.DefaultPipeDimensions, "");
            pipeSelectView.SetSelectedPipe(m_Controller.SelectedPipe);

            if (pipeSelectView.ShowDialog() == DialogResult.OK)
            {
                m_Controller.SelectedPipe = pipeSelectView.SelectedPipe;
            }
        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            var reportSetupDlg = new EnterReportDataView();

            if (Directory.Exists(Controller.CurrentPresets.DefaultReportPath))
                saveFileDialog1.InitialDirectory = Controller.CurrentPresets.DefaultReportPath;

            saveFileDialog1.FileName = "Report_" + GetFriendlyName(m_Controller.Pump.ModellName + "_at_" + m_Controller.SystemHead.ToString("f2") + "mWS.pdf");

            int? rpm = null;
            if (m_Controller.Pump.IsVarioPump)
                rpm = tb_Rpm.Value;

            if (reportSetupDlg.ShowDialog() == DialogResult.OK && saveFileDialog1.ShowDialog() == DialogResult.OK)
                m_Controller.GeneratePdfReport(saveFileDialog1.FileName, reportSetupDlg.PoolVolume, reportSetupDlg.FilterDiameter, rpm);
        }

        private string GetFriendlyName(string name)
        {
            name = name.Replace(' ', '_');
            name = name.Replace(',', '_');
            name = name.Replace('-', '_');

            foreach (char c in Path.GetInvalidFileNameChars())
                name = name.Replace(c.ToString(), "");

            return name;
        }

        private void lbl_PumpDataSourceUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(m_Controller.Pump.DataSourceUrl);
        }

        private void tb_Rpm_ValueChanged(object sender, EventArgs e)
        {
            lbl_Rpm.Text = tb_Rpm.Value + " min^-1";

            txt_PumpRpmHead.Text = m_Controller.Pump.GetMaxTotalHead(tb_Rpm.Value).ToString("f2") + " m WS";

            txt_PumpRpmPowerIn.Text = m_Controller.Pump.GetInputPower(tb_Rpm.Value, double.NaN).ToString("f3") + " kW";
        }

        private void searchPathPipesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.PipeSearchPath = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();

                loadFittings();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Export PipeDimensions";
            saveFileDialog1.Filter = "CSV|*.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                m_Controller.SavePipeDefinitionsToCsv(saveFileDialog1.FileName);
        }

        private void importCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Import PipeDimensions";
            openFileDialog1.Filter = "CSV|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!m_Controller.LoadPipeDefinitionsFromCsv(openFileDialog1.FileName))
                    MessageBox.Show("Import Rohrabmessungen", "Der Import ist fehlgeschlagen, CSV-Datei entspricht nicht den Vorgaben.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Import Rohrabmessungen", "Der Import war erfolgreich.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void entwicklungToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            entwicklungToolStripMenuItem.ForeColor = Color.White;
        }

        private void entwicklungToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            entwicklungToolStripMenuItem.ForeColor = Color.Black;
        }

        private void exportRohrleitungsdefinitionenXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                m_Controller.SavePipeDimensionsToXmls(folderBrowserDialog1.SelectedPath);
            }
            }
    }
}
