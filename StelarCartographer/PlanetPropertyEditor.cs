using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GalaxySim;
using GalaxySim.CoordinateSystems;

namespace StelarCartographer
{
	public partial class PlanetPropertyEditor : UserControl
	{
		protected StarSystem.Planet Planet = new StarSystem.Planet();

		public EventHandler Dirty = null;

		public PlanetPropertyEditor()
		{
			InitializeComponent();
		}

		public PlanetPropertyEditor(StarSystem.Planet planet)
		{
			Init(planet);
		}

		bool Loading = false;
		private void CallDirty()
		{
			if (Planet == null || Loading || Dirty == null)
				return;

			Dirty(Planet, EventArgs.Empty);
		}

		public void Init(StarSystem.Planet planet)
		{
			Planet = planet;

			Loading = true;

			if (Planet != null)
			{ 
				PlanetName.Text = planet.Name;
				PlanetType.SelectedIndex = (int)planet.TypeClass;
				PlanetClimate.SelectedIndex = (int)planet.Climate;
				Ringed.Checked = Planet.Ringed;

				MassEdit.Value = (decimal)planet.Mass;
				RadiusEdit.Value = (decimal)planet.Radius;
				OrbitEdit.Value = (decimal)planet.OrbitalRadius;
				AngleEdit.Value = (decimal)planet.SyncAngle;
			}
			else
			{
				PlanetName.Text = string.Empty;
				PlanetType.SelectedIndex = 0;
				PlanetClimate.SelectedIndex = 0;
				Ringed.Checked = false;

				MassEdit.Value = 0;
				RadiusEdit.Value = 0;
				OrbitEdit.Value = 0;
				AngleEdit.Value = 0;
			}

			Loading = false;
		}

		private void PlanetName_TextChanged(object sender, EventArgs e)
		{
			if (Planet != null)
				Planet.Name = PlanetName.Text;
			CallDirty();
		}

		private void PlanetType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Planet != null)
				Planet.TypeClass = (StarSystem.Planet.TypeClasses)PlanetType.SelectedIndex;
			CallDirty();
		}

		private void PlanetClimate_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Planet != null)
				Planet.Climate = (StarSystem.Planet.Climates)PlanetClimate.SelectedIndex;
			CallDirty();
		}

		private void Ringed_CheckedChanged(object sender, EventArgs e)
		{
			if (Planet != null)
				Planet.Ringed = Ringed.Checked;
			CallDirty();
		}

		private void MassEdit_ValueChanged(object sender, EventArgs e)
		{
			if (Planet != null)
				Planet.Mass = (double)MassEdit.Value;
			CallDirty();
		}

		private void RadiusEdit_ValueChanged(object sender, EventArgs e)
		{
			if (Planet != null)
				Planet.Radius = (double)RadiusEdit.Value;
			CallDirty();
		}

		private void OrbitEdit_ValueChanged(object sender, EventArgs e)
		{
			if (Planet != null)
				Planet.OrbitalRadius = (double)OrbitEdit.Value;
			CallDirty();
		}

		private void AngleEdit_ValueChanged(object sender, EventArgs e)
		{
			if (Planet != null)
				Planet.SyncAngle = (double)AngleEdit.Value;
			CallDirty();
		}
	}
}
