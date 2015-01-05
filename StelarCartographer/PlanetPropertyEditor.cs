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
		protected Planet ThePlanet = new Planet();

		public EventHandler Dirty = null;

		public PlanetPropertyEditor()
		{
			InitializeComponent();
		}

		public PlanetPropertyEditor(Planet planet)
		{
			Init(planet);
		}

		bool Loading = false;
		private void CallDirty()
		{
			if (ThePlanet == null || Loading || Dirty == null)
				return;

			Dirty(ThePlanet, EventArgs.Empty);
		}

		public void Init(Planet planet)
		{
			ThePlanet = planet;

			Loading = true;

			if (ThePlanet != null)
			{ 
				PlanetName.Text = planet.Name;
				PlanetType.SelectedIndex = (int)planet.TypeClass;
				PlanetClimate.SelectedIndex = (int)planet.Climate;
				Ringed.Checked = ThePlanet.Ringed;

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
			if (ThePlanet != null)
				ThePlanet.Name = PlanetName.Text;
			CallDirty();
		}

		private void PlanetType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ThePlanet != null)
				ThePlanet.TypeClass = (Planet.TypeClasses)PlanetType.SelectedIndex;
			CallDirty();
		}

		private void PlanetClimate_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ThePlanet != null)
				ThePlanet.Climate = (Planet.Climates)PlanetClimate.SelectedIndex;
			CallDirty();
		}

		private void Ringed_CheckedChanged(object sender, EventArgs e)
		{
			if (ThePlanet != null)
				ThePlanet.Ringed = Ringed.Checked;
			CallDirty();
		}

		private void MassEdit_ValueChanged(object sender, EventArgs e)
		{
			if (ThePlanet != null)
				ThePlanet.Mass = (double)MassEdit.Value;
			CallDirty();
		}

		private void RadiusEdit_ValueChanged(object sender, EventArgs e)
		{
			if (ThePlanet != null)
				ThePlanet.Radius = (double)RadiusEdit.Value;
			CallDirty();
		}

		private void OrbitEdit_ValueChanged(object sender, EventArgs e)
		{
			if (ThePlanet != null)
				ThePlanet.OrbitalRadius = (double)OrbitEdit.Value;
			CallDirty();
		}

		private void AngleEdit_ValueChanged(object sender, EventArgs e)
		{
			if (ThePlanet != null)
				ThePlanet.SyncAngle = (double)AngleEdit.Value;
			CallDirty();
		}
	}
}
