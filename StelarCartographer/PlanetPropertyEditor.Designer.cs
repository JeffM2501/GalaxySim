namespace StelarCartographer
{
	partial class PlanetPropertyEditor
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.AngleEdit = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.RadiusEdit = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.OrbitEdit = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.MassEdit = new System.Windows.Forms.NumericUpDown();
			this.Ringed = new System.Windows.Forms.CheckBox();
			this.PlanetClimate = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.PlanetType = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.Type = new System.Windows.Forms.Label();
			this.PlanetName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.AngleEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RadiusEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrbitEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MassEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// AngleEdit
			// 
			this.AngleEdit.DecimalPlaces = 4;
			this.AngleEdit.Location = new System.Drawing.Point(279, 94);
			this.AngleEdit.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
			this.AngleEdit.Name = "AngleEdit";
			this.AngleEdit.Size = new System.Drawing.Size(129, 20);
			this.AngleEdit.TabIndex = 44;
			this.AngleEdit.ValueChanged += new System.EventHandler(this.AngleEdit_ValueChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(200, 96);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(67, 13);
			this.label15.TabIndex = 43;
			this.label15.Text = "Orbital Angle";
			// 
			// RadiusEdit
			// 
			this.RadiusEdit.DecimalPlaces = 4;
			this.RadiusEdit.Location = new System.Drawing.Point(255, 68);
			this.RadiusEdit.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
			this.RadiusEdit.Name = "RadiusEdit";
			this.RadiusEdit.Size = new System.Drawing.Size(153, 20);
			this.RadiusEdit.TabIndex = 42;
			this.RadiusEdit.ValueChanged += new System.EventHandler(this.RadiusEdit_ValueChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(209, 70);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(40, 13);
			this.label14.TabIndex = 41;
			this.label14.Text = "Radius";
			// 
			// OrbitEdit
			// 
			this.OrbitEdit.DecimalPlaces = 4;
			this.OrbitEdit.Location = new System.Drawing.Point(87, 94);
			this.OrbitEdit.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
			this.OrbitEdit.Name = "OrbitEdit";
			this.OrbitEdit.Size = new System.Drawing.Size(107, 20);
			this.OrbitEdit.TabIndex = 40;
			this.OrbitEdit.ValueChanged += new System.EventHandler(this.OrbitEdit_ValueChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(8, 96);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(73, 13);
			this.label13.TabIndex = 39;
			this.label13.Text = "Orbital Raidus";
			// 
			// MassEdit
			// 
			this.MassEdit.DecimalPlaces = 4;
			this.MassEdit.Location = new System.Drawing.Point(46, 68);
			this.MassEdit.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
			this.MassEdit.Name = "MassEdit";
			this.MassEdit.Size = new System.Drawing.Size(148, 20);
			this.MassEdit.TabIndex = 38;
			this.MassEdit.ValueChanged += new System.EventHandler(this.MassEdit_ValueChanged);
			// 
			// Ringed
			// 
			this.Ringed.AutoSize = true;
			this.Ringed.Location = new System.Drawing.Point(11, 131);
			this.Ringed.Name = "Ringed";
			this.Ringed.Size = new System.Drawing.Size(60, 17);
			this.Ringed.TabIndex = 37;
			this.Ringed.Text = "Ringed";
			this.Ringed.UseVisualStyleBackColor = true;
			this.Ringed.CheckedChanged += new System.EventHandler(this.Ringed_CheckedChanged);
			// 
			// PlanetClimate
			// 
			this.PlanetClimate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PlanetClimate.FormattingEnabled = true;
			this.PlanetClimate.Items.AddRange(new object[] {
            "Baren",
            "Frozen",
            "Cold",
            "Cool",
            "Temperate",
            "Warm",
            "Hot",
            "Molten"});
			this.PlanetClimate.Location = new System.Drawing.Point(247, 39);
			this.PlanetClimate.Name = "PlanetClimate";
			this.PlanetClimate.Size = new System.Drawing.Size(161, 21);
			this.PlanetClimate.TabIndex = 36;
			this.PlanetClimate.SelectedIndexChanged += new System.EventHandler(this.PlanetClimate_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(200, 42);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(41, 13);
			this.label11.TabIndex = 35;
			this.label11.Text = "Climate";
			// 
			// PlanetType
			// 
			this.PlanetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PlanetType.FormattingEnabled = true;
			this.PlanetType.Items.AddRange(new object[] {
            "Selena",
            "Desert",
            "Terestrial",
            "Fluid",
            "Gasious"});
			this.PlanetType.Location = new System.Drawing.Point(45, 39);
			this.PlanetType.Name = "PlanetType";
			this.PlanetType.Size = new System.Drawing.Size(149, 21);
			this.PlanetType.TabIndex = 34;
			this.PlanetType.SelectedIndexChanged += new System.EventHandler(this.PlanetType_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(8, 70);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 13);
			this.label12.TabIndex = 32;
			this.label12.Text = "Mass";
			// 
			// Type
			// 
			this.Type.AutoSize = true;
			this.Type.Location = new System.Drawing.Point(8, 42);
			this.Type.Name = "Type";
			this.Type.Size = new System.Drawing.Size(31, 13);
			this.Type.TabIndex = 33;
			this.Type.Text = "Type";
			// 
			// PlanetName
			// 
			this.PlanetName.Location = new System.Drawing.Point(45, 3);
			this.PlanetName.Name = "PlanetName";
			this.PlanetName.Size = new System.Drawing.Size(363, 20);
			this.PlanetName.TabIndex = 31;
			this.PlanetName.TextChanged += new System.EventHandler(this.PlanetName_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(4, 6);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 30;
			this.label10.Text = "Name";
			// 
			// PlanetPropertyEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.AngleEdit);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.RadiusEdit);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.OrbitEdit);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.MassEdit);
			this.Controls.Add(this.Ringed);
			this.Controls.Add(this.PlanetClimate);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.PlanetType);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.Type);
			this.Controls.Add(this.PlanetName);
			this.Controls.Add(this.label10);
			this.Name = "PlanetPropertyEditor";
			this.Size = new System.Drawing.Size(416, 160);
			((System.ComponentModel.ISupportInitialize)(this.AngleEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RadiusEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrbitEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MassEdit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown AngleEdit;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown RadiusEdit;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown OrbitEdit;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown MassEdit;
		private System.Windows.Forms.CheckBox Ringed;
		private System.Windows.Forms.ComboBox PlanetClimate;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox PlanetType;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label Type;
		private System.Windows.Forms.TextBox PlanetName;
		private System.Windows.Forms.Label label10;
	}
}
