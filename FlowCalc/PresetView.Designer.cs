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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Roughness = new System.Windows.Forms.TextBox();
            this.txt_MetresAboveSeaLevel = new System.Windows.Forms.TextBox();
            this.cbx_Medium = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_EnableUserName = new System.Windows.Forms.CheckBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rohrrauheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medium";
            // 
            // txt_Roughness
            // 
            this.txt_Roughness.Location = new System.Drawing.Point(193, 204);
            this.txt_Roughness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Roughness.Name = "txt_Roughness";
            this.txt_Roughness.Size = new System.Drawing.Size(90, 26);
            this.txt_Roughness.TabIndex = 3;
            // 
            // txt_MetresAboveSeaLevel
            // 
            this.txt_MetresAboveSeaLevel.Location = new System.Drawing.Point(193, 164);
            this.txt_MetresAboveSeaLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MetresAboveSeaLevel.Name = "txt_MetresAboveSeaLevel";
            this.txt_MetresAboveSeaLevel.Size = new System.Drawing.Size(90, 26);
            this.txt_MetresAboveSeaLevel.TabIndex = 4;
            // 
            // cbx_Medium
            // 
            this.cbx_Medium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Medium.FormattingEnabled = true;
            this.cbx_Medium.Location = new System.Drawing.Point(193, 122);
            this.cbx_Medium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Medium.Name = "cbx_Medium";
            this.cbx_Medium.Size = new System.Drawing.Size(148, 28);
            this.cbx_Medium.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Höhe über NN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_EnableUserName);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbx_Medium);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Roughness);
            this.groupBox1.Controls.Add(this.txt_MetresAboveSeaLevel);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(670, 262);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voreinstellungen";
            // 
            // cbx_EnableUserName
            // 
            this.cbx_EnableUserName.AutoSize = true;
            this.cbx_EnableUserName.Checked = true;
            this.cbx_EnableUserName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_EnableUserName.Location = new System.Drawing.Point(559, 81);
            this.cbx_EnableUserName.Name = "cbx_EnableUserName";
            this.cbx_EnableUserName.Size = new System.Drawing.Size(69, 24);
            this.cbx_EnableUserName.TabIndex = 12;
            this.cbx_EnableUserName.Text = "Aktiv";
            this.cbx_EnableUserName.UseVisualStyleBackColor = true;
            this.cbx_EnableUserName.CheckedChanged += new System.EventHandler(this.cbx_EnableUserName_CheckedChanged);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(193, 79);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(337, 26);
            this.txt_UserName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Benutzername";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(320, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Wert geht akt. nicht in die Berechnung ein!";
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(537, 309);
            this.btn_Apply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(154, 35);
            this.btn_Apply.TabIndex = 10;
            this.btn_Apply.Text = "Übernehmen";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(375, 309);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(154, 35);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Abbrechen";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // PresetView
            // 
            this.AcceptButton = this.btn_Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(714, 370);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(736, 362);
            this.Name = "PresetView";
            this.Text = "PresetView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Roughness;
        private System.Windows.Forms.TextBox txt_MetresAboveSeaLevel;
        private System.Windows.Forms.ComboBox cbx_Medium;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbx_EnableUserName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label7;
    }
}