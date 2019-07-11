namespace FlowCalc
{
    partial class CalcView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.close_FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pvqCalc_ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pipeLenghtCalc_ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docu_HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.about_HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Pump = new System.Windows.Forms.TabPage();
            this.dgv_Pumps = new System.Windows.Forms.DataGridView();
            this.tab_Flow = new System.Windows.Forms.TabPage();
            this.tab_FilterSpeed = new System.Windows.Forms.TabPage();
            this.tab_Volume = new System.Windows.Forms.TabPage();
            this.tab_Circualtion = new System.Windows.Forms.TabPage();
            this.col_Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PowerOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FlowRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DynHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaxTotalHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ShowPerformanceCurve = new System.Windows.Forms.Button();
            this.btn_LoadPump = new System.Windows.Forms.Button();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SystemPressure = new System.Windows.Forms.TextBox();
            this.txt_SystemHead = new System.Windows.Forms.TextBox();
            this.btn_CalcFlowRate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SystemFlowRate = new System.Windows.Forms.TextBox();
            this.toolStripStatusLabel_Pump = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_FlowRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.stat_Pump = new System.Windows.Forms.ToolStripStatusLabel();
            this.stat_FlowRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Pump.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pumps)).BeginInit();
            this.tab_Flow.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.close_FileToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.FileToolStripMenuItem.Text = "Datei";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.settingsToolStripMenuItem.Text = "Einstellungen...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // close_FileToolStripMenuItem
            // 
            this.close_FileToolStripMenuItem.Name = "close_FileToolStripMenuItem";
            this.close_FileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.close_FileToolStripMenuItem.Text = "Beenden";
            this.close_FileToolStripMenuItem.Click += new System.EventHandler(this.close_FileToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pvqCalc_ToolsToolStripMenuItem,
            this.pipeLenghtCalc_ToolsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // pvqCalc_ToolsToolStripMenuItem
            // 
            this.pvqCalc_ToolsToolStripMenuItem.Name = "pvqCalc_ToolsToolStripMenuItem";
            this.pvqCalc_ToolsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.pvqCalc_ToolsToolStripMenuItem.Text = "p-v-Q Rohrrechner...";
            // 
            // pipeLenghtCalc_ToolsToolStripMenuItem
            // 
            this.pipeLenghtCalc_ToolsToolStripMenuItem.Name = "pipeLenghtCalc_ToolsToolStripMenuItem";
            this.pipeLenghtCalc_ToolsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.pipeLenghtCalc_ToolsToolStripMenuItem.Text = "Äquivalente Rohrlänge...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docu_HelpToolStripMenuItem,
            this.toolStripSeparator2,
            this.about_HelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Hilfe";
            // 
            // docu_HelpToolStripMenuItem
            // 
            this.docu_HelpToolStripMenuItem.Name = "docu_HelpToolStripMenuItem";
            this.docu_HelpToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.docu_HelpToolStripMenuItem.Text = "Dokumentation";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // about_HelpToolStripMenuItem
            // 
            this.about_HelpToolStripMenuItem.Name = "about_HelpToolStripMenuItem";
            this.about_HelpToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.about_HelpToolStripMenuItem.Text = "Über...";
            this.about_HelpToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Pump,
            this.stat_Pump,
            this.toolStripStatusLabel_FlowRate,
            this.stat_FlowRate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(964, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Pump);
            this.tabControl1.Controls.Add(this.tab_Flow);
            this.tabControl1.Controls.Add(this.tab_FilterSpeed);
            this.tabControl1.Controls.Add(this.tab_Volume);
            this.tabControl1.Controls.Add(this.tab_Circualtion);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 449);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_Pump
            // 
            this.tab_Pump.Controls.Add(this.btn_LoadPump);
            this.tab_Pump.Controls.Add(this.btn_ShowPerformanceCurve);
            this.tab_Pump.Controls.Add(this.dgv_Pumps);
            this.tab_Pump.Location = new System.Drawing.Point(4, 22);
            this.tab_Pump.Name = "tab_Pump";
            this.tab_Pump.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Pump.Size = new System.Drawing.Size(932, 423);
            this.tab_Pump.TabIndex = 4;
            this.tab_Pump.Text = "Pumpe";
            this.tab_Pump.UseVisualStyleBackColor = true;
            // 
            // dgv_Pumps
            // 
            this.dgv_Pumps.AllowUserToAddRows = false;
            this.dgv_Pumps.AllowUserToDeleteRows = false;
            this.dgv_Pumps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pumps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Manufacturer,
            this.col_Name,
            this.col_PowerOut,
            this.col_FlowRate,
            this.col_DynHead,
            this.col_MaxTotalHead});
            this.dgv_Pumps.Location = new System.Drawing.Point(0, 0);
            this.dgv_Pumps.Name = "dgv_Pumps";
            this.dgv_Pumps.ReadOnly = true;
            this.dgv_Pumps.RowHeadersVisible = false;
            this.dgv_Pumps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pumps.Size = new System.Drawing.Size(932, 350);
            this.dgv_Pumps.TabIndex = 0;
            this.dgv_Pumps.SelectionChanged += new System.EventHandler(this.dgv_Pumps_SelectionChanged);
            // 
            // tab_Flow
            // 
            this.tab_Flow.Controls.Add(this.btn_ShowPowerPoint);
            this.tab_Flow.Controls.Add(this.label11);
            this.tab_Flow.Controls.Add(this.label6);
            this.tab_Flow.Controls.Add(this.label8);
            this.tab_Flow.Controls.Add(this.txt_SystemPressure);
            this.tab_Flow.Controls.Add(this.txt_SystemHead);
            this.tab_Flow.Controls.Add(this.btn_CalcFlowRate);
            this.tab_Flow.Controls.Add(this.label7);
            this.tab_Flow.Controls.Add(this.txt_SystemFlowRate);
            this.tab_Flow.Controls.Add(this.groupBox4);
            this.tab_Flow.Location = new System.Drawing.Point(4, 22);
            this.tab_Flow.Name = "tab_Flow";
            this.tab_Flow.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Flow.Size = new System.Drawing.Size(932, 423);
            this.tab_Flow.TabIndex = 0;
            this.tab_Flow.Text = "Förderleistung";
            this.tab_Flow.UseVisualStyleBackColor = true;
            // 
            // tab_FilterSpeed
            // 
            this.tab_FilterSpeed.Location = new System.Drawing.Point(4, 22);
            this.tab_FilterSpeed.Name = "tab_FilterSpeed";
            this.tab_FilterSpeed.Padding = new System.Windows.Forms.Padding(3);
            this.tab_FilterSpeed.Size = new System.Drawing.Size(932, 423);
            this.tab_FilterSpeed.TabIndex = 3;
            this.tab_FilterSpeed.Text = "Filtergeschwindigkeit";
            this.tab_FilterSpeed.UseVisualStyleBackColor = true;
            // 
            // tab_Volume
            // 
            this.tab_Volume.Location = new System.Drawing.Point(4, 22);
            this.tab_Volume.Name = "tab_Volume";
            this.tab_Volume.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Volume.Size = new System.Drawing.Size(932, 423);
            this.tab_Volume.TabIndex = 1;
            this.tab_Volume.Text = "Wasserinhalt";
            this.tab_Volume.UseVisualStyleBackColor = true;
            // 
            // tab_Circualtion
            // 
            this.tab_Circualtion.Location = new System.Drawing.Point(4, 22);
            this.tab_Circualtion.Name = "tab_Circualtion";
            this.tab_Circualtion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Circualtion.Size = new System.Drawing.Size(932, 423);
            this.tab_Circualtion.TabIndex = 2;
            this.tab_Circualtion.Text = "Umwälzleistung";
            this.tab_Circualtion.UseVisualStyleBackColor = true;
            // 
            // col_Manufacturer
            // 
            this.col_Manufacturer.DataPropertyName = "Manufacturer";
            this.col_Manufacturer.HeaderText = "Hersteller";
            this.col_Manufacturer.Name = "col_Manufacturer";
            this.col_Manufacturer.ReadOnly = true;
            this.col_Manufacturer.Width = 240;
            // 
            // col_Name
            // 
            this.col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Name.DataPropertyName = "ModellName";
            this.col_Name.HeaderText = "Modell";
            this.col_Name.Name = "col_Name";
            this.col_Name.ReadOnly = true;
            // 
            // col_PowerOut
            // 
            this.col_PowerOut.DataPropertyName = "PowerOutput";
            this.col_PowerOut.HeaderText = "Leistung";
            this.col_PowerOut.Name = "col_PowerOut";
            this.col_PowerOut.ReadOnly = true;
            // 
            // col_FlowRate
            // 
            this.col_FlowRate.DataPropertyName = "NominalFlowRate";
            this.col_FlowRate.HeaderText = "Förderleistung (nominal)";
            this.col_FlowRate.Name = "col_FlowRate";
            this.col_FlowRate.ReadOnly = true;
            // 
            // col_DynHead
            // 
            this.col_DynHead.DataPropertyName = "NominalDynamicHead";
            this.col_DynHead.HeaderText = "Förderhöhe (nominal)";
            this.col_DynHead.Name = "col_DynHead";
            this.col_DynHead.ReadOnly = true;
            // 
            // col_MaxTotalHead
            // 
            this.col_MaxTotalHead.DataPropertyName = "MaxTotalHead";
            this.col_MaxTotalHead.HeaderText = "Förderhöhe (maximal)";
            this.col_MaxTotalHead.Name = "col_MaxTotalHead";
            this.col_MaxTotalHead.ReadOnly = true;
            // 
            // btn_ShowPerformanceCurve
            // 
            this.btn_ShowPerformanceCurve.Location = new System.Drawing.Point(734, 379);
            this.btn_ShowPerformanceCurve.Name = "btn_ShowPerformanceCurve";
            this.btn_ShowPerformanceCurve.Size = new System.Drawing.Size(180, 23);
            this.btn_ShowPerformanceCurve.TabIndex = 1;
            this.btn_ShowPerformanceCurve.Text = "Pumpenkennline Anzeigen";
            this.btn_ShowPerformanceCurve.UseVisualStyleBackColor = true;
            this.btn_ShowPerformanceCurve.Click += new System.EventHandler(this.btn_ShowPerformanceCurve_Click);
            // 
            // btn_LoadPump
            // 
            this.btn_LoadPump.Location = new System.Drawing.Point(19, 379);
            this.btn_LoadPump.Name = "btn_LoadPump";
            this.btn_LoadPump.Size = new System.Drawing.Size(180, 23);
            this.btn_LoadPump.TabIndex = 2;
            this.btn_LoadPump.Text = "Lade Pumpedefinition...";
            this.btn_LoadPump.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
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
            this.groupBox4.Location = new System.Drawing.Point(91, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 342);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saugseitige Rohrleitung";
            // 
            // btn_CalcLength
            // 
            this.btn_CalcLength.Location = new System.Drawing.Point(20, 262);
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
            this.txt_PipeSuctionPressureDrop.Location = new System.Drawing.Point(121, 300);
            this.txt_PipeSuctionPressureDrop.Name = "txt_PipeSuctionPressureDrop";
            this.txt_PipeSuctionPressureDrop.Size = new System.Drawing.Size(85, 20);
            this.txt_PipeSuctionPressureDrop.TabIndex = 28;
            // 
            // lbl_PipeSuctionPressureDrop
            // 
            this.lbl_PipeSuctionPressureDrop.AutoSize = true;
            this.lbl_PipeSuctionPressureDrop.Location = new System.Drawing.Point(17, 303);
            this.lbl_PipeSuctionPressureDrop.Name = "lbl_PipeSuctionPressureDrop";
            this.lbl_PipeSuctionPressureDrop.Size = new System.Drawing.Size(88, 13);
            this.lbl_PipeSuctionPressureDrop.TabIndex = 27;
            this.lbl_PipeSuctionPressureDrop.Text = "Pumpenvordruck";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(185, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "m";
            // 
            // txt_SuctionPiepLength
            // 
            this.txt_SuctionPiepLength.Enabled = false;
            this.txt_SuctionPiepLength.Location = new System.Drawing.Point(121, 234);
            this.txt_SuctionPiepLength.Name = "txt_SuctionPiepLength";
            this.txt_SuctionPiepLength.Size = new System.Drawing.Size(62, 20);
            this.txt_SuctionPiepLength.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Länge";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "mm";
            // 
            // txt_SuctionPipeDiameter
            // 
            this.txt_SuctionPipeDiameter.Enabled = false;
            this.txt_SuctionPipeDiameter.Location = new System.Drawing.Point(121, 208);
            this.txt_SuctionPipeDiameter.Name = "txt_SuctionPipeDiameter";
            this.txt_SuctionPipeDiameter.Size = new System.Drawing.Size(62, 20);
            this.txt_SuctionPipeDiameter.TabIndex = 21;
            // 
            // cbx_CalcSuctionPipe
            // 
            this.cbx_CalcSuctionPipe.AutoSize = true;
            this.cbx_CalcSuctionPipe.Location = new System.Drawing.Point(20, 185);
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
            this.label12.Location = new System.Drawing.Point(17, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Innendurchmesser";
            // 
            // btn_ShowPowerPoint
            // 
            this.btn_ShowPowerPoint.Enabled = false;
            this.btn_ShowPowerPoint.Location = new System.Drawing.Point(623, 337);
            this.btn_ShowPowerPoint.Name = "btn_ShowPowerPoint";
            this.btn_ShowPowerPoint.Size = new System.Drawing.Size(219, 39);
            this.btn_ShowPowerPoint.TabIndex = 32;
            this.btn_ShowPowerPoint.Text = "Arbeitspunkt anzeigen";
            this.btn_ShowPowerPoint.UseVisualStyleBackColor = true;
            this.btn_ShowPowerPoint.Click += new System.EventHandler(this.btn_ShowPowerPoint_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(687, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "bar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Systemdruck";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Meter Wassersäule";
            // 
            // txt_SystemPressure
            // 
            this.txt_SystemPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SystemPressure.Location = new System.Drawing.Point(623, 83);
            this.txt_SystemPressure.Name = "txt_SystemPressure";
            this.txt_SystemPressure.Size = new System.Drawing.Size(62, 24);
            this.txt_SystemPressure.TabIndex = 24;
            // 
            // txt_SystemHead
            // 
            this.txt_SystemHead.Enabled = false;
            this.txt_SystemHead.Location = new System.Drawing.Point(623, 180);
            this.txt_SystemHead.Name = "txt_SystemHead";
            this.txt_SystemHead.Size = new System.Drawing.Size(100, 20);
            this.txt_SystemHead.TabIndex = 29;
            // 
            // btn_CalcFlowRate
            // 
            this.btn_CalcFlowRate.Location = new System.Drawing.Point(504, 127);
            this.btn_CalcFlowRate.Name = "btn_CalcFlowRate";
            this.btn_CalcFlowRate.Size = new System.Drawing.Size(219, 39);
            this.btn_CalcFlowRate.TabIndex = 25;
            this.btn_CalcFlowRate.Text = "Berechne Fördermenge";
            this.btn_CalcFlowRate.UseVisualStyleBackColor = true;
            this.btn_CalcFlowRate.Click += new System.EventHandler(this.btn_CalcFlowRate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Volumenstrom";
            // 
            // txt_SystemFlowRate
            // 
            this.txt_SystemFlowRate.Enabled = false;
            this.txt_SystemFlowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SystemFlowRate.Location = new System.Drawing.Point(623, 206);
            this.txt_SystemFlowRate.Name = "txt_SystemFlowRate";
            this.txt_SystemFlowRate.Size = new System.Drawing.Size(100, 20);
            this.txt_SystemFlowRate.TabIndex = 27;
            // 
            // toolStripStatusLabel_Pump
            // 
            this.toolStripStatusLabel_Pump.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_Pump.Name = "toolStripStatusLabel_Pump";
            this.toolStripStatusLabel_Pump.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel_Pump.Text = "Pumpe:";
            this.toolStripStatusLabel_Pump.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel_FlowRate
            // 
            this.toolStripStatusLabel_FlowRate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_FlowRate.Name = "toolStripStatusLabel_FlowRate";
            this.toolStripStatusLabel_FlowRate.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel_FlowRate.Text = "Volumenstrom:";
            this.toolStripStatusLabel_FlowRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stat_Pump
            // 
            this.stat_Pump.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stat_Pump.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_Pump.Name = "stat_Pump";
            this.stat_Pump.Size = new System.Drawing.Size(119, 17);
            this.stat_Pump.Text = "toolStripStatusLabel1";
            // 
            // stat_FlowRate
            // 
            this.stat_FlowRate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stat_FlowRate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_FlowRate.Name = "stat_FlowRate";
            this.stat_FlowRate.Size = new System.Drawing.Size(121, 17);
            this.stat_FlowRate.Text = "toolStripStatusLabel2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 139);
            this.label1.TabIndex = 30;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // CalcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 501);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CalcView";
            this.Text = "CalcView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_Pump.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pumps)).EndInit();
            this.tab_Flow.ResumeLayout(false);
            this.tab_Flow.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Flow;
        private System.Windows.Forms.TabPage tab_Volume;
        private System.Windows.Forms.TabPage tab_Circualtion;
        private System.Windows.Forms.TabPage tab_FilterSpeed;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem close_FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pvqCalc_ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docu_HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem about_HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pipeLenghtCalc_ToolsToolStripMenuItem;
        private System.Windows.Forms.TabPage tab_Pump;
        private System.Windows.Forms.DataGridView dgv_Pumps;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PowerOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FlowRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DynHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaxTotalHead;
        private System.Windows.Forms.Button btn_LoadPump;
        private System.Windows.Forms.Button btn_ShowPerformanceCurve;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_CalcLength;
        private System.Windows.Forms.TextBox txt_PipeSuctionPressureDrop;
        private System.Windows.Forms.Label lbl_PipeSuctionPressureDrop;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_SuctionPiepLength;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_SuctionPipeDiameter;
        private System.Windows.Forms.CheckBox cbx_CalcSuctionPipe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_ShowPowerPoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SystemPressure;
        private System.Windows.Forms.TextBox txt_SystemHead;
        private System.Windows.Forms.Button btn_CalcFlowRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SystemFlowRate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Pump;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_FlowRate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel stat_Pump;
        private System.Windows.Forms.ToolStripStatusLabel stat_FlowRate;
        private System.Windows.Forms.Label label1;
    }
}