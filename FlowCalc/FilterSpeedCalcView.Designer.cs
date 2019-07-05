namespace FlowCalc
{
    partial class FilterSpeedCalcView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FilterDiameter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_FlowVelocityUnit = new System.Windows.Forms.ComboBox();
            this.cmb_FlowRateUnit = new System.Windows.Forms.ComboBox();
            this.txt_FlowVelocity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Clac = new System.Windows.Forms.Button();
            this.txt_FlowRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_FilterSpeedInfo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_FilterDiameter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filterkessel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "mm";
            // 
            // txt_FilterDiameter
            // 
            this.txt_FilterDiameter.Location = new System.Drawing.Point(163, 30);
            this.txt_FilterDiameter.Name = "txt_FilterDiameter";
            this.txt_FilterDiameter.Size = new System.Drawing.Size(85, 20);
            this.txt_FilterDiameter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Durchmesser";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_FlowRateUnit);
            this.groupBox2.Controls.Add(this.btn_Clac);
            this.groupBox2.Controls.Add(this.txt_FlowRate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Berechnung";
            // 
            // cmb_FlowVelocityUnit
            // 
            this.cmb_FlowVelocityUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FlowVelocityUnit.FormattingEnabled = true;
            this.cmb_FlowVelocityUnit.Location = new System.Drawing.Point(254, 31);
            this.cmb_FlowVelocityUnit.Name = "cmb_FlowVelocityUnit";
            this.cmb_FlowVelocityUnit.Size = new System.Drawing.Size(54, 21);
            this.cmb_FlowVelocityUnit.TabIndex = 21;
            this.cmb_FlowVelocityUnit.SelectedIndexChanged += new System.EventHandler(this.cmb_FlowVelocityUnit_SelectedIndexChanged);
            // 
            // cmb_FlowRateUnit
            // 
            this.cmb_FlowRateUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FlowRateUnit.FormattingEnabled = true;
            this.cmb_FlowRateUnit.Location = new System.Drawing.Point(254, 32);
            this.cmb_FlowRateUnit.Name = "cmb_FlowRateUnit";
            this.cmb_FlowRateUnit.Size = new System.Drawing.Size(54, 21);
            this.cmb_FlowRateUnit.TabIndex = 20;
            this.cmb_FlowRateUnit.SelectedIndexChanged += new System.EventHandler(this.cmb_FlowRateUnit_SelectedIndexChanged);
            // 
            // txt_FlowVelocity
            // 
            this.txt_FlowVelocity.Location = new System.Drawing.Point(163, 31);
            this.txt_FlowVelocity.Name = "txt_FlowVelocity";
            this.txt_FlowVelocity.Size = new System.Drawing.Size(85, 20);
            this.txt_FlowVelocity.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Filtergeschwindigkeit";
            // 
            // btn_Clac
            // 
            this.btn_Clac.Location = new System.Drawing.Point(22, 73);
            this.btn_Clac.Name = "btn_Clac";
            this.btn_Clac.Size = new System.Drawing.Size(286, 33);
            this.btn_Clac.TabIndex = 0;
            this.btn_Clac.Text = "Berechnen";
            this.btn_Clac.UseVisualStyleBackColor = true;
            this.btn_Clac.Click += new System.EventHandler(this.btn_Clac_Click);
            // 
            // txt_FlowRate
            // 
            this.txt_FlowRate.Location = new System.Drawing.Point(163, 33);
            this.txt_FlowRate.Name = "txt_FlowRate";
            this.txt_FlowRate.Size = new System.Drawing.Size(85, 20);
            this.txt_FlowRate.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Volumenstrom";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_FilterSpeedInfo);
            this.groupBox3.Controls.Add(this.cmb_FlowVelocityUnit);
            this.groupBox3.Controls.Add(this.txt_FlowVelocity);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(12, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 218);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ergebnis";
            // 
            // txt_FilterSpeedInfo
            // 
            this.txt_FilterSpeedInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txt_FilterSpeedInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FilterSpeedInfo.Location = new System.Drawing.Point(22, 67);
            this.txt_FilterSpeedInfo.Multiline = true;
            this.txt_FilterSpeedInfo.Name = "txt_FilterSpeedInfo";
            this.txt_FilterSpeedInfo.Size = new System.Drawing.Size(286, 134);
            this.txt_FilterSpeedInfo.TabIndex = 22;
            // 
            // FilterSpeedCalcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(369, 500);
            this.MinimumSize = new System.Drawing.Size(369, 500);
            this.Name = "FilterSpeedCalcView";
            this.Text = "PipeCalcView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FilterDiameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_FlowVelocityUnit;
        private System.Windows.Forms.ComboBox cmb_FlowRateUnit;
        private System.Windows.Forms.TextBox txt_FlowVelocity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Clac;
        private System.Windows.Forms.TextBox txt_FlowRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_FilterSpeedInfo;
    }
}