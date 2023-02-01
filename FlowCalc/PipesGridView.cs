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
    public partial class PipesGridView : Form
    {
        public PipeDimension SelectedPipe { get; set; }

        public string PipeDefinitionsPath { get; set; }

        public BindingList<PipeDimension> PipeList { get; set; }

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

        public PipesGridView(List<PipeDimension> loadedPipes, string pipeDefinitionsPath)
        {
            InitializeComponent();

            this.Text = WindowTitle + " - Übersicht der geladenen Rohrleitungen"; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            PipeList = new BindingList<PipeDimension>(loadedPipes);
            PipeDefinitionsPath = pipeDefinitionsPath;

            cbx_SelectedPipe.ValueMember = nameof(PipeDimension.DisplayName);
            //cbx_SelectedPipe.Items.AddRange(PipeList.ToArray());
            cbx_SelectedPipe.DataSource = PipeList;


            dgv_Pipes.AutoGenerateColumns = false;
            dgv_Pipes.DataSource = PipeList;
        }


        //Controller.CurrentPresets.Roughness

        enum PipeType
        {
            Undefined,
            PvcPipe,
            PvcFlex,
            PoolPipe
        }

        private void cbx_SelectedPipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPipe = (PipeDimension)cbx_SelectedPipe.SelectedItem;
            //pg_Pipe.SelectedObject = SelectedPipe;
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        public void SetSelectedPipe(PipeDimension selectedPipe)
        {
            cbx_SelectedPipe.SelectedItem = selectedPipe;
        }
    }
}
