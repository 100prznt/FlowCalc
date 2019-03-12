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
    public partial class AboutView : Form
    {
        public string AuthorEmail { get; set; }

        public string RepoUrl { get; set; }

        public AboutView()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            lbl_AssemblyTitle.Text = AssemblyInfo.AssemblyTitle;
            lbl_AssemblyCompany.Text = AssemblyInfo.AssemblyCompany;
            txt_AssemblyDescription.Text = AssemblyInfo.AssemblyDescription;
            lbl_AssemblyVersion.Text = string.Format("Version: {0}", AssemblyInfo.AssemblyVersion);
            
        }

        public new DialogResult ShowDialog()
        {
            link_Repo.Text = RepoUrl;
            link_AuthorEmail.Text = AuthorEmail;

            return base.ShowDialog();
        }

        private void link_Repo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(RepoUrl);
        }

        private void link_AuthorEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:" + AuthorEmail);
        }
    }
}
