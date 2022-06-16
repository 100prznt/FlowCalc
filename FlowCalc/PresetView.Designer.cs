namespace FlowCalc
{
    partial class PresetView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MetresAboveSeaLevel = new System.Windows.Forms.TextBox();
            this.cbx_Medium = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_EnableUserName = new System.Windows.Forms.CheckBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SelectReportPath = new System.Windows.Forms.Button();
            this.txt_ReportPath = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medium";
            // 
            // txt_MetresAboveSeaLevel
            // 
            this.txt_MetresAboveSeaLevel.Location = new System.Drawing.Point(129, 66);
            this.txt_MetresAboveSeaLevel.Name = "txt_MetresAboveSeaLevel";
            this.txt_MetresAboveSeaLevel.Size = new System.Drawing.Size(61, 20);
            this.txt_MetresAboveSeaLevel.TabIndex = 4;
            // 
            // cbx_Medium
            // 
            this.cbx_Medium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Medium.FormattingEnabled = true;
            this.cbx_Medium.Location = new System.Drawing.Point(129, 38);
            this.cbx_Medium.Name = "cbx_Medium";
            this.cbx_Medium.Size = new System.Drawing.Size(100, 21);
            this.cbx_Medium.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Höhe über NN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbx_Medium);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MetresAboveSeaLevel);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 114);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Berechnung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(213, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Wert geht akt. nicht in die Berechnung ein!";
            // 
            // cbx_EnableUserName
            // 
            this.cbx_EnableUserName.AutoSize = true;
            this.cbx_EnableUserName.Checked = true;
            this.cbx_EnableUserName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_EnableUserName.Location = new System.Drawing.Point(373, 44);
            this.cbx_EnableUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_EnableUserName.Name = "cbx_EnableUserName";
            this.cbx_EnableUserName.Size = new System.Drawing.Size(50, 17);
            this.cbx_EnableUserName.TabIndex = 12;
            this.cbx_EnableUserName.Text = "Aktiv";
            this.cbx_EnableUserName.UseVisualStyleBackColor = true;
            this.cbx_EnableUserName.CheckedChanged += new System.EventHandler(this.cbx_EnableUserName_CheckedChanged);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(360, 311);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(103, 23);
            this.btn_Apply.TabIndex = 10;
            this.btn_Apply.Text = "Übernehmen";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(252, 311);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Abbrechen";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SelectReportPath);
            this.groupBox2.Controls.Add(this.cbx_EnableUserName);
            this.groupBox2.Controls.Add(this.txt_ReportPath);
            this.groupBox2.Controls.Add(this.txt_UserName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(16, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 117);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report";
            // 
            // btn_SelectReportPath
            // 
            this.btn_SelectReportPath.Location = new System.Drawing.Point(373, 68);
            this.btn_SelectReportPath.Name = "btn_SelectReportPath";
            this.btn_SelectReportPath.Size = new System.Drawing.Size(46, 23);
            this.btn_SelectReportPath.TabIndex = 13;
            this.btn_SelectReportPath.Text = "...";
            this.btn_SelectReportPath.UseVisualStyleBackColor = true;
            this.btn_SelectReportPath.Click += new System.EventHandler(this.btn_SelectReportPath_Click);
            // 
            // txt_ReportPath
            // 
            this.txt_ReportPath.Location = new System.Drawing.Point(129, 72);
            this.txt_ReportPath.Name = "txt_ReportPath";
            this.txt_ReportPath.Size = new System.Drawing.Size(228, 20);
            this.txt_ReportPath.TabIndex = 13;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(129, 42);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(228, 20);
            this.txt_UserName.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Benutzername";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Ausgabepfad";
            // 
            // PresetView
            // 
            this.AcceptButton = this.btn_Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(480, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(496, 249);
            this.Name = "PresetView";
            this.Text = "PresetView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MetresAboveSeaLevel;
        private System.Windows.Forms.ComboBox cbx_Medium;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbx_EnableUserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_SelectReportPath;
        private System.Windows.Forms.TextBox txt_ReportPath;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}