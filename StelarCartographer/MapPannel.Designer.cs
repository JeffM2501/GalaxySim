namespace StelarCartographer
{
	partial class MapPannel
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadRegonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveRegonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.importStarChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label6 = new System.Windows.Forms.Label();
			this.StarSystemList = new System.Windows.Forms.ListBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.SystemInfoTab = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.StarSystemLocationInfo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.StarSystemName = new System.Windows.Forms.TextBox();
			this.LocalNameLabel = new System.Windows.Forms.Label();
			this.StarSystemLocalName = new System.Windows.Forms.TextBox();
			this.StarsTab = new System.Windows.Forms.TabPage();
			this.label8 = new System.Windows.Forms.Label();
			this.StarList = new System.Windows.Forms.ListBox();
			this.StarMagnitude = new System.Windows.Forms.NumericUpDown();
			this.StarCategory = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.StarTempurateure = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Luminosity = new System.Windows.Forms.NumericUpDown();
			this.PlanetsTab = new System.Windows.Forms.TabPage();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.DebrisName = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.RemoveDebris = new System.Windows.Forms.Button();
			this.AddDebris = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.DebrisFieldList = new System.Windows.Forms.ListBox();
			this.RemoveSatelite = new System.Windows.Forms.Button();
			this.AddSatelite = new System.Windows.Forms.Button();
			this.DeletePlanet = new System.Windows.Forms.Button();
			this.AddPlanet = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.SatelitesList = new System.Windows.Forms.ListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.PlanetList = new System.Windows.Forms.ListBox();
			this.SateliteInfo = new StelarCartographer.PlanetPropertyEditor();
			this.PlanetInfo = new StelarCartographer.PlanetPropertyEditor();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SystemInfoTab.SuspendLayout();
			this.StarsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StarMagnitude)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StarTempurateure)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Luminosity)).BeginInit();
			this.PlanetsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(764, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadRegonToolStripMenuItem,
            this.saveRegonToolStripMenuItem,
            this.toolStripSeparator1,
            this.importStarChartToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadRegonToolStripMenuItem
			// 
			this.loadRegonToolStripMenuItem.Name = "loadRegonToolStripMenuItem";
			this.loadRegonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.loadRegonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.loadRegonToolStripMenuItem.Text = "Load Regon";
			this.loadRegonToolStripMenuItem.Click += new System.EventHandler(this.loadRegonToolStripMenuItem_Click);
			// 
			// saveRegonToolStripMenuItem
			// 
			this.saveRegonToolStripMenuItem.Name = "saveRegonToolStripMenuItem";
			this.saveRegonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveRegonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveRegonToolStripMenuItem.Text = "Save Regon";
			this.saveRegonToolStripMenuItem.Click += new System.EventHandler(this.saveRegonToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// importStarChartToolStripMenuItem
			// 
			this.importStarChartToolStripMenuItem.Name = "importStarChartToolStripMenuItem";
			this.importStarChartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.importStarChartToolStripMenuItem.Text = "Import Star Chart";
			this.importStarChartToolStripMenuItem.Click += new System.EventHandler(this.importStarChartToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label6);
			this.splitContainer1.Panel1.Controls.Add(this.StarSystemList);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(764, 535);
			this.splitContainer1.SplitterDistance = 149;
			this.splitContainer1.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Star Systems";
			// 
			// StarSystemList
			// 
			this.StarSystemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StarSystemList.FormattingEnabled = true;
			this.StarSystemList.Location = new System.Drawing.Point(0, 26);
			this.StarSystemList.Name = "StarSystemList";
			this.StarSystemList.Size = new System.Drawing.Size(115, 368);
			this.StarSystemList.TabIndex = 0;
			this.StarSystemList.SelectedIndexChanged += new System.EventHandler(this.StarSystemList_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.SystemInfoTab);
			this.tabControl1.Controls.Add(this.StarsTab);
			this.tabControl1.Controls.Add(this.PlanetsTab);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(611, 535);
			this.tabControl1.TabIndex = 13;
			// 
			// SystemInfoTab
			// 
			this.SystemInfoTab.Controls.Add(this.label7);
			this.SystemInfoTab.Controls.Add(this.StarSystemLocationInfo);
			this.SystemInfoTab.Controls.Add(this.label1);
			this.SystemInfoTab.Controls.Add(this.StarSystemName);
			this.SystemInfoTab.Controls.Add(this.LocalNameLabel);
			this.SystemInfoTab.Controls.Add(this.StarSystemLocalName);
			this.SystemInfoTab.Location = new System.Drawing.Point(4, 22);
			this.SystemInfoTab.Name = "SystemInfoTab";
			this.SystemInfoTab.Padding = new System.Windows.Forms.Padding(3);
			this.SystemInfoTab.Size = new System.Drawing.Size(603, 509);
			this.SystemInfoTab.TabIndex = 0;
			this.SystemInfoTab.Text = "System Info";
			this.SystemInfoTab.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 53);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Location Info";
			// 
			// StarSystemLocationInfo
			// 
			this.StarSystemLocationInfo.Location = new System.Drawing.Point(11, 69);
			this.StarSystemLocationInfo.Multiline = true;
			this.StarSystemLocationInfo.Name = "StarSystemLocationInfo";
			this.StarSystemLocationInfo.ReadOnly = true;
			this.StarSystemLocationInfo.Size = new System.Drawing.Size(531, 181);
			this.StarSystemLocationInfo.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// StarSystemName
			// 
			this.StarSystemName.Location = new System.Drawing.Point(47, 15);
			this.StarSystemName.Name = "StarSystemName";
			this.StarSystemName.Size = new System.Drawing.Size(211, 20);
			this.StarSystemName.TabIndex = 2;
			// 
			// LocalNameLabel
			// 
			this.LocalNameLabel.AutoSize = true;
			this.LocalNameLabel.Location = new System.Drawing.Point(264, 18);
			this.LocalNameLabel.Name = "LocalNameLabel";
			this.LocalNameLabel.Size = new System.Drawing.Size(61, 13);
			this.LocalNameLabel.TabIndex = 3;
			this.LocalNameLabel.Text = "LocalName";
			// 
			// StarSystemLocalName
			// 
			this.StarSystemLocalName.Location = new System.Drawing.Point(331, 15);
			this.StarSystemLocalName.Name = "StarSystemLocalName";
			this.StarSystemLocalName.Size = new System.Drawing.Size(211, 20);
			this.StarSystemLocalName.TabIndex = 4;
			this.StarSystemLocalName.TextChanged += new System.EventHandler(this.StarSystemLocalName_TextChanged);
			// 
			// StarsTab
			// 
			this.StarsTab.Controls.Add(this.label8);
			this.StarsTab.Controls.Add(this.StarList);
			this.StarsTab.Controls.Add(this.StarMagnitude);
			this.StarsTab.Controls.Add(this.StarCategory);
			this.StarsTab.Controls.Add(this.label5);
			this.StarsTab.Controls.Add(this.label2);
			this.StarsTab.Controls.Add(this.StarTempurateure);
			this.StarsTab.Controls.Add(this.label3);
			this.StarsTab.Controls.Add(this.label4);
			this.StarsTab.Controls.Add(this.Luminosity);
			this.StarsTab.Location = new System.Drawing.Point(4, 22);
			this.StarsTab.Name = "StarsTab";
			this.StarsTab.Padding = new System.Windows.Forms.Padding(3);
			this.StarsTab.Size = new System.Drawing.Size(603, 509);
			this.StarsTab.TabIndex = 1;
			this.StarsTab.Text = "Stars";
			this.StarsTab.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 4);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Stars";
			// 
			// StarList
			// 
			this.StarList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StarList.FormattingEnabled = true;
			this.StarList.Location = new System.Drawing.Point(6, 20);
			this.StarList.Name = "StarList";
			this.StarList.Size = new System.Drawing.Size(123, 225);
			this.StarList.TabIndex = 1;
			this.StarList.SelectedIndexChanged += new System.EventHandler(this.StarList_SelectedIndexChanged);
			// 
			// StarMagnitude
			// 
			this.StarMagnitude.Location = new System.Drawing.Point(411, 43);
			this.StarMagnitude.Name = "StarMagnitude";
			this.StarMagnitude.Size = new System.Drawing.Size(103, 20);
			this.StarMagnitude.TabIndex = 12;
			this.StarMagnitude.ValueChanged += new System.EventHandler(this.StarMagnitude_ValueChanged);
			// 
			// StarCategory
			// 
			this.StarCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.StarCategory.FormattingEnabled = true;
			this.StarCategory.Items.AddRange(new object[] {
            "O",
            "B",
            "A",
            "F",
            "G",
            "K",
            "M",
            "L",
            "T",
            "Unknown"});
			this.StarCategory.Location = new System.Drawing.Point(212, 17);
			this.StarCategory.Name = "StarCategory";
			this.StarCategory.Size = new System.Drawing.Size(121, 21);
			this.StarCategory.TabIndex = 6;
			this.StarCategory.SelectedIndexChanged += new System.EventHandler(this.StarCategory_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(338, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Magnitude";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(157, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Category";
			// 
			// StarTempurateure
			// 
			this.StarTempurateure.Location = new System.Drawing.Point(411, 18);
			this.StarTempurateure.Name = "StarTempurateure";
			this.StarTempurateure.Size = new System.Drawing.Size(103, 20);
			this.StarTempurateure.TabIndex = 10;
			this.StarTempurateure.ValueChanged += new System.EventHandler(this.StarTempurateure_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(157, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Luminosity";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(338, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Temperature";
			// 
			// Luminosity
			// 
			this.Luminosity.Location = new System.Drawing.Point(213, 43);
			this.Luminosity.Name = "Luminosity";
			this.Luminosity.Size = new System.Drawing.Size(120, 20);
			this.Luminosity.TabIndex = 8;
			this.Luminosity.ValueChanged += new System.EventHandler(this.Luminosity_ValueChanged);
			// 
			// PlanetsTab
			// 
			this.PlanetsTab.Controls.Add(this.numericUpDown4);
			this.PlanetsTab.Controls.Add(this.label15);
			this.PlanetsTab.Controls.Add(this.numericUpDown3);
			this.PlanetsTab.Controls.Add(this.label14);
			this.PlanetsTab.Controls.Add(this.numericUpDown2);
			this.PlanetsTab.Controls.Add(this.label13);
			this.PlanetsTab.Controls.Add(this.numericUpDown1);
			this.PlanetsTab.Controls.Add(this.label16);
			this.PlanetsTab.Controls.Add(this.DebrisName);
			this.PlanetsTab.Controls.Add(this.label12);
			this.PlanetsTab.Controls.Add(this.RemoveDebris);
			this.PlanetsTab.Controls.Add(this.AddDebris);
			this.PlanetsTab.Controls.Add(this.label11);
			this.PlanetsTab.Controls.Add(this.DebrisFieldList);
			this.PlanetsTab.Controls.Add(this.RemoveSatelite);
			this.PlanetsTab.Controls.Add(this.AddSatelite);
			this.PlanetsTab.Controls.Add(this.DeletePlanet);
			this.PlanetsTab.Controls.Add(this.AddPlanet);
			this.PlanetsTab.Controls.Add(this.label10);
			this.PlanetsTab.Controls.Add(this.SateliteInfo);
			this.PlanetsTab.Controls.Add(this.SatelitesList);
			this.PlanetsTab.Controls.Add(this.label9);
			this.PlanetsTab.Controls.Add(this.PlanetInfo);
			this.PlanetsTab.Controls.Add(this.PlanetList);
			this.PlanetsTab.Location = new System.Drawing.Point(4, 22);
			this.PlanetsTab.Name = "PlanetsTab";
			this.PlanetsTab.Size = new System.Drawing.Size(603, 509);
			this.PlanetsTab.TabIndex = 2;
			this.PlanetsTab.Text = "Planets";
			this.PlanetsTab.UseVisualStyleBackColor = true;
			this.PlanetsTab.Click += new System.EventHandler(this.PlanetsTab_Click);
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown4.Location = new System.Drawing.Point(440, 430);
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(124, 20);
			this.numericUpDown4.TabIndex = 52;
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(367, 432);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(67, 13);
			this.label15.TabIndex = 51;
			this.label15.Text = "Orbital Angle";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown3.Location = new System.Drawing.Point(440, 404);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(124, 20);
			this.numericUpDown3.TabIndex = 50;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(365, 406);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(69, 13);
			this.label14.TabIndex = 49;
			this.label14.Text = "Outer Radius";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown2.Location = new System.Drawing.Point(193, 430);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(157, 20);
			this.numericUpDown2.TabIndex = 48;
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(164, 432);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(23, 13);
			this.label13.TabIndex = 47;
			this.label13.Text = "Arc";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown1.Location = new System.Drawing.Point(237, 404);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(113, 20);
			this.numericUpDown1.TabIndex = 46;
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(164, 406);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(67, 13);
			this.label16.TabIndex = 45;
			this.label16.Text = "Inner Radius";
			// 
			// DebrisName
			// 
			this.DebrisName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DebrisName.Location = new System.Drawing.Point(202, 378);
			this.DebrisName.Name = "DebrisName";
			this.DebrisName.Size = new System.Drawing.Size(350, 20);
			this.DebrisName.TabIndex = 29;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(155, 381);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(35, 13);
			this.label12.TabIndex = 28;
			this.label12.Text = "Name";
			// 
			// RemoveDebris
			// 
			this.RemoveDebris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemoveDebris.Location = new System.Drawing.Point(91, 482);
			this.RemoveDebris.Name = "RemoveDebris";
			this.RemoveDebris.Size = new System.Drawing.Size(57, 23);
			this.RemoveDebris.TabIndex = 27;
			this.RemoveDebris.Text = "Delete";
			this.RemoveDebris.UseVisualStyleBackColor = true;
			// 
			// AddDebris
			// 
			this.AddDebris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddDebris.Location = new System.Drawing.Point(3, 482);
			this.AddDebris.Name = "AddDebris";
			this.AddDebris.Size = new System.Drawing.Size(57, 23);
			this.AddDebris.TabIndex = 26;
			this.AddDebris.Text = "Add";
			this.AddDebris.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(0, 365);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(67, 13);
			this.label11.TabIndex = 25;
			this.label11.Text = "Debris Fields";
			// 
			// DebrisFieldList
			// 
			this.DebrisFieldList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DebrisFieldList.FormattingEnabled = true;
			this.DebrisFieldList.Location = new System.Drawing.Point(3, 381);
			this.DebrisFieldList.Name = "DebrisFieldList";
			this.DebrisFieldList.Size = new System.Drawing.Size(145, 95);
			this.DebrisFieldList.TabIndex = 24;
			// 
			// RemoveSatelite
			// 
			this.RemoveSatelite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemoveSatelite.Location = new System.Drawing.Point(91, 339);
			this.RemoveSatelite.Name = "RemoveSatelite";
			this.RemoveSatelite.Size = new System.Drawing.Size(57, 23);
			this.RemoveSatelite.TabIndex = 22;
			this.RemoveSatelite.Text = "Delete";
			this.RemoveSatelite.UseVisualStyleBackColor = true;
			this.RemoveSatelite.Click += new System.EventHandler(this.RemoveSatelite_Click);
			// 
			// AddSatelite
			// 
			this.AddSatelite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddSatelite.Location = new System.Drawing.Point(3, 339);
			this.AddSatelite.Name = "AddSatelite";
			this.AddSatelite.Size = new System.Drawing.Size(57, 23);
			this.AddSatelite.TabIndex = 21;
			this.AddSatelite.Text = "Add";
			this.AddSatelite.UseVisualStyleBackColor = true;
			this.AddSatelite.Click += new System.EventHandler(this.AddSatelite_Click);
			// 
			// DeletePlanet
			// 
			this.DeletePlanet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DeletePlanet.Location = new System.Drawing.Point(91, 156);
			this.DeletePlanet.Name = "DeletePlanet";
			this.DeletePlanet.Size = new System.Drawing.Size(57, 23);
			this.DeletePlanet.TabIndex = 20;
			this.DeletePlanet.Text = "Delete";
			this.DeletePlanet.UseVisualStyleBackColor = true;
			this.DeletePlanet.Click += new System.EventHandler(this.DeletePlanet_Click);
			// 
			// AddPlanet
			// 
			this.AddPlanet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddPlanet.Location = new System.Drawing.Point(3, 156);
			this.AddPlanet.Name = "AddPlanet";
			this.AddPlanet.Size = new System.Drawing.Size(57, 23);
			this.AddPlanet.TabIndex = 19;
			this.AddPlanet.Text = "Add";
			this.AddPlanet.UseVisualStyleBackColor = true;
			this.AddPlanet.Click += new System.EventHandler(this.AddPlanet_Click);
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(0, 186);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Satelites";
			// 
			// SatelitesList
			// 
			this.SatelitesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SatelitesList.FormattingEnabled = true;
			this.SatelitesList.Location = new System.Drawing.Point(3, 202);
			this.SatelitesList.Name = "SatelitesList";
			this.SatelitesList.Size = new System.Drawing.Size(145, 134);
			this.SatelitesList.TabIndex = 17;
			this.SatelitesList.SelectedIndexChanged += new System.EventHandler(this.SatelitesList_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(0, 3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 13);
			this.label9.TabIndex = 15;
			this.label9.Text = "Planets";
			// 
			// PlanetList
			// 
			this.PlanetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PlanetList.FormattingEnabled = true;
			this.PlanetList.Location = new System.Drawing.Point(3, 19);
			this.PlanetList.Name = "PlanetList";
			this.PlanetList.Size = new System.Drawing.Size(145, 134);
			this.PlanetList.TabIndex = 14;
			this.PlanetList.SelectedIndexChanged += new System.EventHandler(this.PlanetList_SelectedIndexChanged);
			// 
			// SateliteInfo
			// 
			this.SateliteInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SateliteInfo.Location = new System.Drawing.Point(154, 202);
			this.SateliteInfo.Name = "SateliteInfo";
			this.SateliteInfo.Size = new System.Drawing.Size(416, 160);
			this.SateliteInfo.TabIndex = 23;
			// 
			// PlanetInfo
			// 
			this.PlanetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PlanetInfo.Location = new System.Drawing.Point(154, 19);
			this.PlanetInfo.Name = "PlanetInfo";
			this.PlanetInfo.Size = new System.Drawing.Size(416, 160);
			this.PlanetInfo.TabIndex = 16;
			// 
			// MapPannel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 559);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MapPannel";
			this.Text = "Stellar Cartographer";
			this.Load += new System.EventHandler(this.MapPannel_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.SystemInfoTab.ResumeLayout(false);
			this.SystemInfoTab.PerformLayout();
			this.StarsTab.ResumeLayout(false);
			this.StarsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.StarMagnitude)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StarTempurateure)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Luminosity)).EndInit();
			this.PlanetsTab.ResumeLayout(false);
			this.PlanetsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadRegonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox StarSystemList;
		private System.Windows.Forms.ToolStripMenuItem saveRegonToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem importStarChartToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ComboBox StarCategory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox StarSystemLocalName;
		private System.Windows.Forms.Label LocalNameLabel;
		private System.Windows.Forms.TextBox StarSystemName;
		private System.Windows.Forms.ListBox StarList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown Luminosity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown StarTempurateure;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown StarMagnitude;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage SystemInfoTab;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox StarSystemLocationInfo;
		private System.Windows.Forms.TabPage StarsTab;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage PlanetsTab;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ListBox PlanetList;
		private System.Windows.Forms.TextBox DebrisName;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button RemoveDebris;
		private System.Windows.Forms.Button AddDebris;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ListBox DebrisFieldList;
		private PlanetPropertyEditor SateliteInfo;
		private System.Windows.Forms.Button RemoveSatelite;
		private System.Windows.Forms.Button AddSatelite;
		private System.Windows.Forms.Button DeletePlanet;
		private System.Windows.Forms.Button AddPlanet;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ListBox SatelitesList;
		private PlanetPropertyEditor PlanetInfo;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label16;
	}
}

