using FlowCalc;
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

namespace PumpDefinitionEditor
{
    public partial class EditorView : Form
    {
        Controller m_Controller;
        ChartView m_ChartView;

        public string WindowTitle
        {
            get
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                return string.Concat(typeof(EditorView).Assembly.GetName().Name, " ", versionInfo.ProductVersion);
            }
        }
        public EditorView()
        {
            InitializeComponent();

            this.Text = WindowTitle; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            m_Controller = new Controller();
        }



        private void btn_NewPump_Click(object sender, EventArgs e)
        {
            m_Controller.NewPump();
            applyPumpDefinition();
        }

        private void btn_LoadPump_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Pumpendefinition laden";
            openFileDialog1.Filter = "Pumpendefinition|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_Controller.LoadPump(openFileDialog1.FileName);
                    applyPumpDefinition();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Laden fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void applyPumpDefinition()
        {
            propertyGrid1.SelectedObject = m_Controller.Pump;

            if (m_Controller.PumpDefinitionPath != null)
            {
                this.Text = string.Concat(WindowTitle, " - ", m_Controller.PumpDefinitionPath.Split('/', '\\').Last());

                btn_SaveCsv.Enabled = true;
                btn_SaveJson.Enabled = true;
                btn_SaveMat.Enabled = true;
                btn_LoadMat.Enabled = true;
                btn_ShowPerformanceCurve.Enabled = true;
            }
            else
            {
                btn_SaveCsv.Enabled = false;
                btn_SaveJson.Enabled = false;
                btn_SaveMat.Enabled = false;
                btn_LoadMat.Enabled = false;
                btn_ShowPerformanceCurve.Enabled = false;
            }
        }

        private void btn_SaveCsv_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Speichern im CSV Format";
            saveFileDialog1.Filter = "CSV Datei | *.csv";

            var path = m_Controller.PumpDefinitionPath.Replace(".xml", ".csv");
            saveFileDialog1.FileName = path.Split('/', '\\').Last();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_Controller.Pump.ToCsvFile(saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (MessageBox.Show("CSV Datei erfolgreich gespeichert.\n\nSoll die Datei geöffnet werden?", "Speichern erfolgreich",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Process.Start(saveFileDialog1.FileName);
            }
        }

        private void btn_SaveJson_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Speichern im JSON Format";
            saveFileDialog1.Filter = "JSON Datei | *.json";

            var path = m_Controller.PumpDefinitionPath.Replace(".xml", ".json");
            saveFileDialog1.FileName = path.Split('/', '\\').Last();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_Controller.Pump.ToJsonFile(saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (MessageBox.Show("JSON Datei erfolgreich gespeichert.\n\nSoll die Datei geöffnet werden?", "Speichern erfolgreich",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Process.Start(saveFileDialog1.FileName);
            }
        }

        private void btn_SaveXml_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Speichern im XML Format";
            saveFileDialog1.Filter = "XML Datei | *.xml";

            var path = string.Empty;
            if (m_Controller.PumpDefinitionPath != null)
                path = m_Controller.PumpDefinitionPath.Replace(".xml", "_neu.xml");
            else
            {
                var safeModellName = m_Controller.Pump.ModellName;
                foreach (var c in System.IO.Path.GetInvalidFileNameChars())
                    safeModellName = safeModellName.Replace(c.ToString(), "");
                path = safeModellName;
            }
            saveFileDialog1.FileName = path.Split('/', '\\').Last();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_Controller.Pump.ToXmlFile(saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (MessageBox.Show("XML Datei erfolgreich gespeichert.\n\nSoll die Datei extern geöffnet werden?", "Speichern erfolgreich",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Process.Start(saveFileDialog1.FileName);

                this.Text = string.Concat(WindowTitle, " - ", saveFileDialog1.FileName.Split('/', '\\').Last());
                m_Controller.PumpDefinitionPath = saveFileDialog1.FileName.Split('/', '\\').Last();
            }
        }

        private void btn_SaveMat_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Matlab Export";
            saveFileDialog1.Filter = "MAT File | *.mat";

            var path = m_Controller.PumpDefinitionPath.Replace(".xml", ".mat");
            saveFileDialog1.FileName = path.Split('/', '\\').Last();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_Controller.Pump.ToMatFile(saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Mat File erfolgreich gespeichert.", "Speichern erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_LoadMat_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Pumpenkennlinie importieren";
            openFileDialog1.Filter = "MAT-File|*.mat";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_Controller.Pump.ImportMatCurve(openFileDialog1.FileName);

                    if (MessageBox.Show("Pumpenkennlinie wurde erfolgreich aus der MAT-File importiert.\n\nSoll die Pumpendefinitionsdatei gespeichert werden?",
                        "Import erfolgreich", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        btn_SaveXml_Click(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Import fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_ShowPerformanceCurve_Click(object sender, EventArgs e)
        {
            if (m_ChartView == null || !m_ChartView.Visible)
                m_ChartView = new ChartView("Anzeige Pumpenkennlinie");

            if (m_Controller.Pump.IsVarioPump)
            {
                //foreach (var rpm in m_Controller.Pump.GetDefaultRpms())
                //    m_ChartView.AddCurve(m_Controller.Pump.ModellName + $" ({rpm} min^-1)", m_Controller.Pump.GetPerformanceFlowValues(rpm), m_Controller.Pump.GetPerformanceHeadValues(rpm));

                //Interpolierte Kennlinien ploten
                var stepwidth = (m_Controller.Pump.MaxRpm - m_Controller.Pump.MinRpm) / 17.0;

                for (double rpm = m_Controller.Pump.MinRpm; rpm < m_Controller.Pump.MaxRpm + 1; rpm += stepwidth)
                    m_ChartView.AddCurve(m_Controller.Pump.ModellName + $" ({(int)rpm} min^-1)", m_Controller.Pump.GetPerformanceFlowValues((int)rpm), m_Controller.Pump.GetPerformanceHeadValues((int)rpm), false);
                
            }
            else
                m_ChartView.AddCurve(m_Controller.Pump.ModellName, m_Controller.Pump.GetPerformanceFlowValues(), m_Controller.Pump.GetPerformanceHeadValues());

            m_ChartView.Show(); 
        }
    }
}
