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
            this.txt_PumpPowerOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PumpManufracturer = new System.Windows.Forms.TextBox();
            this.btn_CalcFlowRate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SystemFlowRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SystemHead = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_PumpHeight = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stl_PumpSearchDirectory = new System.Windows.Forms.ToolStripStatusLabel();
            this.stl_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LoadPump
            // 
            this.btn_LoadPump.Location = new System.Drawing.Point(26, 380);
            this.btn_LoadPump.Name = "btn_LoadPump";
            this.btn_LoadPump.Size = new System.Drawing.Size(192, 39);
            this.btn_LoadPump.TabIndex = 98;
            this.btn_LoadPump.Text = "Lade Pumpendefinition...";
            this.btn_LoadPump.UseVisualStyleBackColor = true;
            this.btn_LoadPump.Click += new System.EventHandler(this.btn_LoadPump_Click);
            // 
            // txt_PumpModel
            // 
            this.txt_PumpModel.Enabled = false;
            this.txt_PumpModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PumpModel.Location = new System.Drawing.Point(167, 34);
            this.txt_PumpModel.Name = "txt_PumpModel";
            this.txt_PumpModel.Size = new System.Drawing.Size(276, 20);
            this.txt_PumpModel.TabIndex = 99;
            // 
            // txt_SystemPressure
            // 
            this.txt_SystemPressure.Location = new System.Drawing.Point(144, 242);
            this.txt_SystemPressure.Name = "txt_SystemPressure";
            this.txt_SystemPressure.Size = new System.Drawing.Size(62, 20);
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
            this.groupBox1.Controls.Add(this.btn_ShowPumpCurve);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lbl_PumpFileAuthor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_PumpMaxHead);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_PumpPowerOut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_PumpManufracturer);
            this.groupBox1.Controls.Add(this.btn_LoadPump);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_PumpModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 437);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pumpe";
            // 
            // btn_ShowPumpCurve
            // 
            this.btn_ShowPumpCurve.Enabled = false;
            this.btn_ShowPumpCurve.Location = new System.Drawing.Point(239, 380);
            this.btn_ShowPumpCurve.Name = "btn_ShowPumpCurve";
            this.btn_ShowPumpCurve.Size = new System.Drawing.Size(204, 39);
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
            this.groupBox3.Location = new System.Drawing.Point(22, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 100);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nennleistung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Volumenstrom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Meter Wassersäule";
            // 
            // txt_PumpNominalFlowRate
            // 
            this.txt_PumpNominalFlowRate.Enabled = false;
            this.txt_PumpNominalFlowRate.Location = new System.Drawing.Point(145, 31);
            this.txt_PumpNominalFlowRate.Name = "txt_PumpNominalFlowRate";
            this.txt_PumpNominalFlowRate.Size = new System.Drawing.Size(256, 20);
            this.txt_PumpNominalFlowRate.TabIndex = 8;
            // 
            // txt_PumpNominalHead
            // 
            this.txt_PumpNominalHead.Enabled = false;
            this.txt_PumpNominalHead.Location = new System.Drawing.Point(145, 57);
            this.txt_PumpNominalHead.Name = "txt_PumpNominalHead";
            this.txt_PumpNominalHead.Size = new System.Drawing.Size(256, 20);
            this.txt_PumpNominalHead.TabIndex = 10;
            // 
            // lbl_PumpFileAuthor
            // 
            this.lbl_PumpFileAuthor.Location = new System.Drawing.Point(164, 268);
            this.lbl_PumpFileAuthor.Name = "lbl_PumpFileAuthor";
            this.lbl_PumpFileAuthor.Size = new System.Drawing.Size(243, 23);
            this.lbl_PumpFileAuthor.TabIndex = 17;
            this.lbl_PumpFileAuthor.TabStop = true;
            this.lbl_PumpFileAuthor.Text = "PumpFileAuthor";
            this.lbl_PumpFileAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_PumpFileAuthor_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Autor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Meter Wassersäule (maximal)";
            // 
            // txt_PumpMaxHead
            // 
            this.txt_PumpMaxHead.Enabled = false;
            this.txt_PumpMaxHead.Location = new System.Drawing.Point(167, 86);
            this.txt_PumpMaxHead.Name = "txt_PumpMaxHead";
            this.txt_PumpMaxHead.Size = new System.Drawing.Size(276, 20);
            this.txt_PumpMaxHead.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Abgabeleistung Motor";
            // 
            // txt_PumpPowerOut
            // 
            this.txt_PumpPowerOut.Enabled = false;
            this.txt_PumpPowerOut.Location = new System.Drawing.Point(167, 112);
            this.txt_PumpPowerOut.Name = "txt_PumpPowerOut";
            this.txt_PumpPowerOut.Size = new System.Drawing.Size(276, 20);
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
            this.txt_PumpManufracturer.Location = new System.Drawing.Point(167, 60);
            this.txt_PumpManufracturer.Name = "txt_PumpManufracturer";
            this.txt_PumpManufracturer.Size = new System.Drawing.Size(276, 20);
            this.txt_PumpManufracturer.TabIndex = 4;
            // 
            // btn_CalcFlowRate
            // 
            this.btn_CalcFlowRate.Location = new System.Drawing.Point(25, 271);
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
            this.label6.Location = new System.Drawing.Point(22, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Systemdruck";
            this.toolTip1.SetToolTip(this.label6, "Druck direkt nach der Pumpe");
            // 
            // txt_SystemFlowRate
            // 
            this.txt_SystemFlowRate.Enabled = false;
            this.txt_SystemFlowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SystemFlowRate.Location = new System.Drawing.Point(144, 349);
            this.txt_SystemFlowRate.Name = "txt_SystemFlowRate";
            this.txt_SystemFlowRate.Size = new System.Drawing.Size(100, 20);
            this.txt_SystemFlowRate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Volumenstrom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Meter Wassersäule";
            // 
            // txt_SystemHead
            // 
            this.txt_SystemHead.Enabled = false;
            this.txt_SystemHead.Location = new System.Drawing.Point(144, 323);
            this.txt_SystemHead.Name = "txt_SystemHead";
            this.txt_SystemHead.Size = new System.Drawing.Size(100, 20);
            this.txt_SystemHead.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_PumpHeight);
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
            this.groupBox2.Location = new System.Drawing.Point(498, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 437);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(208, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "m";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Ansaughöhe";
            this.toolTip1.SetToolTip(this.label17, "Höhe in welcher die Pumpe über dem Wasserspiegel steht");
            // 
            // txt_PumpHeight
            // 
            this.txt_PumpHeight.Location = new System.Drawing.Point(144, 216);
            this.txt_PumpHeight.Name = "txt_PumpHeight";
            this.txt_PumpHeight.Size = new System.Drawing.Size(62, 20);
            this.txt_PumpHeight.TabIndex = 23;
            this.txt_PumpHeight.Text = "0,0";
            // 
            // groupBox4
            // 
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
            this.groupBox4.Location = new System.Drawing.Point(25, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 177);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saugseitige Rohrleitung";
            // 
            // btn_CalcLength
            // 
            this.btn_CalcLength.Location = new System.Drawing.Point(18, 103);
            this.btn_CalcLength.Name = "btn_CalcLength";
            this.btn_CalcLength.Size = new System.Drawing.Size(186, 23);
            this.btn_CalcLength.TabIndex = 29;
            this.btn_CalcLength.Text = "Äquivalente Länge ermitteln";
            this.btn_CalcLength.UseVisualStyleBackColor = true;
            this.btn_CalcLength.Click += new System.EventHandler(this.btn_CalcLength_Click);
            // 
            // txt_PipeSuctionPressureDrop
            // 
            this.txt_PipeSuctionPressureDrop.Enabled = false;
            this.txt_PipeSuctionPressureDrop.Location = new System.Drawing.Point(119, 141);
            this.txt_PipeSuctionPressureDrop.Name = "txt_PipeSuctionPressureDrop";
            this.txt_PipeSuctionPressureDrop.Size = new System.Drawing.Size(85, 20);
            this.txt_PipeSuctionPressureDrop.TabIndex = 28;
            // 
            // lbl_PipeSuctionPressureDrop
            // 
            this.lbl_PipeSuctionPressureDrop.AutoSize = true;
            this.lbl_PipeSuctionPressureDrop.Location = new System.Drawing.Point(15, 144);
            this.lbl_PipeSuctionPressureDrop.Name = "lbl_PipeSuctionPressureDrop";
            this.lbl_PipeSuctionPressureDrop.Size = new System.Drawing.Size(88, 13);
            this.lbl_PipeSuctionPressureDrop.TabIndex = 27;
            this.lbl_PipeSuctionPressureDrop.Text = "Pumpenvordruck";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(183, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "m";
            // 
            // txt_SuctionPiepLength
            // 
            this.txt_SuctionPiepLength.Enabled = false;
            this.txt_SuctionPiepLength.Location = new System.Drawing.Point(119, 75);
            this.txt_SuctionPiepLength.Name = "txt_SuctionPiepLength";
            this.txt_SuctionPiepLength.Size = new System.Drawing.Size(62, 20);
            this.txt_SuctionPiepLength.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Länge";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(183, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "mm";
            // 
            // txt_SuctionPipeDiameter
            // 
            this.txt_SuctionPipeDiameter.Enabled = false;
            this.txt_SuctionPipeDiameter.Location = new System.Drawing.Point(119, 49);
            this.txt_SuctionPipeDiameter.Name = "txt_SuctionPipeDiameter";
            this.txt_SuctionPipeDiameter.Size = new System.Drawing.Size(62, 20);
            this.txt_SuctionPipeDiameter.TabIndex = 21;
            // 
            // cbx_CalcSuctionPipe
            // 
            this.cbx_CalcSuctionPipe.AutoSize = true;
            this.cbx_CalcSuctionPipe.Location = new System.Drawing.Point(18, 26);
            this.cbx_CalcSuctionPipe.Name = "cbx_CalcSuctionPipe";
            this.cbx_CalcSuctionPipe.Size = new System.Drawing.Size(198, 17);
            this.cbx_CalcSuctionPipe.TabIndex = 5;
            this.cbx_CalcSuctionPipe.Text = "Saugseitigen Druckabfall berechnen";
            this.cbx_CalcSuctionPipe.UseVisualStyleBackColor = true;
            this.cbx_CalcSuctionPipe.CheckedChanged += new System.EventHandler(this.cbx_CalcSuctionPipe_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Innendurchmesser";
            // 
            // btn_ShowPowerPoint
            // 
            this.btn_ShowPowerPoint.Enabled = false;
            this.btn_ShowPowerPoint.Location = new System.Drawing.Point(25, 380);
            this.btn_ShowPowerPoint.Name = "btn_ShowPowerPoint";
            this.btn_ShowPowerPoint.Size = new System.Drawing.Size(219, 39);
            this.btn_ShowPowerPoint.TabIndex = 19;
            this.btn_ShowPowerPoint.Text = "Arbeitspunkt anzeigen";
            this.btn_ShowPowerPoint.UseVisualStyleBackColor = true;
            this.btn_ShowPowerPoint.Click += new System.EventHandler(this.btn_ShowPowerPoint_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "bar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stToolStripMenuItem,
            this.überToolStripMenuItem,
            this.fittingsToolStripMenuItem,
            this.rechnerToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
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
            this.stToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.stToolStripMenuItem.Text = "Datei";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.einstellungenToolStripMenuItem.Text = "Voreinstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.überToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.überToolStripMenuItem.Text = "Pumpe";
            // 
            // auswahlPumpeToolStripMenuItem
            // 
            this.auswahlPumpeToolStripMenuItem.Enabled = false;
            this.auswahlPumpeToolStripMenuItem.Name = "auswahlPumpeToolStripMenuItem";
            this.auswahlPumpeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.auswahlPumpeToolStripMenuItem.Text = "Auswahl Pumpe";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // suchverzeichnisToolStripMenuItem
            // 
            this.suchverzeichnisToolStripMenuItem.Name = "suchverzeichnisToolStripMenuItem";
            this.suchverzeichnisToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.suchverzeichnisToolStripMenuItem.Text = "Suchverzeichnis...";
            this.suchverzeichnisToolStripMenuItem.Click += new System.EventHandler(this.searchPathPumpsToolStripMenuItem_Click);
            // 
            // ladePumpendefinitionToolStripMenuItem
            // 
            this.ladePumpendefinitionToolStripMenuItem.Name = "ladePumpendefinitionToolStripMenuItem";
            this.ladePumpendefinitionToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.ladePumpendefinitionToolStripMenuItem.Text = "Lade Pumpendefinition...";
            this.ladePumpendefinitionToolStripMenuItem.Click += new System.EventHandler(this.btn_LoadPump_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // editorStartenToolStripMenuItem
            // 
            this.editorStartenToolStripMenuItem.Enabled = false;
            this.editorStartenToolStripMenuItem.Name = "editorStartenToolStripMenuItem";
            this.editorStartenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.editorStartenToolStripMenuItem.Text = "Editor starten";
            this.editorStartenToolStripMenuItem.Click += new System.EventHandler(this.editorStartenToolStripMenuItem_Click);
            // 
            // fittingsToolStripMenuItem
            // 
            this.fittingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suchverzeichnisToolStripMenuItem1});
            this.fittingsToolStripMenuItem.Name = "fittingsToolStripMenuItem";
            this.fittingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fittingsToolStripMenuItem.Text = "Fittings";
            // 
            // suchverzeichnisToolStripMenuItem1
            // 
            this.suchverzeichnisToolStripMenuItem1.Name = "suchverzeichnisToolStripMenuItem1";
            this.suchverzeichnisToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.suchverzeichnisToolStripMenuItem1.Text = "Suchverzeichnis...";
            this.suchverzeichnisToolStripMenuItem1.Click += new System.EventHandler(this.searchPathFittingsToolStripMenuItem_Click);
            // 
            // rechnerToolStripMenuItem
            // 
            this.rechnerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volumenstromFließgeschwindigkeitToolStripMenuItem,
            this.äquivalenteRohrlängeToolStripMenuItem});
            this.rechnerToolStripMenuItem.Name = "rechnerToolStripMenuItem";
            this.rechnerToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.rechnerToolStripMenuItem.Text = "Rechner";
            // 
            // volumenstromFließgeschwindigkeitToolStripMenuItem
            // 
            this.volumenstromFließgeschwindigkeitToolStripMenuItem.Name = "volumenstromFließgeschwindigkeitToolStripMenuItem";
            this.volumenstromFließgeschwindigkeitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.volumenstromFließgeschwindigkeitToolStripMenuItem.Text = "p-v-Q";
            this.volumenstromFließgeschwindigkeitToolStripMenuItem.ToolTipText = "Berechnung von Strömungsgeschwindigkeit, Volumenstrom und Druckverlust in Rohrlei" +
    "tungen";
            this.volumenstromFließgeschwindigkeitToolStripMenuItem.Click += new System.EventHandler(this.volumenstromFließgeschwindigkeitToolStripMenuItem_Click);
            // 
            // äquivalenteRohrlängeToolStripMenuItem
            // 
            this.äquivalenteRohrlängeToolStripMenuItem.Name = "äquivalenteRohrlängeToolStripMenuItem";
            this.äquivalenteRohrlängeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.äquivalenteRohrlängeToolStripMenuItem.Text = "Äquivalente Rohrlänge";
            this.äquivalenteRohrlängeToolStripMenuItem.ToolTipText = "Berechnung der äquivalente Rohrlänge in Abhängigkeit der verbauten Fittings und A" +
    "rmaturen";
            this.äquivalenteRohrlängeToolStripMenuItem.Click += new System.EventHandler(this.äquivalenteRohrlängeToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem1});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // überToolStripMenuItem1
            // 
            this.überToolStripMenuItem1.Name = "überToolStripMenuItem1";
            this.überToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.überToolStripMenuItem1.Text = "Über";
            this.überToolStripMenuItem1.Click += new System.EventHandler(this.überToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stl_PumpSearchDirectory,
            this.stl_Info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(781, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stl_PumpSearchDirectory
            // 
            this.stl_PumpSearchDirectory.Name = "stl_PumpSearchDirectory";
            this.stl_PumpSearchDirectory.Size = new System.Drawing.Size(167, 17);
            this.stl_PumpSearchDirectory.Text = "Bitte Suchverzeichnis angeben";
            // 
            // stl_Info
            // 
            this.stl_Info.Name = "stl_Info";
            this.stl_Info.Size = new System.Drawing.Size(599, 17);
            this.stl_Info.Spring = true;
            this.stl_Info.Text = "Bereit";
            this.stl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainView
            // 
            this.AcceptButton = this.btn_CalcFlowRate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 531);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(797, 570);
            this.MinimumSize = new System.Drawing.Size(797, 570);
            this.Name = "MainView";
            this.Text = "FlowCalc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_PumpHeight;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

