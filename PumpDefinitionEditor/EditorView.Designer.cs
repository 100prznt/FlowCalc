namespace PumpDefinitionEditor
{
    partial class EditorView
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_LoadPump = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.btn_SaveXml = new System.Windows.Forms.Button();
            this.btn_SaveJson = new System.Windows.Forms.Button();
            this.btn_SaveCsv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_NewPump = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Pumpendefinition|*.xml";
            // 
            // btn_LoadPump
            // 
            this.btn_LoadPump.Location = new System.Drawing.Point(242, 359);
            this.btn_LoadPump.Name = "btn_LoadPump";
            this.btn_LoadPump.Size = new System.Drawing.Size(211, 38);
            this.btn_LoadPump.TabIndex = 0;
            this.btn_LoadPump.Text = "Lade Pumpendefinition...";
            this.btn_LoadPump.UseVisualStyleBackColor = true;
            this.btn_LoadPump.Click += new System.EventHandler(this.btn_LoadPump_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(12, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(441, 333);
            this.propertyGrid1.TabIndex = 1;
            // 
            // btn_SaveXml
            // 
            this.btn_SaveXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveXml.Location = new System.Drawing.Point(17, 32);
            this.btn_SaveXml.Name = "btn_SaveXml";
            this.btn_SaveXml.Size = new System.Drawing.Size(130, 23);
            this.btn_SaveXml.TabIndex = 2;
            this.btn_SaveXml.Text = "XML";
            this.toolTip1.SetToolTip(this.btn_SaveXml, "Speichern im XML Format, Standard für FlowCalc");
            this.btn_SaveXml.UseVisualStyleBackColor = true;
            this.btn_SaveXml.Click += new System.EventHandler(this.btn_SaveXml_Click);
            // 
            // btn_SaveJson
            // 
            this.btn_SaveJson.Location = new System.Drawing.Point(153, 32);
            this.btn_SaveJson.Name = "btn_SaveJson";
            this.btn_SaveJson.Size = new System.Drawing.Size(130, 23);
            this.btn_SaveJson.TabIndex = 3;
            this.btn_SaveJson.Text = "JSON";
            this.toolTip1.SetToolTip(this.btn_SaveJson, "Speichern im JSON Format");
            this.btn_SaveJson.UseVisualStyleBackColor = true;
            this.btn_SaveJson.Click += new System.EventHandler(this.btn_SaveJson_Click);
            // 
            // btn_SaveCsv
            // 
            this.btn_SaveCsv.Location = new System.Drawing.Point(289, 32);
            this.btn_SaveCsv.Name = "btn_SaveCsv";
            this.btn_SaveCsv.Size = new System.Drawing.Size(130, 23);
            this.btn_SaveCsv.TabIndex = 4;
            this.btn_SaveCsv.Text = "CSV";
            this.toolTip1.SetToolTip(this.btn_SaveCsv, "Speichern im CSV Format");
            this.btn_SaveCsv.UseVisualStyleBackColor = true;
            this.btn_SaveCsv.Click += new System.EventHandler(this.btn_SaveCsv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SaveXml);
            this.groupBox1.Controls.Add(this.btn_SaveCsv);
            this.groupBox1.Controls.Add(this.btn_SaveJson);
            this.groupBox1.Location = new System.Drawing.Point(12, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speichern als";
            // 
            // btn_NewPump
            // 
            this.btn_NewPump.Location = new System.Drawing.Point(12, 359);
            this.btn_NewPump.Name = "btn_NewPump";
            this.btn_NewPump.Size = new System.Drawing.Size(211, 38);
            this.btn_NewPump.TabIndex = 6;
            this.btn_NewPump.Text = "Neue Pumpendefinition";
            this.btn_NewPump.UseVisualStyleBackColor = true;
            this.btn_NewPump.Click += new System.EventHandler(this.btn_NewPump_Click);
            // 
            // EditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 495);
            this.Controls.Add(this.btn_NewPump);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.btn_LoadPump);
            this.Name = "EditorView";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_LoadPump;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btn_SaveXml;
        private System.Windows.Forms.Button btn_SaveJson;
        private System.Windows.Forms.Button btn_SaveCsv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_NewPump;
    }
}

