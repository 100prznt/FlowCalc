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

        Controller m_Controller;

        public BindingList<SystemItem> SystemItems { get; set; }

        public double TotalPipeLength { get; private set; }
        public double PipeDiameter { get; private set; }
        
        public string WindowTitle
        {
            get
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                return string.Concat(typeof(MainView).Assembly.GetName().Name, " ", versionInfo.ProductVersion);
            }
        }

        public PipeLengthCalcView(ref Controller controller)
        {
            m_Controller = controller;

            InitializeComponent();

            btn_Cancel.Visible = false;
            btn_Apply.Visible = false;

            var size = new Size(Size.Width, Size.Height - 54);
            Size = size;
            MinimumSize = size;
            MaximumSize = size;

            this.Text = WindowTitle; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            //Setup DGV
            dgv_System.AutoGenerateColumns = false;
            SystemItems = new BindingList<SystemItem>();
            var source = new BindingSource(SystemItems, null);
            dgv_System.DataSource = source;

            generateFittingButtons(NominalDiameters.DN40);
            PipeDiameter = 45.2;
            txt_PipeDiameter.Text = PipeDiameter.ToString("f2");
        }

        public new DialogResult ShowDialog()
        {
            btn_Cancel.Visible = true;
            btn_Apply.Visible = true;

            statusStrip1.Visible = false;

            var size = new Size(Size.Width, Size.Height + 40);
            Size = size;
            MinimumSize = size;
            MaximumSize = size;

            return base.ShowDialog();
        }

        private void generateFittingButtons(NominalDiameters dn)
        {
            Controls["box_FittingButtons"].Controls.Clear();

            var yOffset = 30;
            int i = 1;
            
            if (m_Controller.Fittings != null && m_Controller.Fittings.Count > 0)
            {
                stl_FittingSearchDirectory.Text = "Suchverzeichnis: " + Properties.Settings.Default.FittingsSearchPath;

                foreach (var fitting in m_Controller.Fittings)
                {
                    if (fitting.Diameter == dn)
                    {
                        if (i > 9)
                            throw new NotImplementedException("Maximale Button Anzahl erreicht, hier muss noch gerabeitet werden."); //TODO:

                        var btn = new Button()
                        {
                            Name = "btn_" + fitting.UniqueName,
                            Tag = fitting,
                            Text = fitting.DisplayName,
                            Size = new Size(187, 23),
                            Location = new Point(16, 5 + yOffset * i)
                        };
                        btn.Click += btn_Fitting_Click;

                        Controls["box_FittingButtons"].Controls.Add(btn);

                        i++;
                    }
                }
            }
            else
            {
                stl_FittingSearchDirectory.Text = "Kein Suchpfad für Fittings angegeben oder keine Fittingdefinitionen gefunden.";
                stl_FittingSearchDirectory.ForeColor = Color.Red;
            }
        }

        private void calcTotalLength()
        {
            TotalPipeLength = SystemItems.Sum(x => x.Length * x.Amount);

            txt_TotalPipeLength.Text = TotalPipeLength.ToString("f2") + " m";
        }

        private void btn_Fitting_Click(object sender, EventArgs e)
        {
            var fitting = (Fitting)((Button)sender).Tag;

            SystemItems.Add(new SystemItem(fitting));


            rbtn_Dn40.Enabled = false;
            rbtn_Dn50.Enabled = false;


            calcTotalLength();
        }

        private void rbtn_Dn_CheckedChanged(object sender, EventArgs e)
        {
            var dn = NominalDiameters.NotSpecified;
            if (rbtn_Dn40.Checked)
            {
                dn = NominalDiameters.DN40;
                PipeDiameter = 45.2;
            }
            else if (rbtn_Dn50.Checked)
            {
                dn = NominalDiameters.DN50;
                PipeDiameter = 57;
            }

            txt_PipeDiameter.Text = PipeDiameter.ToString("f2");

            generateFittingButtons(dn);
        }

        private void dgv_System_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calcTotalLength();
        }

        private void btn_AddPipe_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: TryParse in Pipe bereitstellen
                var l = double.Parse(txt_PipeLength.Text);    //m
                var di = double.Parse(txt_PipeDiameter.Text); //mm

                SystemItems.Add(new SystemItem(new Pipe(l, di, 0.1)));

                calcTotalLength();
            }
            catch (Exception)
            {
                MessageBox.Show("Die eingegebenen Rohrdaten sind fehlerhaft.",
                    "Eingabe Fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            SystemItems.Clear();
            txt_TotalPipeLength.Clear();
            rbtn_Dn40.Enabled = true;
            rbtn_Dn50.Enabled = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
