namespace FlowCalc
{
    partial class PipeLengthCalcView
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
            this.box_FittingButtons = new System.Windows.Forms.GroupBox();
            this.rbtn_Dn40 = new System.Windows.Forms.RadioButton();
            this.rbtn_Dn50 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_FittingButtons
            // 
            this.box_FittingButtons.Location = new System.Drawing.Point(403, 180);
            this.box_FittingButtons.Name = "box_FittingButtons";
            this.box_FittingButtons.Size = new System.Drawing.Size(202, 360);
            this.box_FittingButtons.TabIndex = 1;
            this.box_FittingButtons.TabStop = false;
            this.box_FittingButtons.Text = "Verfügbare Fittings und Armaturen";
            // 
            // rbtn_Dn40
            // 
            this.rbtn_Dn40.AutoSize = true;
            this.rbtn_Dn40.Checked = true;
            this.rbtn_Dn40.Location = new System.Drawing.Point(24, 27);
            this.rbtn_Dn40.Name = "rbtn_Dn40";
            this.rbtn_Dn40.Size = new System.Drawing.Size(53, 17);
            this.rbtn_Dn40.TabIndex = 0;
            this.rbtn_Dn40.TabStop = true;
            this.rbtn_Dn40.Text = "DN40";
            this.rbtn_Dn40.UseVisualStyleBackColor = true;
            this.rbtn_Dn40.CheckedChanged += new System.EventHandler(this.rbtn_Dn_CheckedChanged);
            // 
            // rbtn_Dn50
            // 
            this.rbtn_Dn50.AutoSize = true;
            this.rbtn_Dn50.Location = new System.Drawing.Point(114, 27);
            this.rbtn_Dn50.Name = "rbtn_Dn50";
            this.rbtn_Dn50.Size = new System.Drawing.Size(53, 17);
            this.rbtn_Dn50.TabIndex = 1;
            this.rbtn_Dn50.Text = "DN50";
            this.rbtn_Dn50.UseVisualStyleBackColor = true;
            this.rbtn_Dn50.CheckedChanged += new System.EventHandler(this.rbtn_Dn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_Dn50);
            this.groupBox1.Controls.Add(this.rbtn_Dn40);
            this.groupBox1.Location = new System.Drawing.Point(403, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nenndurchmesser";
            // 
            // PipeLengthCalcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.box_FittingButtons);
            this.Name = "PipeLengthCalcView";
            this.Text = "PipeLengthCalcView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox box_FittingButtons;
        private System.Windows.Forms.RadioButton rbtn_Dn50;
        private System.Windows.Forms.RadioButton rbtn_Dn40;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}