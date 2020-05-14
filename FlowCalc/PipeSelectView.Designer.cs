namespace FlowCalc
{
    partial class PipeSelectView
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_PoolPipe = new System.Windows.Forms.RadioButton();
            this.rb_PvcFlex = new System.Windows.Forms.RadioButton();
            this.rb_PvcPipe = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_NominalDiameter = new System.Windows.Forms.ComboBox();
            this.cbx_NominalPressure = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_InnerDiameter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_PoolPipe);
            this.groupBox1.Controls.Add(this.rb_PvcFlex);
            this.groupBox1.Controls.Add(this.rb_PvcPipe);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(489, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vorauswahl";
            // 
            // rb_PoolPipe
            // 
            this.rb_PoolPipe.AutoSize = true;
            this.rb_PoolPipe.Location = new System.Drawing.Point(33, 111);
            this.rb_PoolPipe.Name = "rb_PoolPipe";
            this.rb_PoolPipe.Size = new System.Drawing.Size(128, 24);
            this.rb_PoolPipe.TabIndex = 4;
            this.rb_PoolPipe.TabStop = true;
            this.rb_PoolPipe.Text = "Poolschlauch";
            this.toolTip1.SetToolTip(this.rb_PoolPipe, "Poolschlauch wie er oft zum Anschluss von Aufstellbecken genutzt wird.");
            this.rb_PoolPipe.UseVisualStyleBackColor = true;
            this.rb_PoolPipe.CheckedChanged += new System.EventHandler(this.PipeType_CheckedChanged);
            // 
            // rb_PvcFlex
            // 
            this.rb_PvcFlex.AutoSize = true;
            this.rb_PvcFlex.Location = new System.Drawing.Point(33, 81);
            this.rb_PvcFlex.Name = "rb_PvcFlex";
            this.rb_PvcFlex.Size = new System.Drawing.Size(162, 24);
            this.rb_PvcFlex.TabIndex = 3;
            this.rb_PvcFlex.TabStop = true;
            this.rb_PvcFlex.Text = "PVC Flexschlauch";
            this.rb_PvcFlex.UseVisualStyleBackColor = true;
            // 
            // rb_PvcPipe
            // 
            this.rb_PvcPipe.AutoSize = true;
            this.rb_PvcPipe.Location = new System.Drawing.Point(32, 51);
            this.rb_PvcPipe.Name = "rb_PvcPipe";
            this.rb_PvcPipe.Size = new System.Drawing.Size(105, 24);
            this.rb_PvcPipe.TabIndex = 2;
            this.rb_PvcPipe.TabStop = true;
            this.rb_PvcPipe.Text = "PVC Rohr";
            this.rb_PvcPipe.UseVisualStyleBackColor = true;
            this.rb_PvcPipe.CheckedChanged += new System.EventHandler(this.PipeType_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbx_NominalDiameter);
            this.groupBox2.Controls.Add(this.cbx_NominalPressure);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_InnerDiameter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(18, 215);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(489, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dimensionen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "mm";
            // 
            // cbx_NominalDiameter
            // 
            this.cbx_NominalDiameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_NominalDiameter.FormattingEnabled = true;
            this.cbx_NominalDiameter.Location = new System.Drawing.Point(244, 55);
            this.cbx_NominalDiameter.Name = "cbx_NominalDiameter";
            this.cbx_NominalDiameter.Size = new System.Drawing.Size(126, 28);
            this.cbx_NominalDiameter.TabIndex = 23;
            // 
            // cbx_NominalPressure
            // 
            this.cbx_NominalPressure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_NominalPressure.FormattingEnabled = true;
            this.cbx_NominalPressure.Location = new System.Drawing.Point(244, 91);
            this.cbx_NominalPressure.Name = "cbx_NominalPressure";
            this.cbx_NominalPressure.Size = new System.Drawing.Size(126, 28);
            this.cbx_NominalPressure.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 163);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 26);
            this.textBox2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rauheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Innendurchmesser";
            // 
            // txt_InnerDiameter
            // 
            this.txt_InnerDiameter.Location = new System.Drawing.Point(244, 127);
            this.txt_InnerDiameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InnerDiameter.Name = "txt_InnerDiameter";
            this.txt_InnerDiameter.Size = new System.Drawing.Size(126, 26);
            this.txt_InnerDiameter.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "mm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 94);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Nenndruck";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Durchmesser";
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(18, 470);
            this.btn_Apply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(489, 51);
            this.btn_Apply.TabIndex = 0;
            this.btn_Apply.Text = "Übernehmen";
            this.btn_Apply.UseVisualStyleBackColor = true;
            // 
            // PipeSelectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Apply);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "PipeSelectView";
            this.Text = "PipeSelectView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_PoolPipe;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rb_PvcFlex;
        private System.Windows.Forms.RadioButton rb_PvcPipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_NominalDiameter;
        private System.Windows.Forms.ComboBox cbx_NominalPressure;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_InnerDiameter;
    }
}