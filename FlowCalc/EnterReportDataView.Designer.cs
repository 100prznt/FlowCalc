namespace FlowCalc
{
    partial class EnterReportDataView
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
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_VolumeUnit = new System.Windows.Forms.ComboBox();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FilterDiameter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_OpenCalculator = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(263, 167);
            this.btn_Accept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(103, 23);
            this.btn_Accept.TabIndex = 0;
            this.btn_Accept.Text = "OK";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(152, 167);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Abbrechen";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_OpenCalculator);
            this.groupBox1.Controls.Add(this.cmb_VolumeUnit);
            this.groupBox1.Controls.Add(this.txt_Volume);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pool";
            // 
            // cmb_VolumeUnit
            // 
            this.cmb_VolumeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_VolumeUnit.FormattingEnabled = true;
            this.cmb_VolumeUnit.Location = new System.Drawing.Point(254, 29);
            this.cmb_VolumeUnit.Name = "cmb_VolumeUnit";
            this.cmb_VolumeUnit.Size = new System.Drawing.Size(54, 21);
            this.cmb_VolumeUnit.TabIndex = 21;
            this.cmb_VolumeUnit.SelectedIndexChanged += new System.EventHandler(this.cmb_VolumeUnit_SelectedIndexChanged);
            // 
            // txt_Volume
            // 
            this.txt_Volume.Location = new System.Drawing.Point(163, 30);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(85, 20);
            this.txt_Volume.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Wasserinhalt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_FilterDiameter);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(9, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 68);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filteranlage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "mm";
            // 
            // txt_FilterDiameter
            // 
            this.txt_FilterDiameter.Location = new System.Drawing.Point(163, 28);
            this.txt_FilterDiameter.Name = "txt_FilterDiameter";
            this.txt_FilterDiameter.Size = new System.Drawing.Size(85, 20);
            this.txt_FilterDiameter.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Filterkessel Durchmesser";
            // 
            // btn_OpenCalculator
            // 
            this.btn_OpenCalculator.Location = new System.Drawing.Point(317, 28);
            this.btn_OpenCalculator.Name = "btn_OpenCalculator";
            this.btn_OpenCalculator.Size = new System.Drawing.Size(25, 23);
            this.btn_OpenCalculator.TabIndex = 22;
            this.btn_OpenCalculator.Text = "...";
            this.btn_OpenCalculator.UseVisualStyleBackColor = true;
            this.btn_OpenCalculator.Click += new System.EventHandler(this.btn_OpenCalculator_Click);
            // 
            // EnterReportDataView
            // 
            this.AcceptButton = this.btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(377, 202);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Accept);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EnterReportDataView";
            this.Text = "EnterReportDataView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_VolumeUnit;
        private System.Windows.Forms.TextBox txt_Volume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FilterDiameter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_OpenCalculator;
    }
}