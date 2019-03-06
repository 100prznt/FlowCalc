namespace FlowCalc
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_LoadPump = new System.Windows.Forms.Button();
            this.txt_PumpModel = new System.Windows.Forms.TextBox();
            this.txt_SystemPressure = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PumpNominalHead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PumpNominalFlowRate = new System.Windows.Forms.TextBox();
            this.txt_PumpPowerOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PumpManufracturer = new System.Windows.Forms.TextBox();
            this.btn_CalcFlowRate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SystemFlowRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SystemHead = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PumpMaxHead = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_PumpFileAuthor = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LoadPump
            // 
            this.btn_LoadPump.Location = new System.Drawing.Point(22, 225);
            this.btn_LoadPump.Name = "btn_LoadPump";
            this.btn_LoadPump.Size = new System.Drawing.Size(354, 23);
            this.btn_LoadPump.TabIndex = 98;
            this.btn_LoadPump.Text = "Lade Pumpendefinition...";
            this.btn_LoadPump.UseVisualStyleBackColor = true;
            this.btn_LoadPump.Click += new System.EventHandler(this.btn_LoadPump_Click);
            // 
            // txt_PumpModel
            // 
            this.txt_PumpModel.Enabled = false;
            this.txt_PumpModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PumpModel.Location = new System.Drawing.Point(133, 34);
            this.txt_PumpModel.Name = "txt_PumpModel";
            this.txt_PumpModel.Size = new System.Drawing.Size(243, 20);
            this.txt_PumpModel.TabIndex = 99;
            // 
            // txt_SystemPressure
            // 
            this.txt_SystemPressure.Location = new System.Drawing.Point(144, 34);
            this.txt_SystemPressure.Name = "txt_SystemPressure";
            this.txt_SystemPressure.Size = new System.Drawing.Size(75, 20);
            this.txt_SystemPressure.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Pumpendefinition|*.xml";
            this.openFileDialog1.Title = "Lade Pumpendefinition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modell";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_PumpFileAuthor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_PumpMaxHead);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_PumpNominalHead);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_PumpNominalFlowRate);
            this.groupBox1.Controls.Add(this.txt_PumpPowerOut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_PumpManufracturer);
            this.groupBox1.Controls.Add(this.btn_LoadPump);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_PumpModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 269);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pumpe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nenn-Förderhöhe";
            // 
            // txt_PumpNominalHead
            // 
            this.txt_PumpNominalHead.Enabled = false;
            this.txt_PumpNominalHead.Location = new System.Drawing.Point(133, 138);
            this.txt_PumpNominalHead.Name = "txt_PumpNominalHead";
            this.txt_PumpNominalHead.Size = new System.Drawing.Size(243, 20);
            this.txt_PumpNominalHead.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Abgabeleistung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nenn-Fördermenge";
            // 
            // txt_PumpNominalFlowRate
            // 
            this.txt_PumpNominalFlowRate.Enabled = false;
            this.txt_PumpNominalFlowRate.Location = new System.Drawing.Point(133, 112);
            this.txt_PumpNominalFlowRate.Name = "txt_PumpNominalFlowRate";
            this.txt_PumpNominalFlowRate.Size = new System.Drawing.Size(243, 20);
            this.txt_PumpNominalFlowRate.TabIndex = 8;
            // 
            // txt_PumpPowerOut
            // 
            this.txt_PumpPowerOut.Enabled = false;
            this.txt_PumpPowerOut.Location = new System.Drawing.Point(133, 86);
            this.txt_PumpPowerOut.Name = "txt_PumpPowerOut";
            this.txt_PumpPowerOut.Size = new System.Drawing.Size(243, 20);
            this.txt_PumpPowerOut.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hersteller";
            // 
            // txt_PumpManufracturer
            // 
            this.txt_PumpManufracturer.Enabled = false;
            this.txt_PumpManufracturer.Location = new System.Drawing.Point(133, 60);
            this.txt_PumpManufracturer.Name = "txt_PumpManufracturer";
            this.txt_PumpManufracturer.Size = new System.Drawing.Size(243, 20);
            this.txt_PumpManufracturer.TabIndex = 4;
            // 
            // btn_CalcFlowRate
            // 
            this.btn_CalcFlowRate.Location = new System.Drawing.Point(25, 63);
            this.btn_CalcFlowRate.Name = "btn_CalcFlowRate";
            this.btn_CalcFlowRate.Size = new System.Drawing.Size(219, 39);
            this.btn_CalcFlowRate.TabIndex = 5;
            this.btn_CalcFlowRate.Text = "Berechne Fördermenge";
            this.btn_CalcFlowRate.UseVisualStyleBackColor = true;
            this.btn_CalcFlowRate.Click += new System.EventHandler(this.btn_CalcFlowRate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Systemdruck";
            // 
            // txt_SystemFlowRate
            // 
            this.txt_SystemFlowRate.Enabled = false;
            this.txt_SystemFlowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SystemFlowRate.Location = new System.Drawing.Point(144, 141);
            this.txt_SystemFlowRate.Name = "txt_SystemFlowRate";
            this.txt_SystemFlowRate.Size = new System.Drawing.Size(100, 20);
            this.txt_SystemFlowRate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fördermenge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Höhe der Wassersäule";
            // 
            // txt_SystemHead
            // 
            this.txt_SystemHead.Enabled = false;
            this.txt_SystemHead.Location = new System.Drawing.Point(144, 115);
            this.txt_SystemHead.Name = "txt_SystemHead";
            this.txt_SystemHead.Size = new System.Drawing.Size(100, 20);
            this.txt_SystemHead.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Maximale Förderhöhe";
            // 
            // txt_PumpMaxHead
            // 
            this.txt_PumpMaxHead.Enabled = false;
            this.txt_PumpMaxHead.Location = new System.Drawing.Point(133, 164);
            this.txt_PumpMaxHead.Name = "txt_PumpMaxHead";
            this.txt_PumpMaxHead.Size = new System.Drawing.Size(243, 20);
            this.txt_PumpMaxHead.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_SystemPressure);
            this.groupBox2.Controls.Add(this.txt_SystemHead);
            this.groupBox2.Controls.Add(this.btn_CalcFlowRate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_SystemFlowRate);
            this.groupBox2.Location = new System.Drawing.Point(434, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 269);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Autor:";
            // 
            // lbl_PumpFileAuthor
            // 
            this.lbl_PumpFileAuthor.Location = new System.Drawing.Point(133, 197);
            this.lbl_PumpFileAuthor.Name = "lbl_PumpFileAuthor";
            this.lbl_PumpFileAuthor.Size = new System.Drawing.Size(243, 23);
            this.lbl_PumpFileAuthor.TabIndex = 17;
            this.lbl_PumpFileAuthor.TabStop = true;
            this.lbl_PumpFileAuthor.Text = "PumpFileAuthor";
            this.lbl_PumpFileAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_PumpFileAuthor_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "bar";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_CalcFlowRate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FlowCalc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadPump;
        private System.Windows.Forms.TextBox txt_PumpModel;
        private System.Windows.Forms.TextBox txt_SystemPressure;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PumpNominalHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PumpNominalFlowRate;
        private System.Windows.Forms.TextBox txt_PumpPowerOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PumpManufracturer;
        private System.Windows.Forms.Button btn_CalcFlowRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SystemFlowRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SystemHead;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_PumpMaxHead;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lbl_PumpFileAuthor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label11;
    }
}

