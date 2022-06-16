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
            this.btn_Apply = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pg_Pipe = new System.Windows.Forms.PropertyGrid();
            this.cbx_SelectedPipe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(12, 346);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(347, 33);
            this.btn_Apply.TabIndex = 0;
            this.btn_Apply.Text = "Übernehmen";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // pg_Pipe
            // 
            this.pg_Pipe.Location = new System.Drawing.Point(12, 39);
            this.pg_Pipe.Name = "pg_Pipe";
            this.pg_Pipe.Size = new System.Drawing.Size(347, 301);
            this.pg_Pipe.TabIndex = 2;
            this.pg_Pipe.ToolbarVisible = false;
            // 
            // cbx_SelectedPipe
            // 
            this.cbx_SelectedPipe.FormattingEnabled = true;
            this.cbx_SelectedPipe.Location = new System.Drawing.Point(12, 12);
            this.cbx_SelectedPipe.Name = "cbx_SelectedPipe";
            this.cbx_SelectedPipe.Size = new System.Drawing.Size(347, 21);
            this.cbx_SelectedPipe.TabIndex = 3;
            this.cbx_SelectedPipe.SelectedIndexChanged += new System.EventHandler(this.cbx_SelectedPipe_SelectedIndexChanged);
            // 
            // PipeSelectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 391);
            this.Controls.Add(this.cbx_SelectedPipe);
            this.Controls.Add(this.pg_Pipe);
            this.Controls.Add(this.btn_Apply);
            this.MaximizeBox = false;
            this.Name = "PipeSelectView";
            this.Text = "PipeSelectView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PropertyGrid pg_Pipe;
        private System.Windows.Forms.ComboBox cbx_SelectedPipe;
    }
}