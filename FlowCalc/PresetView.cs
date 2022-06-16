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
    public partial class PresetView : Form
    {
        #region Members
        BindingList<Medium> m_AavailableMedia;

        #endregion Members

        public CalcPresets Settings { get; set; }

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

        public PresetView()
        {
            InitializeComponent();

            this.Text = WindowTitle; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            UpdateTemperatureCbx();
        }

        public DialogResult ShowDialog()
        {
            if (Settings == null)
                throw new ArgumentNullException("No settings provided!");

            if (Settings.Medium != null)
                cbx_Medium.SelectedValue = Settings.Medium.DisplayName;
            else
                cbx_Medium.SelectedItem = Medium.Water20;
            txt_MetresAboveSeaLevel.Text = Settings.MetresAboveSeaLevel.ToString("F0");

            txt_UserName.Text = Settings.UserName;
            cbx_EnableUserName.Checked = !Settings.DisableUserName;

            if (Directory.Exists(Settings.DefaultReportPath))
                txt_ReportPath.Text = Settings.DefaultReportPath;

            return base.ShowDialog();
        }

        void UpdateTemperatureCbx()
        {
            m_AavailableMedia = new BindingList<Medium>();

            foreach (var method in typeof(Medium).GetMethods())
            {
                if (method.MemberType == MemberTypes.Method && method.IsStatic && method.ReturnType == typeof(Medium))
                    m_AavailableMedia.Add((Medium)method.Invoke(null, null));
            }

            cbx_Medium.DataSource = m_AavailableMedia;
            cbx_Medium.DisplayMember = nameof(Medium.DisplayName);
            cbx_Medium.ValueMember = nameof(Medium.DisplayName);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            Settings.Medium = (Medium)cbx_Medium.SelectedItem;
            Settings.MetresAboveSeaLevel = double.Parse(txt_MetresAboveSeaLevel.Text);

            Settings.UserName = txt_UserName.Text;
            Settings.DisableUserName = !cbx_EnableUserName.Checked;

            if (Directory.Exists(txt_ReportPath.Text))
                Settings.DefaultReportPath = txt_ReportPath.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbx_EnableUserName_CheckedChanged(object sender, EventArgs e)
        {
            txt_UserName.Enabled = cbx_EnableUserName.Checked;
        }

        private void btn_SelectReportPath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Settings.DefaultReportPath))
                folderBrowserDialog1.SelectedPath = Settings.DefaultReportPath;
                

            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                txt_ReportPath.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
