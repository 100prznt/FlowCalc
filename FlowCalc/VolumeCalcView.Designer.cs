namespace FlowCalc
{
    partial class VolumeCalcView
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
            this.rb_Eight = new System.Windows.Forms.RadioButton();
            this.rb_Round = new System.Windows.Forms.RadioButton();
            this.rb_Oval = new System.Windows.Forms.RadioButton();
            this.rb_Square = new System.Windows.Forms.RadioButton();
            this.lbl_DimDepthUnit = new System.Windows.Forms.Label();
            this.txt_DimDepth = new System.Windows.Forms.TextBox();
            this.lbl_DimDepth = new System.Windows.Forms.Label();
            this.lbl_DimBUnit = new System.Windows.Forms.Label();
            this.txt_DimB = new System.Windows.Forms.TextBox();
            this.lbl_DimB = new System.Windows.Forms.Label();
            this.lbl_DimAUnit = new System.Windows.Forms.Label();
            this.txt_DimA = new System.Windows.Forms.TextBox();
            this.lbl_DimA = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_LevelUnit = new System.Windows.Forms.ComboBox();
            this.btn_Clac = new System.Windows.Forms.Button();
            this.txt_Level = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_VolumeUnit = new System.Windows.Forms.ComboBox();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Eight);
            this.groupBox1.Controls.Add(this.rb_Round);
            this.groupBox1.Controls.Add(this.rb_Oval);
            this.groupBox1.Controls.Add(this.rb_Square);
            this.groupBox1.Controls.Add(this.lbl_DimDepthUnit);
            this.groupBox1.Controls.Add(this.txt_DimDepth);
            this.groupBox1.Controls.Add(this.lbl_DimDepth);
            this.groupBox1.Controls.Add(this.lbl_DimBUnit);
            this.groupBox1.Controls.Add(this.txt_DimB);
            this.groupBox1.Controls.Add(this.lbl_DimB);
            this.groupBox1.Controls.Add(this.lbl_DimAUnit);
            this.groupBox1.Controls.Add(this.txt_DimA);
            this.groupBox1.Controls.Add(this.lbl_DimA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pool";
            // 
            // rb_Eight
            // 
            this.rb_Eight.AutoSize = true;
            this.rb_Eight.Location = new System.Drawing.Point(240, 19);
            this.rb_Eight.Name = "rb_Eight";
            this.rb_Eight.Size = new System.Drawing.Size(67, 17);
            this.rb_Eight.TabIndex = 12;
            this.rb_Eight.TabStop = true;
            this.rb_Eight.Text = "Achtform";
            this.rb_Eight.UseVisualStyleBackColor = true;
            this.rb_Eight.CheckedChanged += new System.EventHandler(this.rb_Shape_CheckedChanged);
            // 
            // rb_Round
            // 
            this.rb_Round.AutoSize = true;
            this.rb_Round.Location = new System.Drawing.Point(110, 20);
            this.rb_Round.Name = "rb_Round";
            this.rb_Round.Size = new System.Drawing.Size(51, 17);
            this.rb_Round.TabIndex = 11;
            this.rb_Round.TabStop = true;
            this.rb_Round.Text = "Rund";
            this.rb_Round.UseVisualStyleBackColor = true;
            this.rb_Round.CheckedChanged += new System.EventHandler(this.rb_Shape_CheckedChanged);
            // 
            // rb_Oval
            // 
            this.rb_Oval.AutoSize = true;
            this.rb_Oval.Location = new System.Drawing.Point(177, 19);
            this.rb_Oval.Name = "rb_Oval";
            this.rb_Oval.Size = new System.Drawing.Size(47, 17);
            this.rb_Oval.TabIndex = 10;
            this.rb_Oval.TabStop = true;
            this.rb_Oval.Text = "Oval";
            this.rb_Oval.UseVisualStyleBackColor = true;
            this.rb_Oval.CheckedChanged += new System.EventHandler(this.rb_Shape_CheckedChanged);
            // 
            // rb_Square
            // 
            this.rb_Square.AutoSize = true;
            this.rb_Square.Location = new System.Drawing.Point(22, 20);
            this.rb_Square.Name = "rb_Square";
            this.rb_Square.Size = new System.Drawing.Size(72, 17);
            this.rb_Square.TabIndex = 9;
            this.rb_Square.TabStop = true;
            this.rb_Square.Text = "Rechteck";
            this.rb_Square.UseVisualStyleBackColor = true;
            this.rb_Square.CheckedChanged += new System.EventHandler(this.rb_Shape_CheckedChanged);
            // 
            // lbl_DimDepthUnit
            // 
            this.lbl_DimDepthUnit.AutoSize = true;
            this.lbl_DimDepthUnit.Location = new System.Drawing.Point(254, 115);
            this.lbl_DimDepthUnit.Name = "lbl_DimDepthUnit";
            this.lbl_DimDepthUnit.Size = new System.Drawing.Size(15, 13);
            this.lbl_DimDepthUnit.TabIndex = 8;
            this.lbl_DimDepthUnit.Text = "m";
            // 
            // txt_DimDepth
            // 
            this.txt_DimDepth.Location = new System.Drawing.Point(163, 112);
            this.txt_DimDepth.Name = "txt_DimDepth";
            this.txt_DimDepth.Size = new System.Drawing.Size(85, 20);
            this.txt_DimDepth.TabIndex = 7;
            // 
            // lbl_DimDepth
            // 
            this.lbl_DimDepth.AutoSize = true;
            this.lbl_DimDepth.Location = new System.Drawing.Point(19, 115);
            this.lbl_DimDepth.Name = "lbl_DimDepth";
            this.lbl_DimDepth.Size = new System.Drawing.Size(31, 13);
            this.lbl_DimDepth.TabIndex = 6;
            this.lbl_DimDepth.Text = "Tiefe";
            // 
            // lbl_DimBUnit
            // 
            this.lbl_DimBUnit.AutoSize = true;
            this.lbl_DimBUnit.Location = new System.Drawing.Point(254, 89);
            this.lbl_DimBUnit.Name = "lbl_DimBUnit";
            this.lbl_DimBUnit.Size = new System.Drawing.Size(15, 13);
            this.lbl_DimBUnit.TabIndex = 5;
            this.lbl_DimBUnit.Text = "m";
            // 
            // txt_DimB
            // 
            this.txt_DimB.Location = new System.Drawing.Point(163, 86);
            this.txt_DimB.Name = "txt_DimB";
            this.txt_DimB.Size = new System.Drawing.Size(85, 20);
            this.txt_DimB.TabIndex = 4;
            // 
            // lbl_DimB
            // 
            this.lbl_DimB.AutoSize = true;
            this.lbl_DimB.Location = new System.Drawing.Point(19, 89);
            this.lbl_DimB.Name = "lbl_DimB";
            this.lbl_DimB.Size = new System.Drawing.Size(34, 13);
            this.lbl_DimB.TabIndex = 3;
            this.lbl_DimB.Text = "Breite";
            // 
            // lbl_DimAUnit
            // 
            this.lbl_DimAUnit.AutoSize = true;
            this.lbl_DimAUnit.Location = new System.Drawing.Point(254, 63);
            this.lbl_DimAUnit.Name = "lbl_DimAUnit";
            this.lbl_DimAUnit.Size = new System.Drawing.Size(15, 13);
            this.lbl_DimAUnit.TabIndex = 2;
            this.lbl_DimAUnit.Text = "m";
            // 
            // txt_DimA
            // 
            this.txt_DimA.Location = new System.Drawing.Point(163, 60);
            this.txt_DimA.Name = "txt_DimA";
            this.txt_DimA.Size = new System.Drawing.Size(85, 20);
            this.txt_DimA.TabIndex = 1;
            // 
            // lbl_DimA
            // 
            this.lbl_DimA.AutoSize = true;
            this.lbl_DimA.Location = new System.Drawing.Point(19, 63);
            this.lbl_DimA.Name = "lbl_DimA";
            this.lbl_DimA.Size = new System.Drawing.Size(37, 13);
            this.lbl_DimA.TabIndex = 0;
            this.lbl_DimA.Text = "Länge";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_LevelUnit);
            this.groupBox2.Controls.Add(this.btn_Clac);
            this.groupBox2.Controls.Add(this.txt_Level);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Berechnung";
            // 
            // cmb_LevelUnit
            // 
            this.cmb_LevelUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LevelUnit.FormattingEnabled = true;
            this.cmb_LevelUnit.Location = new System.Drawing.Point(254, 37);
            this.cmb_LevelUnit.Name = "cmb_LevelUnit";
            this.cmb_LevelUnit.Size = new System.Drawing.Size(54, 21);
            this.cmb_LevelUnit.TabIndex = 20;
            this.cmb_LevelUnit.SelectedIndexChanged += new System.EventHandler(this.cmb_FillLevelUnit_SelectedIndexChanged);
            // 
            // btn_Clac
            // 
            this.btn_Clac.Location = new System.Drawing.Point(22, 87);
            this.btn_Clac.Name = "btn_Clac";
            this.btn_Clac.Size = new System.Drawing.Size(286, 33);
            this.btn_Clac.TabIndex = 0;
            this.btn_Clac.Text = "Berechnen";
            this.btn_Clac.UseVisualStyleBackColor = true;
            this.btn_Clac.Click += new System.EventHandler(this.btn_Clac_Click);
            // 
            // txt_Level
            // 
            this.txt_Level.Location = new System.Drawing.Point(163, 37);
            this.txt_Level.Name = "txt_Level";
            this.txt_Level.Size = new System.Drawing.Size(85, 20);
            this.txt_Level.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Füllhöhe";
            // 
            // cmb_VolumeUnit
            // 
            this.cmb_VolumeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_VolumeUnit.FormattingEnabled = true;
            this.cmb_VolumeUnit.Location = new System.Drawing.Point(254, 31);
            this.cmb_VolumeUnit.Name = "cmb_VolumeUnit";
            this.cmb_VolumeUnit.Size = new System.Drawing.Size(54, 21);
            this.cmb_VolumeUnit.TabIndex = 24;
            this.cmb_VolumeUnit.SelectedIndexChanged += new System.EventHandler(this.cmb_VolumenUnit_SelectedIndexChanged);
            // 
            // txt_Volume
            // 
            this.txt_Volume.Location = new System.Drawing.Point(163, 31);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(85, 20);
            this.txt_Volume.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Volumen";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_VolumeUnit);
            this.groupBox3.Controls.Add(this.txt_Volume);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ergebnis";
            // 
            // VolumeCalcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 411);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(369, 500);
            this.MinimumSize = new System.Drawing.Size(369, 450);
            this.Name = "VolumeCalcView";
            this.Text = "VolumeCalcView";
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
        private System.Windows.Forms.Label lbl_DimDepthUnit;
        private System.Windows.Forms.TextBox txt_DimDepth;
        private System.Windows.Forms.Label lbl_DimDepth;
        private System.Windows.Forms.Label lbl_DimBUnit;
        private System.Windows.Forms.TextBox txt_DimB;
        private System.Windows.Forms.Label lbl_DimB;
        private System.Windows.Forms.Label lbl_DimAUnit;
        private System.Windows.Forms.TextBox txt_DimA;
        private System.Windows.Forms.Label lbl_DimA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_LevelUnit;
        private System.Windows.Forms.Button btn_Clac;
        private System.Windows.Forms.TextBox txt_Level;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_VolumeUnit;
        private System.Windows.Forms.TextBox txt_Volume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_Eight;
        private System.Windows.Forms.RadioButton rb_Round;
        private System.Windows.Forms.RadioButton rb_Oval;
        private System.Windows.Forms.RadioButton rb_Square;
    }
}