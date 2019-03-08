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
            this.btn_SaveMat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_LoadMat = new System.Windows.Forms.Button();
            this.btn_ShowPerformanceCurve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Pumpendefinition|*.xml";
            this.openFileDialog1.Title = "Pumpendefinition laden";
            // 
            // btn_LoadPump
            // 
            this.btn_LoadPump.Location = new System.Drawing.Point(166, 359);
            this.btn_LoadPump.Name = "btn_LoadPump";
            this.btn_LoadPump.Size = new System.Drawing.Size(143, 38);
            this.btn_LoadPump.TabIndex = 0;
            this.btn_LoadPump.Text = "Lade Pumpendefinition...";
            this.btn_LoadPump.UseVisualStyleBackColor = true;
            this.btn_LoadPump.Click += new System.EventHandler(this.btn_LoadPump_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(12, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(451, 333);
            this.propertyGrid1.TabIndex = 1;
            // 
            // btn_SaveXml
            // 
            this.btn_SaveXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveXml.Location = new System.Drawing.Point(11, 28);
            this.btn_SaveXml.Name = "btn_SaveXml";
            this.btn_SaveXml.Size = new System.Drawing.Size(76, 38);
            this.btn_SaveXml.TabIndex = 2;
            this.btn_SaveXml.Text = "XML";
            this.toolTip1.SetToolTip(this.btn_SaveXml, "Speichern im XML Format, Standard für FlowCalc");
            this.btn_SaveXml.UseVisualStyleBackColor = true;
            this.btn_SaveXml.Click += new System.EventHandler(this.btn_SaveXml_Click);
            // 
            // btn_SaveJson
            // 
            this.btn_SaveJson.Enabled = false;
            this.btn_SaveJson.Location = new System.Drawing.Point(93, 28);
            this.btn_SaveJson.Name = "btn_SaveJson";
            this.btn_SaveJson.Size = new System.Drawing.Size(76, 38);
            this.btn_SaveJson.TabIndex = 3;
            this.btn_SaveJson.Text = "JSON";
            this.toolTip1.SetToolTip(this.btn_SaveJson, "Speichern im JSON Format");
            this.btn_SaveJson.UseVisualStyleBackColor = true;
            this.btn_SaveJson.Click += new System.EventHandler(this.btn_SaveJson_Click);
            // 
            // btn_SaveCsv
            // 
            this.btn_SaveCsv.Enabled = false;
            this.btn_SaveCsv.Location = new System.Drawing.Point(175, 28);
            this.btn_SaveCsv.Name = "btn_SaveCsv";
            this.btn_SaveCsv.Size = new System.Drawing.Size(76, 38);
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
            this.groupBox1.Size = new System.Drawing.Size(263, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speichern als";
            // 
            // btn_NewPump
            // 
            this.btn_NewPump.Location = new System.Drawing.Point(12, 359);
            this.btn_NewPump.Name = "btn_NewPump";
            this.btn_NewPump.Size = new System.Drawing.Size(143, 38);
            this.btn_NewPump.TabIndex = 6;
            this.btn_NewPump.Text = "Neue Pumpendefinition";
            this.btn_NewPump.UseVisualStyleBackColor = true;
            this.btn_NewPump.Click += new System.EventHandler(this.btn_NewPump_Click);
            // 
            // btn_SaveMat
            // 
            this.btn_SaveMat.Enabled = false;
            this.btn_SaveMat.Location = new System.Drawing.Point(11, 28);
            this.btn_SaveMat.Name = "btn_SaveMat";
            this.btn_SaveMat.Size = new System.Drawing.Size(76, 38);
            this.btn_SaveMat.TabIndex = 5;
            this.btn_SaveMat.Text = "Export";
            this.toolTip1.SetToolTip(this.btn_SaveMat, "Exportieren der Pumpenkennlinie in MAT File (Matlab)");
            this.btn_SaveMat.UseVisualStyleBackColor = true;
            this.btn_SaveMat.Click += new System.EventHandler(this.btn_SaveMat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_LoadMat);
            this.groupBox2.Controls.Add(this.btn_SaveMat);
            this.groupBox2.Location = new System.Drawing.Point(281, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 77);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pumpenkennlinie";
            // 
            // btn_LoadMat
            // 
            this.btn_LoadMat.Enabled = false;
            this.btn_LoadMat.Location = new System.Drawing.Point(93, 28);
            this.btn_LoadMat.Name = "btn_LoadMat";
            this.btn_LoadMat.Size = new System.Drawing.Size(76, 38);
            this.btn_LoadMat.TabIndex = 6;
            this.btn_LoadMat.Text = "Import";
            this.toolTip1.SetToolTip(this.btn_LoadMat, "Importieren der Pumpenkennlinie aus MAT File (Matlab)");
            this.btn_LoadMat.UseVisualStyleBackColor = true;
            this.btn_LoadMat.Click += new System.EventHandler(this.btn_LoadMat_Click);
            // 
            // btn_ShowPerformanceCurve
            // 
            this.btn_ShowPerformanceCurve.Enabled = false;
            this.btn_ShowPerformanceCurve.Location = new System.Drawing.Point(320, 359);
            this.btn_ShowPerformanceCurve.Name = "btn_ShowPerformanceCurve";
            this.btn_ShowPerformanceCurve.Size = new System.Drawing.Size(143, 38);
            this.btn_ShowPerformanceCurve.TabIndex = 8;
            this.btn_ShowPerformanceCurve.Text = "Pumpenkennlinie anzeigen";
            this.btn_ShowPerformanceCurve.UseVisualStyleBackColor = true;
            this.btn_ShowPerformanceCurve.Click += new System.EventHandler(this.btn_ShowPerformanceCurve_Click);
            // 
            // EditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 495);
            this.Controls.Add(this.btn_ShowPerformanceCurve);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_NewPump);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.btn_LoadPump);
            this.Name = "EditorView";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_SaveMat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_LoadMat;
        private System.Windows.Forms.Button btn_ShowPerformanceCurve;
    }
}

