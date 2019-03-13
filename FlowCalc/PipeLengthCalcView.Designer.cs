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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stl_FittingSearchDirectory = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_System = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_TotalPipeLength = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PipeLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PipeDiameter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddPipe = new System.Windows.Forms.Button();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Diameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_System)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_FittingButtons
            // 
            this.box_FittingButtons.Location = new System.Drawing.Point(430, 212);
            this.box_FittingButtons.Name = "box_FittingButtons";
            this.box_FittingButtons.Size = new System.Drawing.Size(217, 331);
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
            this.groupBox1.Location = new System.Drawing.Point(430, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nenndurchmesser";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stl_FittingSearchDirectory});
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(659, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stl_FittingSearchDirectory
            // 
            this.stl_FittingSearchDirectory.Name = "stl_FittingSearchDirectory";
            this.stl_FittingSearchDirectory.Size = new System.Drawing.Size(118, 17);
            this.stl_FittingSearchDirectory.Text = "toolStripStatusLabel1";
            // 
            // dgv_System
            // 
            this.dgv_System.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_System.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Name,
            this.col_Diameter,
            this.col_Amount,
            this.col_Length});
            this.dgv_System.Location = new System.Drawing.Point(12, 12);
            this.dgv_System.Name = "dgv_System";
            this.dgv_System.Size = new System.Drawing.Size(402, 488);
            this.dgv_System.TabIndex = 4;
            this.dgv_System.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_System_CellEndEdit);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(12, 516);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(119, 26);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Zurücksetzen";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_TotalPipeLength
            // 
            this.txt_TotalPipeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalPipeLength.Location = new System.Drawing.Point(314, 516);
            this.txt_TotalPipeLength.Name = "txt_TotalPipeLength";
            this.txt_TotalPipeLength.Size = new System.Drawing.Size(100, 26);
            this.txt_TotalPipeLength.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_PipeDiameter);
            this.groupBox2.Controls.Add(this.btn_AddPipe);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_PipeLength);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(430, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 125);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rohrstück";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Länge";
            // 
            // txt_PipeLength
            // 
            this.txt_PipeLength.Location = new System.Drawing.Point(114, 28);
            this.txt_PipeLength.Name = "txt_PipeLength";
            this.txt_PipeLength.Size = new System.Drawing.Size(61, 20);
            this.txt_PipeLength.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "mm";
            // 
            // txt_PipeDiameter
            // 
            this.txt_PipeDiameter.Enabled = false;
            this.txt_PipeDiameter.Location = new System.Drawing.Point(114, 54);
            this.txt_PipeDiameter.Name = "txt_PipeDiameter";
            this.txt_PipeDiameter.Size = new System.Drawing.Size(61, 20);
            this.txt_PipeDiameter.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Innendurchmesser";
            // 
            // btn_AddPipe
            // 
            this.btn_AddPipe.Location = new System.Drawing.Point(16, 86);
            this.btn_AddPipe.Name = "btn_AddPipe";
            this.btn_AddPipe.Size = new System.Drawing.Size(187, 23);
            this.btn_AddPipe.TabIndex = 6;
            this.btn_AddPipe.Text = "Hinzufügen";
            this.btn_AddPipe.UseVisualStyleBackColor = true;
            this.btn_AddPipe.Click += new System.EventHandler(this.btn_AddPipe_Click);
            // 
            // col_Name
            // 
            this.col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Name.DataPropertyName = "DisplayName";
            this.col_Name.HeaderText = "Bezeichnung";
            this.col_Name.Name = "col_Name";
            // 
            // col_Diameter
            // 
            this.col_Diameter.DataPropertyName = "Diameter";
            this.col_Diameter.FillWeight = 75F;
            this.col_Diameter.HeaderText = "Durchmesser";
            this.col_Diameter.Name = "col_Diameter";
            this.col_Diameter.Width = 75;
            // 
            // col_Amount
            // 
            this.col_Amount.DataPropertyName = "Amount";
            this.col_Amount.FillWeight = 50F;
            this.col_Amount.HeaderText = "Anzahl";
            this.col_Amount.Name = "col_Amount";
            this.col_Amount.Width = 50;
            // 
            // col_Length
            // 
            this.col_Length.DataPropertyName = "Length";
            this.col_Length.FillWeight = 50F;
            this.col_Length.HeaderText = "Länge";
            this.col_Length.Name = "col_Length";
            this.col_Length.Width = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Äquivalente Gesamtlänge";
            // 
            // PipeLengthCalcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 581);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_TotalPipeLength);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dgv_System);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.box_FittingButtons);
            this.Name = "PipeLengthCalcView";
            this.Text = "PipeLengthCalcView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_System)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox box_FittingButtons;
        private System.Windows.Forms.RadioButton rbtn_Dn50;
        private System.Windows.Forms.RadioButton rbtn_Dn40;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stl_FittingSearchDirectory;
        private System.Windows.Forms.DataGridView dgv_System;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_TotalPipeLength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_PipeDiameter;
        private System.Windows.Forms.Button btn_AddPipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PipeLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Diameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Length;
        private System.Windows.Forms.Label label5;
    }
}