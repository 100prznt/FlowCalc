namespace FlowCalc
{
    partial class CirculationCalcView
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
            this.cmb_VolumeUnit = new System.Windows.Forms.ComboBox();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_FlowRateUnit = new System.Windows.Forms.ComboBox();
            this.txt_FlowRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Clac = new System.Windows.Forms.Button();
            this.cmb_RunTimeUnit = new System.Windows.Forms.ComboBox();
            this.txt_RunTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_VolumeUnit);
            this.groupBox1.Controls.Add(this.txt_Volume);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 68);
            this.groupBox1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wasserinhalt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_FlowRateUnit);
            this.groupBox2.Controls.Add(this.txt_FlowRate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filteranlage";
            // 
            // cmb_FlowRateUnit
            // 
            this.cmb_FlowRateUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FlowRateUnit.FormattingEnabled = true;
            this.cmb_FlowRateUnit.Location = new System.Drawing.Point(254, 35);
            this.cmb_FlowRateUnit.Name = "cmb_FlowRateUnit";
            this.cmb_FlowRateUnit.Size = new System.Drawing.Size(54, 21);
            this.cmb_FlowRateUnit.TabIndex = 20;
            this.cmb_FlowRateUnit.SelectedIndexChanged += new System.EventHandler(this.cmb_FlowRateUnit_SelectedIndexChanged);
            // 
            // txt_FlowRate
            // 
            this.txt_FlowRate.Location = new System.Drawing.Point(163, 36);
            this.txt_FlowRate.Name = "txt_FlowRate";
            this.txt_FlowRate.Size = new System.Drawing.Size(85, 20);
            this.txt_FlowRate.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Volumenstrom";
            // 
            // btn_Clac
            // 
            this.btn_Clac.Location = new System.Drawing.Point(34, 208);
            this.btn_Clac.Name = "btn_Clac";
            this.btn_Clac.Size = new System.Drawing.Size(286, 33);
            this.btn_Clac.TabIndex = 0;
            this.btn_Clac.Text = "Berechnen";
            this.btn_Clac.UseVisualStyleBackColor = true;
            this.btn_Clac.Click += new System.EventHandler(this.btn_Clac_Click);
            // 
            // cmb_RunTimeUnit
            // 
            this.cmb_RunTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RunTimeUnit.FormattingEnabled = true;
            this.cmb_RunTimeUnit.Location = new System.Drawing.Point(254, 31);
            this.cmb_RunTimeUnit.Name = "cmb_RunTimeUnit";
            this.cmb_RunTimeUnit.Size = new System.Drawing.Size(54, 21);
            this.cmb_RunTimeUnit.TabIndex = 24;
            this.cmb_RunTimeUnit.SelectedIndexChanged += new System.EventHandler(this.cmb_RunTimeUnit_SelectedIndexChanged);
            // 
            // txt_RunTime
            // 
            this.txt_RunTime.Location = new System.Drawing.Point(163, 31);
            this.txt_RunTime.Name = "txt_RunTime";
            this.txt_RunTime.Size = new System.Drawing.Size(85, 20);
            this.txt_RunTime.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Laufzeit";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmb_RunTimeUnit);
            this.groupBox3.Controls.Add(this.txt_RunTime);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ergebnis";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 50);
            this.label2.TabIndex = 25;
            this.label2.Text = "Pumpenlaufzeit um den angegebenen Wasserinhalt einmal umzuwälzen.";
            // 
            // CirculationCalcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 411);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Clac);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(369, 500);
            this.MinimumSize = new System.Drawing.Size(369, 450);
            this.Name = "CirculationCalcView";
            this.Text = "CirculationCalcView";
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
        private System.Windows.Forms.TextBox txt_Volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_FlowRateUnit;
        private System.Windows.Forms.Button btn_Clac;
        private System.Windows.Forms.TextBox txt_FlowRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_RunTimeUnit;
        private System.Windows.Forms.TextBox txt_RunTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_VolumeUnit;
        private System.Windows.Forms.Label label2;
    }
}