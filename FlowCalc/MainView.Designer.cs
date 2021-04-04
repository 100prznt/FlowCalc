namespace FlowCalc
{
    partial class MainView
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
            this.btn_LoadPump = new System.Windows.Forms.Button();
            this.txt_PumpModel = new System.Windows.Forms.TextBox();
            this.txt_SystemPressure = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_VarioPump = new System.Windows.Forms.GroupBox();
            this.lbl_Rpm = new System.Windows.Forms.Label();
            this.tb_Rpm = new System.Windows.Forms.TrackBar();
            this.lbl_PumpDataSourceUrl = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_PumpPowerOut = new System.Windows.Forms.TextBox();
            this.btn_ShowPumpCurve = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PumpNominalFlowRate = new System.Windows.Forms.TextBox();
            this.txt_PumpNominalHead = new System.Windows.Forms.TextBox();
            this.lbl_PumpFileAuthor = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PumpMaxHead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PumpPowerIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PumpManufracturer = new System.Windows.Forms.TextBox();
            this.btn_CalcFlowRate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SystemFlowRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SystemHead = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_GenerateReport = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_SelectPipe = new System.Windows.Forms.Button();
            this.btn_CalcLength = new System.Windows.Forms.Button();
            this.txt_PipeSuctionPressureDrop = new System.Windows.Forms.TextBox();
            this.lbl_PipeSuctionPressureDrop = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_SuctionPiepLength = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_SuctionPipeDiameter = new System.Windows.Forms.TextBox();
            this.cbx_CalcSuctionPipe = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_ShowPowerPoint = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswahlPumpeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.suchverzeichnisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladePumpendefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editorStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fittingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suchverzeichnisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rechnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumenstromFließgeschwindigkeitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.äquivalenteRohrlängeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poolvolumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umwälzleistungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtergeschwindigkeitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.überToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stl_PumpSearchDirectory = new System.Windows.Forms.ToolStripStatusLabel();
            this.stl_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_PumpRpmHead = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gb_VarioPump.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Rpm)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LoadPump
            // 
            this.btn_LoadPump.Location = new System.Drawing.Point(39, 702);
            this.btn_LoadPump.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LoadPump.Name = "btn_LoadPump";
            this.btn_LoadPump.Size = new System.Drawing.Size(288, 60);
            this.btn_LoadPump.TabIndex = 98;
            this.btn_LoadPump.Text = "Lade Pumpendefinition...";
            this.btn_LoadPump.UseVisualStyleBackColor = true;
            this.btn_LoadPump.Click += new System.EventHandler(this.btn_LoadPump_Click);
            // 
            // txt_PumpModel
            // 
            this.txt_PumpModel.Enabled = false;
            this.txt_PumpModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PumpModel.Location = new System.Drawing.Point(250, 52);
            this.txt_PumpModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PumpModel.Name = "txt_PumpModel";
            this.txt_PumpModel.Size = new System.Drawing.Size(412, 26);
            this.txt_PumpModel.TabIndex = 99;
            // 
            // txt_SystemPressure
            // 
            this.txt_SystemPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SystemPressure.Location = new System.Drawing.Point(216, 436);
            this.txt_SystemPressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SystemPressure.Name = "txt_SystemPressure";
            this.txt_SystemPressure.Size = new System.Drawing.Size(91, 33);
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
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modell";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gb_VarioPump);
            this.groupBox1.Controls.Add(this.lbl_PumpDataSourceUrl);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txt_PumpPowerOut);
            this.groupBox1.Controls.Add(this.btn_ShowPumpCurve);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lbl_PumpFileAuthor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_PumpMaxHead);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_PumpPowerIn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_PumpManufracturer);
            this.groupBox1.Controls.Add(this.btn_LoadPump);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_PumpModel);
            this.groupBox1.Location = new System.Drawing.Point(18, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(704, 797);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pumpe";
            // 
            // gb_VarioPump
            // 
            this.gb_VarioPump.Controls.Add(this.txt_PumpRpmHead);
            this.gb_VarioPump.Controls.Add(this.label18);
            this.gb_VarioPump.Controls.Add(this.lbl_Rpm);
            this.gb_VarioPump.Controls.Add(this.tb_Rpm);
            this.gb_VarioPump.Location = new System.Drawing.Point(32, 427);
            this.gb_VarioPump.Name = "gb_VarioPump";
            this.gb_VarioPump.Size = new System.Drawing.Size(633, 155);
            this.gb_VarioPump.TabIndex = 106;
            this.gb_VarioPump.TabStop = false;
            this.gb_VarioPump.Text = "VARIO Pumpe";
            // 
            // lbl_Rpm
            // 
            this.lbl_Rpm.AutoSize = true;
            this.lbl_Rpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rpm.Location = new System.Drawing.Point(36, 43);
            this.lbl_Rpm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Rpm.Name = "lbl_Rpm";
            this.lbl_Rpm.Size = new System.Drawing.Size(118, 22);
            this.lbl_Rpm.TabIndex = 12;
            this.lbl_Rpm.Text = "0000 min^-1";
            // 
            // tb_Rpm
            // 
            this.tb_Rpm.LargeChange = 100;
            this.tb_Rpm.Location = new System.Drawing.Point(218, 26);
            this.tb_Rpm.Maximum = 2850;
            this.tb_Rpm.Minimum = 1000;
            this.tb_Rpm.Name = "tb_Rpm";
            this.tb_Rpm.Size = new System.Drawing.Size(383, 69);
            this.tb_Rpm.SmallChange = 10;
            this.tb_Rpm.TabIndex = 0;
            this.tb_Rpm.TickFrequency = 100;
            this.tb_Rpm.Value = 2000;
            this.tb_Rpm.ValueChanged += new System.EventHandler(this.tb_Rpm_ValueChanged);
            // 
            // lbl_PumpDataSourceUrl
            // 
            this.lbl_PumpDataSourceUrl.Location = new System.Drawing.Point(246, 651);
            this.lbl_PumpDataSourceUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PumpDataSourceUrl.Name = "lbl_PumpDataSourceUrl";
            this.lbl_PumpDataSourceUrl.Size = new System.Drawing.Size(433, 20);
            this.lbl_PumpDataSourceUrl.TabIndex = 104;
            this.lbl_PumpDataSourceUrl.TabStop = true;
            this.lbl_PumpDataSourceUrl.Text = "PumpDataSourceUrl";
            this.lbl_PumpDataSourceUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_PumpDataSourceUrl_LinkClicked);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 651);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 20);
            this.label17.TabIndex = 105;
            this.label17.Text = "Datenquelle:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 213);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 20);
            this.label16.TabIndex = 103;
            this.label16.Text = "Abgabeleistung Motor (P2)";
            // 
            // txt_PumpPowerOut
            // 
            this.txt_PumpPowerOut.Enabled = false;
            this.txt_PumpPowerOut.Location = new System.Drawing.Point(250, 208);
            this.txt_PumpPowerOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PumpPowerOut.Name = "txt_PumpPowerOut";
            this.txt_PumpPowerOut.Size = new System.Drawing.Size(412, 26);
            this.txt_PumpPowerOut.TabIndex = 102;
            // 
            // btn_ShowPumpCurve
            // 
            this.btn_ShowPumpCurve.Enabled = false;
            this.btn_ShowPumpCurve.Location = new System.Drawing.Point(358, 702);
            this.btn_ShowPumpCurve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ShowPumpCurve.Name = "btn_ShowPumpCurve";
            this.btn_ShowPumpCurve.Size = new System.Drawing.Size(306, 60);
            this.btn_ShowPumpCurve.TabIndex = 18;
            this.btn_ShowPumpCurve.Text = "Pumpenkennlinie anzeigen";
            this.btn_ShowPumpCurve.UseVisualStyleBackColor = true;
            this.btn_ShowPumpCurve.Click += new System.EventHandler(this.btn_ShowPumpCurve_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_PumpNominalFlowRate);
            this.groupBox3.Controls.Add(this.txt_PumpNominalHead);
            this.groupBox3.Location = new System.Drawing.Point(33, 260);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(632, 143);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nennleistung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Volumenstrom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Meter Wassersäule";
            // 
            // txt_PumpNominalFlowRate
            // 
            this.txt_PumpNominalFlowRate.Enabled = false;
            this.txt_PumpNominalFlowRate.Location = new System.Drawing.Point(218, 48);
            this.txt_PumpNominalFlowRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PumpNominalFlowRate.Name = "txt_PumpNominalFlowRate";
            this.txt_PumpNominalFlowRate.Size = new System.Drawing.Size(382, 26);
            this.txt_PumpNominalFlowRate.TabIndex = 8;
            // 
            // txt_PumpNominalHead
            // 
            this.txt_PumpNominalHead.Enabled = false;
            this.txt_PumpNominalHead.Location = new System.Drawing.Point(218, 88);
            this.txt_PumpNominalHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PumpNominalHead.Name = "txt_PumpNominalHead";
            this.txt_PumpNominalHead.Size = new System.Drawing.Size(382, 26);
            this.txt_PumpNominalHead.TabIndex = 10;
            // 
            // lbl_PumpFileAuthor
            // 
            this.lbl_PumpFileAuthor.Location = new System.Drawing.Point(246, 625);
            this.lbl_PumpFileAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PumpFileAuthor.Name = "lbl_PumpFileAuthor";
            this.lbl_PumpFileAuthor.Size = new System.Drawing.Size(364, 22);
            this.lbl_PumpFileAuthor.TabIndex = 17;
            this.lbl_PumpFileAuthor.TabStop = true;
            this.lbl_PumpFileAuthor.Text = "PumpFileAuthor";
            this.lbl_PumpFileAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_PumpFileAuthor_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 625);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 100;
            this.label10.Text = "Autor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Meter Wassersäule (maximal)";
            // 
            // txt_PumpMaxHead
            // 
            this.txt_PumpMaxHead.Enabled = false;
            this.txt_PumpMaxHead.Location = new System.Drawing.Point(250, 132);
            this.txt_PumpMaxHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PumpMaxHead.Name = "txt_PumpMaxHead";
            this.txt_PumpMaxHead.Size = new System.Drawing.Size(412, 26);
            this.txt_PumpMaxHead.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Leistungsaufnahme (P1)";
            // 
            // txt_PumpPowerIn
            // 
            this.txt_PumpPowerIn.Enabled = false;
            this.txt_PumpPowerIn.Location = new System.Drawing.Point(250, 172);
            this.txt_PumpPowerIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PumpPowerIn.Name = "txt_PumpPowerIn";
            this.txt_PumpPowerIn.Size = new System.Drawing.Size(412, 26);
            this.txt_PumpPowerIn.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hersteller";
            // 
            // txt_PumpManufracturer
            // 
            this.txt_PumpManufracturer.Enabled = false;
            this.txt_PumpManufracturer.Location = new System.Drawing.Point(250, 92);
            this.txt_PumpManufracturer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PumpManufracturer.Name = "txt_PumpManufracturer";
            this.txt_PumpManufracturer.Size = new System.Drawing.Size(412, 26);
            this.txt_PumpManufracturer.TabIndex = 4;
            // 
            // btn_CalcFlowRate
            // 
            this.btn_CalcFlowRate.Location = new System.Drawing.Point(38, 522);
            this.btn_CalcFlowRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CalcFlowRate.Name = "btn_CalcFlowRate";
            this.btn_CalcFlowRate.Size = new System.Drawing.Size(328, 60);
            this.btn_CalcFlowRate.TabIndex = 5;
            this.btn_CalcFlowRate.Text = "Berechne Fördermenge";
            this.btn_CalcFlowRate.UseVisualStyleBackColor = true;
            this.btn_CalcFlowRate.Click += new System.EventHandler(this.btn_CalcFlowRate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 440);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Systemdruck";
            this.toolTip1.SetToolTip(this.label6, "Druck direkt nach der Pumpe");
            // 
            // txt_SystemFlowRate
            // 
            this.txt_SystemFlowRate.Enabled = false;
            this.txt_SystemFlowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SystemFlowRate.Location = new System.Drawing.Point(216, 658);
            this.txt_SystemFlowRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SystemFlowRate.Name = "txt_SystemFlowRate";
            this.txt_SystemFlowRate.Size = new System.Drawing.Size(148, 26);
            this.txt_SystemFlowRate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 663);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Volumenstrom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 623);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Meter Wassersäule";
            // 
            // txt_SystemHead
            // 
            this.txt_SystemHead.Enabled = false;
            this.txt_SystemHead.Location = new System.Drawing.Point(216, 618);
            this.txt_SystemHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SystemHead.Name = "txt_SystemHead";
            this.txt_SystemHead.Size = new System.Drawing.Size(148, 26);
            this.txt_SystemHead.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_GenerateReport);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btn_ShowPowerPoint);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_SystemPressure);
            this.groupBox2.Controls.Add(this.txt_SystemHead);
            this.groupBox2.Controls.Add(this.btn_CalcFlowRate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_SystemFlowRate);
            this.groupBox2.Location = new System.Drawing.Point(747, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(406, 797);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System";
            // 
            // btn_GenerateReport
            // 
            this.btn_GenerateReport.Enabled = false;
            this.btn_GenerateReport.Location = new System.Drawing.Point(216, 704);
            this.btn_GenerateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_GenerateReport.Name = "btn_GenerateReport";
            this.btn_GenerateReport.Size = new System.Drawing.Size(150, 60);
            this.btn_GenerateReport.TabIndex = 23;
            this.btn_GenerateReport.Text = "Report erstellen (pdf)";
            this.btn_GenerateReport.UseVisualStyleBackColor = true;
            this.btn_GenerateReport.Click += new System.EventHandler(this.btn_GenerateReport_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_SelectPipe);
            this.groupBox4.Controls.Add(this.btn_CalcLength);
            this.groupBox4.Controls.Add(this.txt_PipeSuctionPressureDrop);
            this.groupBox4.Controls.Add(this.lbl_PipeSuctionPressureDrop);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txt_SuctionPiepLength);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txt_SuctionPipeDiameter);
            this.groupBox4.Controls.Add(this.cbx_CalcSuctionPipe);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(38, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(328, 343);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saugseitige Rohrleitung";
            // 
            // btn_SelectPipe
            // 
            this.btn_SelectPipe.Location = new System.Drawing.Point(27, 81);
            this.btn_SelectPipe.Name = "btn_SelectPipe";
            this.btn_SelectPipe.Size = new System.Drawing.Size(279, 35);
            this.btn_SelectPipe.TabIndex = 30;
            this.btn_SelectPipe.Text = "Auswahl Rohr";
            this.btn_SelectPipe.UseVisualStyleBackColor = true;
            this.btn_SelectPipe.Visible = false;
            this.btn_SelectPipe.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_CalcLength
            // 
            this.btn_CalcLength.Location = new System.Drawing.Point(27, 229);
            this.btn_CalcLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CalcLength.Name = "btn_CalcLength";
            this.btn_CalcLength.Size = new System.Drawing.Size(279, 35);
            this.btn_CalcLength.TabIndex = 29;
            this.btn_CalcLength.Text = "Äquivalente Länge ermitteln";
            this.btn_CalcLength.UseVisualStyleBackColor = true;
            this.btn_CalcLength.Click += new System.EventHandler(this.btn_CalcLength_Click);
            // 
            // txt_PipeSuctionPressureDrop
            // 
            this.txt_PipeSuctionPressureDrop.Enabled = false;
            this.txt_PipeSuctionPressureDrop.Location = new System.Drawing.Point(178, 288);
            this.txt_PipeSuctionPressureDrop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PipeSuctionPressureDrop.Name = "txt_PipeSuctionPressureDrop";
            this.txt_PipeSuctionPressureDrop.Size = new System.Drawing.Size(126, 26);
            this.txt_PipeSuctionPressureDrop.TabIndex = 28;
            // 
            // lbl_PipeSuctionPressureDrop
            // 
            this.lbl_PipeSuctionPressureDrop.AutoSize = true;
            this.lbl_PipeSuctionPressureDrop.Location = new System.Drawing.Point(22, 293);
            this.lbl_PipeSuctionPressureDrop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PipeSuctionPressureDrop.Name = "lbl_PipeSuctionPressureDrop";
            this.lbl_PipeSuctionPressureDrop.Size = new System.Drawing.Size(128, 20);
            this.lbl_PipeSuctionPressureDrop.TabIndex = 27;
            this.lbl_PipeSuctionPressureDrop.Text = "Pumpenvordruck";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 185);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "m";
            // 
            // txt_SuctionPiepLength
            // 
            this.txt_SuctionPiepLength.Enabled = false;
            this.txt_SuctionPiepLength.Location = new System.Drawing.Point(178, 180);
            this.txt_SuctionPiepLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SuctionPiepLength.Name = "txt_SuctionPiepLength";
            this.txt_SuctionPiepLength.Size = new System.Drawing.Size(91, 26);
            this.txt_SuctionPiepLength.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 185);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Länge";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 145);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "mm";
            // 
            // txt_SuctionPipeDiameter
            // 
            this.txt_SuctionPipeDiameter.Enabled = false;
            this.txt_SuctionPipeDiameter.Location = new System.Drawing.Point(178, 140);
            this.txt_SuctionPipeDiameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SuctionPipeDiameter.Name = "txt_SuctionPipeDiameter";
            this.txt_SuctionPipeDiameter.Size = new System.Drawing.Size(91, 26);
            this.txt_SuctionPipeDiameter.TabIndex = 21;
            // 
            // cbx_CalcSuctionPipe
            // 
            this.cbx_CalcSuctionPipe.AutoSize = true;
            this.cbx_CalcSuctionPipe.Location = new System.Drawing.Point(27, 40);
            this.cbx_CalcSuctionPipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_CalcSuctionPipe.Name = "cbx_CalcSuctionPipe";
            this.cbx_CalcSuctionPipe.Size = new System.Drawing.Size(292, 24);
            this.cbx_CalcSuctionPipe.TabIndex = 5;
            this.cbx_CalcSuctionPipe.Text = "Saugseitigen Druckabfall berechnen";
            this.cbx_CalcSuctionPipe.UseVisualStyleBackColor = true;
            this.cbx_CalcSuctionPipe.CheckedChanged += new System.EventHandler(this.cbx_CalcSuctionPipe_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 145);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Innendurchmesser";
            // 
            // btn_ShowPowerPoint
            // 
            this.btn_ShowPowerPoint.Enabled = false;
            this.btn_ShowPowerPoint.Location = new System.Drawing.Point(38, 704);
            this.btn_ShowPowerPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ShowPowerPoint.Name = "btn_ShowPowerPoint";
            this.btn_ShowPowerPoint.Size = new System.Drawing.Size(150, 60);
            this.btn_ShowPowerPoint.TabIndex = 19;
            this.btn_ShowPowerPoint.Text = "Arbeitspunkt anzeigen";
            this.btn_ShowPowerPoint.UseVisualStyleBackColor = true;
            this.btn_ShowPowerPoint.Click += new System.EventHandler(this.btn_ShowPowerPoint_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(312, 440);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 29);
            this.label11.TabIndex = 17;
            this.label11.Text = "bar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stToolStripMenuItem,
            this.überToolStripMenuItem,
            this.fittingsToolStripMenuItem,
            this.rechnerToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stToolStripMenuItem
            // 
            this.stToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.toolStripSeparator3,
            this.beendenToolStripMenuItem});
            this.stToolStripMenuItem.Name = "stToolStripMenuItem";
            this.stToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.stToolStripMenuItem.Text = "Datei";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.einstellungenToolStripMenuItem.Text = "Voreinstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(242, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auswahlPumpeToolStripMenuItem,
            this.toolStripSeparator1,
            this.suchverzeichnisToolStripMenuItem,
            this.ladePumpendefinitionToolStripMenuItem,
            this.toolStripSeparator2,
            this.editorStartenToolStripMenuItem});
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.überToolStripMenuItem.Text = "Pumpe";
            // 
            // auswahlPumpeToolStripMenuItem
            // 
            this.auswahlPumpeToolStripMenuItem.Enabled = false;
            this.auswahlPumpeToolStripMenuItem.Name = "auswahlPumpeToolStripMenuItem";
            this.auswahlPumpeToolStripMenuItem.Size = new System.Drawing.Size(309, 34);
            this.auswahlPumpeToolStripMenuItem.Text = "Auswahl Pumpe";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(306, 6);
            // 
            // suchverzeichnisToolStripMenuItem
            // 
            this.suchverzeichnisToolStripMenuItem.Name = "suchverzeichnisToolStripMenuItem";
            this.suchverzeichnisToolStripMenuItem.Size = new System.Drawing.Size(309, 34);
            this.suchverzeichnisToolStripMenuItem.Text = "Suchverzeichnis...";
            this.suchverzeichnisToolStripMenuItem.Click += new System.EventHandler(this.searchPathPumpsToolStripMenuItem_Click);
            // 
            // ladePumpendefinitionToolStripMenuItem
            // 
            this.ladePumpendefinitionToolStripMenuItem.Name = "ladePumpendefinitionToolStripMenuItem";
            this.ladePumpendefinitionToolStripMenuItem.Size = new System.Drawing.Size(309, 34);
            this.ladePumpendefinitionToolStripMenuItem.Text = "Lade Pumpendefinition...";
            this.ladePumpendefinitionToolStripMenuItem.Click += new System.EventHandler(this.btn_LoadPump_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(306, 6);
            // 
            // editorStartenToolStripMenuItem
            // 
            this.editorStartenToolStripMenuItem.Enabled = false;
            this.editorStartenToolStripMenuItem.Name = "editorStartenToolStripMenuItem";
            this.editorStartenToolStripMenuItem.Size = new System.Drawing.Size(309, 34);
            this.editorStartenToolStripMenuItem.Text = "Editor starten";
            this.editorStartenToolStripMenuItem.Click += new System.EventHandler(this.editorStartenToolStripMenuItem_Click);
            // 
            // fittingsToolStripMenuItem
            // 
            this.fittingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suchverzeichnisToolStripMenuItem1});
            this.fittingsToolStripMenuItem.Name = "fittingsToolStripMenuItem";
            this.fittingsToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.fittingsToolStripMenuItem.Text = "Fittings";
            // 
            // suchverzeichnisToolStripMenuItem1
            // 
            this.suchverzeichnisToolStripMenuItem1.Name = "suchverzeichnisToolStripMenuItem1";
            this.suchverzeichnisToolStripMenuItem1.Size = new System.Drawing.Size(249, 34);
            this.suchverzeichnisToolStripMenuItem1.Text = "Suchverzeichnis...";
            this.suchverzeichnisToolStripMenuItem1.Click += new System.EventHandler(this.searchPathFittingsToolStripMenuItem_Click);
            // 
            // rechnerToolStripMenuItem
            // 
            this.rechnerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volumenstromFließgeschwindigkeitToolStripMenuItem,
            this.äquivalenteRohrlängeToolStripMenuItem,
            this.poolvolumenToolStripMenuItem,
            this.umwälzleistungToolStripMenuItem,
            this.filtergeschwindigkeitToolStripMenuItem});
            this.rechnerToolStripMenuItem.Name = "rechnerToolStripMenuItem";
            this.rechnerToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.rechnerToolStripMenuItem.Text = "Rechner";
            // 
            // volumenstromFließgeschwindigkeitToolStripMenuItem
            // 
            this.volumenstromFließgeschwindigkeitToolStripMenuItem.Name = "volumenstromFließgeschwindigkeitToolStripMenuItem";
            this.volumenstromFließgeschwindigkeitToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.volumenstromFließgeschwindigkeitToolStripMenuItem.Text = "p-v-Q";
            this.volumenstromFließgeschwindigkeitToolStripMenuItem.ToolTipText = "Berechnung von Strömungsgeschwindigkeit, Volumenstrom und Druckverlust in Rohrlei" +
    "tungen";
            this.volumenstromFließgeschwindigkeitToolStripMenuItem.Click += new System.EventHandler(this.volumenstromFließgeschwindigkeitToolStripMenuItem_Click);
            // 
            // äquivalenteRohrlängeToolStripMenuItem
            // 
            this.äquivalenteRohrlängeToolStripMenuItem.Name = "äquivalenteRohrlängeToolStripMenuItem";
            this.äquivalenteRohrlängeToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.äquivalenteRohrlängeToolStripMenuItem.Text = "Äquivalente Rohrlänge";
            this.äquivalenteRohrlängeToolStripMenuItem.ToolTipText = "Berechnung der äquivalente Rohrlänge in Abhängigkeit der verbauten Fittings und A" +
    "rmaturen";
            this.äquivalenteRohrlängeToolStripMenuItem.Click += new System.EventHandler(this.äquivalenteRohrlängeToolStripMenuItem_Click);
            // 
            // poolvolumenToolStripMenuItem
            // 
            this.poolvolumenToolStripMenuItem.Name = "poolvolumenToolStripMenuItem";
            this.poolvolumenToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.poolvolumenToolStripMenuItem.Text = "Poolvolumen";
            this.poolvolumenToolStripMenuItem.Click += new System.EventHandler(this.poolvolumenToolStripMenuItem_Click);
            // 
            // umwälzleistungToolStripMenuItem
            // 
            this.umwälzleistungToolStripMenuItem.Name = "umwälzleistungToolStripMenuItem";
            this.umwälzleistungToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.umwälzleistungToolStripMenuItem.Text = "Umwälzleistung";
            this.umwälzleistungToolStripMenuItem.Click += new System.EventHandler(this.umwälzleistungToolStripMenuItem_Click);
            // 
            // filtergeschwindigkeitToolStripMenuItem
            // 
            this.filtergeschwindigkeitToolStripMenuItem.Name = "filtergeschwindigkeitToolStripMenuItem";
            this.filtergeschwindigkeitToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.filtergeschwindigkeitToolStripMenuItem.Text = "Filtergeschwindigkeit";
            this.filtergeschwindigkeitToolStripMenuItem.Click += new System.EventHandler(this.filtergeschwindigkeitToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentationToolStripMenuItem,
            this.toolStripSeparator4,
            this.überToolStripMenuItem1});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // dokumentationToolStripMenuItem
            // 
            this.dokumentationToolStripMenuItem.Name = "dokumentationToolStripMenuItem";
            this.dokumentationToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.dokumentationToolStripMenuItem.Text = "Dokumentation";
            this.dokumentationToolStripMenuItem.ToolTipText = "https://github.com/100prznt/FlowCalc/";
            this.dokumentationToolStripMenuItem.Click += new System.EventHandler(this.dokumentationToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(235, 6);
            // 
            // überToolStripMenuItem1
            // 
            this.überToolStripMenuItem1.Name = "überToolStripMenuItem1";
            this.überToolStripMenuItem1.Size = new System.Drawing.Size(238, 34);
            this.überToolStripMenuItem1.Text = "Über";
            this.überToolStripMenuItem1.Click += new System.EventHandler(this.überToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stl_PumpSearchDirectory,
            this.stl_Info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 872);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1162, 32);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stl_PumpSearchDirectory
            // 
            this.stl_PumpSearchDirectory.Name = "stl_PumpSearchDirectory";
            this.stl_PumpSearchDirectory.Size = new System.Drawing.Size(249, 25);
            this.stl_PumpSearchDirectory.Text = "Bitte Suchverzeichnis angeben";
            // 
            // stl_Info
            // 
            this.stl_Info.Name = "stl_Info";
            this.stl_Info.Size = new System.Drawing.Size(890, 25);
            this.stl_Info.Spring = true;
            this.stl_Info.Text = "Bereit";
            this.stl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PDF|*.pdf";
            this.saveFileDialog1.Title = "Report speichern";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 99);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Meter Wassersäule";
            // 
            // txt_PumpRpmHead
            // 
            this.txt_PumpRpmHead.Enabled = false;
            this.txt_PumpRpmHead.Location = new System.Drawing.Point(219, 94);
            this.txt_PumpRpmHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PumpRpmHead.Name = "txt_PumpRpmHead";
            this.txt_PumpRpmHead.Size = new System.Drawing.Size(382, 26);
            this.txt_PumpRpmHead.TabIndex = 12;
            // 
            // MainView
            // 
            this.AcceptButton = this.btn_CalcFlowRate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 904);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1184, 960);
            this.MinimumSize = new System.Drawing.Size(1184, 960);
            this.Name = "MainView";
            this.Text = "FlowCalc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_VarioPump.ResumeLayout(false);
            this.gb_VarioPump.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Rpm)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txt_PumpPowerIn;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ShowPumpCurve;
        private System.Windows.Forms.Button btn_ShowPowerPoint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_SuctionPipeDiameter;
        private System.Windows.Forms.CheckBox cbx_CalcSuctionPipe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_SuctionPiepLength;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_PipeSuctionPressureDrop;
        private System.Windows.Forms.Label lbl_PipeSuctionPressureDrop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladePumpendefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suchverzeichnisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auswahlPumpeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem rechnerToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem volumenstromFließgeschwindigkeitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stl_PumpSearchDirectory;
        private System.Windows.Forms.ToolStripStatusLabel stl_Info;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editorStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem äquivalenteRohrlängeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fittingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suchverzeichnisToolStripMenuItem1;
        private System.Windows.Forms.Button btn_CalcLength;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem poolvolumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umwälzleistungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem filtergeschwindigkeitToolStripMenuItem;
        private System.Windows.Forms.Button btn_SelectPipe;
        private System.Windows.Forms.Button btn_GenerateReport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_PumpPowerOut;
        private System.Windows.Forms.LinkLabel lbl_PumpDataSourceUrl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gb_VarioPump;
        private System.Windows.Forms.TrackBar tb_Rpm;
        private System.Windows.Forms.Label lbl_Rpm;
        private System.Windows.Forms.TextBox txt_PumpRpmHead;
        private System.Windows.Forms.Label label18;
    }
}

