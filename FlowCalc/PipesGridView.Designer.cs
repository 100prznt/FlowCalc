namespace FlowCalc
{
    partial class PipesGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbx_SelectedPipe = new System.Windows.Forms.ComboBox();
            this.dgv_Pipes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PipeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_OuterDiamenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_InnerDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Thikness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Roughness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NominalPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UniqueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pipes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Apply
            // 
            this.btn_Apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Apply.Location = new System.Drawing.Point(13, 696);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(1155, 39);
            this.btn_Apply.TabIndex = 0;
            this.btn_Apply.Text = "Übernehmen";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // cbx_SelectedPipe
            // 
            this.cbx_SelectedPipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_SelectedPipe.FormattingEnabled = true;
            this.cbx_SelectedPipe.Location = new System.Drawing.Point(13, 13);
            this.cbx_SelectedPipe.Name = "cbx_SelectedPipe";
            this.cbx_SelectedPipe.Size = new System.Drawing.Size(1155, 21);
            this.cbx_SelectedPipe.TabIndex = 3;
            this.cbx_SelectedPipe.SelectedIndexChanged += new System.EventHandler(this.cbx_SelectedPipe_SelectedIndexChanged);
            // 
            // dgv_Pipes
            // 
            this.dgv_Pipes.AllowUserToAddRows = false;
            this.dgv_Pipes.AllowUserToDeleteRows = false;
            this.dgv_Pipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Name,
            this.col_PipeType,
            this.col_OuterDiamenter,
            this.col_InnerDiameter,
            this.col_Thikness,
            this.col_Roughness,
            this.col_NominalPressure,
            this.col_UniqueName});
            this.dgv_Pipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Pipes.Location = new System.Drawing.Point(13, 43);
            this.dgv_Pipes.Name = "dgv_Pipes";
            this.dgv_Pipes.ReadOnly = true;
            this.dgv_Pipes.RowHeadersVisible = false;
            this.dgv_Pipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pipes.Size = new System.Drawing.Size(1155, 647);
            this.dgv_Pipes.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Apply, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbx_SelectedPipe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Pipes, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1181, 748);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // col_Name
            // 
            this.col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Name.DataPropertyName = "DisplayName";
            this.col_Name.HeaderText = "Anzeigename";
            this.col_Name.Name = "col_Name";
            this.col_Name.ReadOnly = true;
            // 
            // col_PipeType
            // 
            this.col_PipeType.DataPropertyName = "Category";
            this.col_PipeType.HeaderText = "Leitungstyp";
            this.col_PipeType.Name = "col_PipeType";
            this.col_PipeType.ReadOnly = true;
            this.col_PipeType.Width = 120;
            // 
            // col_OuterDiamenter
            // 
            this.col_OuterDiamenter.DataPropertyName = "NominalDiameter";
            dataGridViewCellStyle1.Format = "#.# mm";
            dataGridViewCellStyle1.NullValue = null;
            this.col_OuterDiamenter.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_OuterDiamenter.HeaderText = "Außendurchmesser";
            this.col_OuterDiamenter.Name = "col_OuterDiamenter";
            this.col_OuterDiamenter.ReadOnly = true;
            this.col_OuterDiamenter.Width = 130;
            // 
            // col_InnerDiameter
            // 
            this.col_InnerDiameter.DataPropertyName = "InnerDiameter";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "#.# mm";
            this.col_InnerDiameter.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_InnerDiameter.HeaderText = "Innendurchmesser";
            this.col_InnerDiameter.Name = "col_InnerDiameter";
            this.col_InnerDiameter.ReadOnly = true;
            this.col_InnerDiameter.Width = 130;
            // 
            // col_Thikness
            // 
            this.col_Thikness.DataPropertyName = "Thickness";
            dataGridViewCellStyle3.Format = "#.# mm";
            dataGridViewCellStyle3.NullValue = null;
            this.col_Thikness.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_Thikness.HeaderText = "Wandstärke";
            this.col_Thikness.Name = "col_Thikness";
            this.col_Thikness.ReadOnly = true;
            this.col_Thikness.Width = 130;
            // 
            // col_Roughness
            // 
            this.col_Roughness.DataPropertyName = "Roughness";
            dataGridViewCellStyle4.Format = "0.### mm";
            this.col_Roughness.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_Roughness.HeaderText = "Rohrrauheit";
            this.col_Roughness.Name = "col_Roughness";
            this.col_Roughness.ReadOnly = true;
            this.col_Roughness.Width = 130;
            // 
            // col_NominalPressure
            // 
            this.col_NominalPressure.DataPropertyName = "NominalPressure";
            dataGridViewCellStyle5.Format = "#.# bar";
            this.col_NominalPressure.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_NominalPressure.HeaderText = "Nenndruck (PN)";
            this.col_NominalPressure.Name = "col_NominalPressure";
            this.col_NominalPressure.ReadOnly = true;
            this.col_NominalPressure.Width = 130;
            // 
            // col_UniqueName
            // 
            this.col_UniqueName.DataPropertyName = "UniqueName";
            this.col_UniqueName.HeaderText = "Eindeutiger Name";
            this.col_UniqueName.Name = "col_UniqueName";
            this.col_UniqueName.ReadOnly = true;
            this.col_UniqueName.Width = 155;
            // 
            // PipesGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 748);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "PipesGridView";
            this.Text = "PipeSelectView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pipes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbx_SelectedPipe;
        private System.Windows.Forms.DataGridView dgv_Pipes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PipeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_OuterDiamenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_InnerDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Thikness;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Roughness;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NominalPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UniqueName;
    }
}