using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using GalaxySim;
using GalaxySim.Utilities;

namespace StelarCartographer
{
	public partial class MapPannel : Form
	{
		public GalaxySim.GalacticRegon Arm = null;

		public GalaxySim.StarSystem CurrentStarSystem = null;
		public GalaxySim.StarSystem.Star CurrentStar= null;
		public GalaxySim.StarSystem.Planet CurrentPlanet = null;
		public GalaxySim.StarSystem.Planet CurrentSatelite = null;
		public GalaxySim.StarSystem.DebrisField CurrentDebrisField = null;

		public FileInfo OutputFile = null;

		private bool RebuildingLists = false;

		private bool Loading = false;

		private SystemRenderer Renderer = null;

		public MapPannel()
		{
			InitializeComponent();
		}

		private void PlanetsTab_Click(object sender, EventArgs e)
		{

		}

		void PopulateSystemList()
		{
			StarSystemList.Items.Clear();
			if (Arm != null)
				StarSystemList.Items.AddRange(Arm.StarSystems.ToArray());

			if (StarSystemList.Items.Count > 0)
				StarSystemList.SelectedIndex = 0;

			Dirty();
		}

		private void importStarChartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Comma Seperated files (*.csv)|*.csv|All files (*.*)|*.*";
			if(ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				Arm = GalaxySim.Utilities.StarParser.ReadStarChart(new System.IO.FileInfo(ofd.FileName));
				PopulateSystemList();
			}
		}

		private void StarSystemList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RebuildingLists)
				return;

			CurrentDebrisField = null;
			CurrentPlanet = null;
			CurrentSatelite = null;
			CurrentStar = null;

			CurrentStarSystem = StarSystemList.SelectedItem as StarSystem;

			if (Renderer != null)
				Renderer.Dispose();

			Renderer = new SystemRenderer(CurrentStarSystem);

			StarList.Items.Clear();
			SatelitesList.Items.Clear();
			PlanetList.Items.Clear();
			DebrisFieldList.Items.Clear();

			PlanetInfo.Init(null);
			SateliteInfo.Init(null);
			RemoveDebris.Enabled = false;
			RemoveSatelite.Enabled = false;
			AddSatelite.Enabled = false;
			DeletePlanet.Enabled = false;

			DebrisName.Text = string.Empty;
			DebrisOrbitalAngle.Value = 0;
			DebrisInnerRadius.Value = 0;
			DebrisOuterRadius.Value = 0;
			DebrisArc.Value = 0;

			if (CurrentStarSystem == null)
			{
				StarSystemName.Text = string.Empty;
				StarSystemLocalName.Text = string.Empty;
				StarSystemLocationInfo.Text = string.Empty;
				PlanetList.SelectedItem = null;
				StarList.SelectedItem = null;
			}
			else
			{
				StarSystemName.Text = CurrentStarSystem.Name;
				StarSystemLocalName.Text = CurrentStarSystem.LocalName;
				StarSystemLocationInfo.Text = string.Empty;

				StarList.Items.AddRange(CurrentStarSystem.Stars.ToArray());
				if (StarList.Items.Count > 0)
					StarList.SelectedIndex = 0;
				else
					StarList.SelectedItem = null;

				PlanetList.Items.AddRange(CurrentStarSystem.Planets.ToArray());
				if (PlanetList.Items.Count > 0)
					PlanetList.SelectedIndex = 0;
				else
					PlanetList.SelectedItem = null;

				DebrisFieldList.Items.AddRange(CurrentStarSystem.DebrisFields.ToArray());

				if (DebrisFieldList.Items.Count > 0)
					DebrisFieldList.SelectedIndex = 0;
				else
					DebrisFieldList.SelectedItem = null;
			}

			AddPlanet.Enabled = CurrentStarSystem != null;
			AddDebris.Enabled = CurrentStarSystem != null;
			Dirty();
		}

		private void StarList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RebuildingLists)
				return;

			CurrentStar = StarList.SelectedItem as StarSystem.Star;
			if (CurrentStarSystem == null)
			{
				StarCategory.SelectedIndex = StarCategory.Items.Count - 1;
				StarTempurateure.Value = 0;
				Luminosity.Value = 0;
				StarMagnitude.Value = 0;
			}
			else
			{
				StarCategory.SelectedIndex = (int)CurrentStar.SpectralType;
				StarTempurateure.Value = (decimal)CurrentStar.Temperature;
				Luminosity.Value = (decimal)CurrentStar.Luminosity;
				StarMagnitude.Value = (decimal)CurrentStar.Magnitude;
			}
		}

		private void PlanetList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RebuildingLists)
				return;

			CurrentPlanet = PlanetList.SelectedItem as StarSystem.Planet;
			SatelitesList.Items.Clear();

			PlanetInfo.Init(CurrentPlanet);

			if (CurrentPlanet != null)
			{
				SatelitesList.Items.AddRange(CurrentPlanet.Satalites.ToArray());
				if (SatelitesList.Items.Count > 0)
					SatelitesList.SelectedIndex = 0;
			}
			DeletePlanet.Enabled = CurrentPlanet != null;
			AddSatelite.Enabled = CurrentPlanet != null;
		}

		private void StarCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			CurrentStar.SpectralType = (StarSystem.Star.SpectraTypes)StarCategory.SelectedIndex;
			Dirty();
		}

		private void StarTempurateure_ValueChanged(object sender, EventArgs e)
		{
			CurrentStar.Temperature = (double)StarTempurateure.Value;
			Dirty();
		}

		private void Luminosity_ValueChanged(object sender, EventArgs e)
		{
			CurrentStar.Luminosity = (double)Luminosity.Value;
			Dirty();
		}

		private void StarMagnitude_ValueChanged(object sender, EventArgs e)
		{
			CurrentStar.Magnitude = (double)StarMagnitude.Value;
			Dirty();
		}

		private void StarSystemLocalName_TextChanged(object sender, EventArgs e)
		{
			CurrentStarSystem.LocalName = StarSystemLocalName.Text;
			Dirty();
		}

		private void SatelitesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RebuildingLists)
				return;

			CurrentSatelite = SatelitesList.SelectedItem as StarSystem.Planet;
			SateliteInfo.Init(CurrentSatelite);
			RemoveSatelite.Enabled = CurrentSatelite != null;
		}

		private void DebrisFieldList_SelectedIndexChanged(object sender, EventArgs e)
		{
			CurrentDebrisField = DebrisFieldList.SelectedItem as StarSystem.DebrisField;

			Loading = true;
			if (CurrentDebrisField == null)
			{
				DebrisName.Text = string.Empty;
				DebrisOrbitalAngle.Value = 0;
				DebrisInnerRadius.Value = 0;
				DebrisOuterRadius.Value = 0;
				DebrisArc.Value = 0;
			}
			else
			{
				DebrisName.Text = CurrentDebrisField.Name;
				DebrisOrbitalAngle.Value = (decimal)CurrentDebrisField.SyncAngle;
				DebrisInnerRadius.Value = (decimal)CurrentDebrisField.InnerRadius;
				DebrisOuterRadius.Value = (decimal)CurrentDebrisField.OuterRadius;
				DebrisArc.Value = (decimal)CurrentDebrisField.Arc;
			}
			Loading = false;
		}

		private void DebrisName_TextChanged(object sender, EventArgs e)
		{
			if (Loading || CurrentDebrisField == null || DebrisName.Text == CurrentDebrisField.Name)
				return;

			CurrentDebrisField.Name = DebrisName.Text;
			int i = DebrisFieldList.SelectedIndex;
			RebuildingLists = true;
			DebrisFieldList.Items.RemoveAt(i);
			DebrisFieldList.Items.Insert(i, CurrentDebrisField);
			DebrisFieldList.SelectedIndex = i;
			RebuildingLists = false;
			Dirty();
		}

		private void AddPlanet_Click(object sender, EventArgs e)
		{
			StarSystem.Planet planet = new StarSystem.Planet();
			CurrentStarSystem.Planets.Add(planet);
			PlanetList.Items.Add(planet);
			PlanetList.SelectedItem = planet;
			Dirty();
		}

		private void DeletePlanet_Click(object sender, EventArgs e)
		{
			CurrentStarSystem.Planets.Remove(CurrentPlanet);
			StarSystemList_SelectedIndexChanged(this, EventArgs.Empty);
			Dirty();
		}

		private void AddSatelite_Click(object sender, EventArgs e)
		{
			StarSystem.Planet planet = new StarSystem.Planet();
			CurrentPlanet.Satalites.Add(planet);
			SatelitesList.Items.Add(planet);
			SatelitesList.SelectedItem = planet;
			Dirty();
		}

		private void RemoveSatelite_Click(object sender, EventArgs e)
		{
			CurrentPlanet.Satalites.Remove(CurrentSatelite);
			PlanetList_SelectedIndexChanged(this, EventArgs.Empty);
			Dirty();
		}

		private void MapPannel_Load(object sender, EventArgs e)
		{
			PlanetInfo.Dirty += new EventHandler(PlanetInfoDirty);
			SateliteInfo.Dirty += new EventHandler(SateliteInfoDirty);
		}

		protected void PlanetInfoDirty(object sender, EventArgs e)
		{
			if (CurrentPlanet.Name != PlanetList.GetItemText(PlanetList.SelectedIndex))
			{
				int i = PlanetList.SelectedIndex;
				RebuildingLists = true;
				PlanetList.Items.RemoveAt(i);
				PlanetList.Items.Insert(i, CurrentPlanet);
				PlanetList.SelectedIndex = i;
				RebuildingLists = false;
				Dirty();
			}
		}

		protected void SateliteInfoDirty(object sender, EventArgs e)
		{
			if (CurrentSatelite.Name != SatelitesList.GetItemText(SatelitesList.SelectedIndex))
			{
				int i = SatelitesList.SelectedIndex;
				RebuildingLists = true;
				SatelitesList.Items.RemoveAt(i);
				SatelitesList.Items.Insert(i, CurrentSatelite);
				SatelitesList.SelectedIndex = i;
				RebuildingLists = false;
				Dirty();
			}
		}

		private void saveRegonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Arm == null)
				return;

			SaveFileDialog ofd = new SaveFileDialog();
			ofd.Filter = "Galaxy XML files (*.galaxy_xml)|*.galaxy_xml|All files (*.*)|*.*";
			ofd.FileName = Arm.Name + ".galaxy_xml";

			if (OutputFile == null && ofd.ShowDialog(this) == DialogResult.OK)
			{
				OutputFile = new FileInfo(ofd.FileName);

				XmlSerializer xml = new XmlSerializer(typeof(GalacticRegon));
				if (OutputFile.Exists)
					OutputFile.Delete();

				FileStream fs = OutputFile.OpenWrite();
				xml.Serialize(fs, Arm);
				fs.Close();
			}
		}

		private void loadRegonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Galaxy XML files (*.galaxy_xml)|*.galaxy_xml|All files (*.*)|*.*";
			ofd.FileName = "*.galaxy_xml";

			if (ofd.ShowDialog(this) == DialogResult.OK)
			{
				OutputFile = new FileInfo(ofd.FileName);

				XmlSerializer xml = new XmlSerializer(typeof(GalacticRegon));
				FileStream fs = OutputFile.OpenRead();
				Arm = xml.Deserialize(fs) as GalacticRegon;
				fs.Close();

				PopulateSystemList();
			}
		}

		private void DebrisInnerRadius_ValueChanged(object sender, EventArgs e)
		{
			if (Loading || CurrentDebrisField == null)
				return;

			CurrentDebrisField.InnerRadius = (double)DebrisInnerRadius.Value;
			Dirty();
		}

		private void DebrisOuterRadius_ValueChanged(object sender, EventArgs e)
		{
			if (Loading || CurrentDebrisField == null)
				return;

			CurrentDebrisField.OuterRadius = (double)DebrisOuterRadius.Value;
			Dirty();
		}

		private void DebrisArc_ValueChanged(object sender, EventArgs e)
		{
			if (Loading || CurrentDebrisField == null)
				return;

			CurrentDebrisField.Arc = (double)DebrisArc.Value;
			Dirty();
		}

		private void DebrisOrbitalAngle_ValueChanged(object sender, EventArgs e)
		{
			if (Loading || CurrentDebrisField == null)
				return;

			CurrentDebrisField.SyncAngle = (double)DebrisOrbitalAngle.Value;
			Dirty();
		}

		private void AddDebris_Click(object sender, EventArgs e)
		{
			StarSystem.DebrisField field = new StarSystem.DebrisField();
			CurrentStarSystem.DebrisFields.Add(field);
			DebrisFieldList.Items.Add(field);
			DebrisFieldList.SelectedItem = field;

			Dirty();
		}

		private void RemoveDebris_Click(object sender, EventArgs e)
		{
			if (CurrentDebrisField == null)
				return;

			CurrentStarSystem.DebrisFields.Remove(CurrentDebrisField);
			DebrisFieldList.Items.Remove(DebrisFieldList.SelectedIndex);
			if (DebrisFieldList.Items.Count > 0)
				DebrisFieldList.SelectedIndex = 0;
			else
				DebrisFieldList.SelectedIndex = -1;

			Dirty();
		}

		private void addPlanetsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GalaxyTools.AddRandomWorlds(Arm, 0.75, 9);
			Dirty();
		}

		private void SystemDisplay_Click(object sender, EventArgs e)
		{

		}

		protected void Dirty()
		{
			InvalidateSystemDisplay();
		}

		protected void InvalidateSystemDisplay()
		{
			SystemDisplay.Invalidate();
		}

		private void SystemDisplay_Paint(object sender, PaintEventArgs e)
		{
			if (Renderer == null || CurrentStarSystem == null)
				return;

			Renderer.Draw(e.Graphics, SystemDisplay);
		}

		private void clearAllPlanetsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (StarSystem system in Arm.StarSystems)
			{
				system.Planets.Clear();
				system.DebrisFields.Clear();
				Dirty();
			}
		}
	}
}
