namespace FlowCalc
{
    partial class AboutView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_AssemblyTitle = new System.Windows.Forms.Label();
            this.lbl_AssemblyCompany = new System.Windows.Forms.Label();
            this.txt_AssemblyDescription = new System.Windows.Forms.TextBox();
            this.link_Repo = new System.Windows.Forms.LinkLabel();
            this.link_AuthorEmail = new System.Windows.Forms.LinkLabel();
            this.lbl_AssemblyVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::FlowCalc.Properties.Resources.logo100prznt;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 229);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_AssemblyTitle
            // 
            this.lbl_AssemblyTitle.AutoSize = true;
            this.lbl_AssemblyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AssemblyTitle.Location = new System.Drawing.Point(3, 0);
            this.lbl_AssemblyTitle.Name = "lbl_AssemblyTitle";
            this.lbl_AssemblyTitle.Size = new System.Drawing.Size(212, 33);
            this.lbl_AssemblyTitle.TabIndex = 1;
            this.lbl_AssemblyTitle.Text = "AssemblyTitle";
            // 
            // lbl_AssemblyCompany
            // 
            this.lbl_AssemblyCompany.AutoSize = true;
            this.lbl_AssemblyCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AssemblyCompany.Location = new System.Drawing.Point(3, 40);
            this.lbl_AssemblyCompany.Name = "lbl_AssemblyCompany";
            this.lbl_AssemblyCompany.Size = new System.Drawing.Size(136, 18);
            this.lbl_AssemblyCompany.TabIndex = 2;
            this.lbl_AssemblyCompany.Text = "AssemblyCompany";
            // 
            // txt_AssemblyDescription
            // 
            this.txt_AssemblyDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AssemblyDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_AssemblyDescription.Enabled = false;
            this.txt_AssemblyDescription.Location = new System.Drawing.Point(3, 3);
            this.txt_AssemblyDescription.Multiline = true;
            this.txt_AssemblyDescription.Name = "txt_AssemblyDescription";
            this.txt_AssemblyDescription.Size = new System.Drawing.Size(286, 73);
            this.txt_AssemblyDescription.TabIndex = 3;
            this.txt_AssemblyDescription.Text = "AssemblyDescription";
            // 
            // link_Repo
            // 
            this.link_Repo.AutoSize = true;
            this.link_Repo.Location = new System.Drawing.Point(3, 179);
            this.link_Repo.Name = "link_Repo";
            this.link_Repo.Size = new System.Drawing.Size(33, 13);
            this.link_Repo.TabIndex = 4;
            this.link_Repo.TabStop = true;
            this.link_Repo.Text = "Repo";
            this.link_Repo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Repo_LinkClicked);
            // 
            // link_AuthorEmail
            // 
            this.link_AuthorEmail.AutoSize = true;
            this.link_AuthorEmail.Location = new System.Drawing.Point(3, 204);
            this.link_AuthorEmail.Name = "link_AuthorEmail";
            this.link_AuthorEmail.Size = new System.Drawing.Size(63, 13);
            this.link_AuthorEmail.TabIndex = 5;
            this.link_AuthorEmail.TabStop = true;
            this.link_AuthorEmail.Text = "AuthorEmail";
            this.link_AuthorEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_AuthorEmail_LinkClicked);
            // 
            // lbl_AssemblyVersion
            // 
            this.lbl_AssemblyVersion.AutoSize = true;
            this.lbl_AssemblyVersion.Location = new System.Drawing.Point(3, 154);
            this.lbl_AssemblyVersion.Name = "lbl_AssemblyVersion";
            this.lbl_AssemblyVersion.Size = new System.Drawing.Size(86, 13);
            this.lbl_AssemblyVersion.TabIndex = 6;
            this.lbl_AssemblyVersion.Text = "AssemblyVersion";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 229);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_AssemblyTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.link_AuthorEmail, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbl_AssemblyVersion, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.link_Repo, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_AssemblyCompany, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(222, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 229);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txt_AssemblyDescription, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 70);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 79);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 229);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 268);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 268);
            this.Name = "AboutView";
            this.Text = "Über diese Software";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_AssemblyTitle;
        private System.Windows.Forms.Label lbl_AssemblyCompany;
        private System.Windows.Forms.TextBox txt_AssemblyDescription;
        private System.Windows.Forms.LinkLabel link_Repo;
        private System.Windows.Forms.LinkLabel link_AuthorEmail;
        private System.Windows.Forms.Label lbl_AssemblyVersion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}