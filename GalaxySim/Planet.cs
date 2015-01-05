using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GalaxySim
{
	public class Planet
	{
		public string Name = string.Empty;
		public byte ID = 0;

		[XmlIgnore]
		public object Parrent = null;

		public bool Populated = false;

		public override string ToString()
		{
			return Name == string.Empty ? "Un-Named Planet" : Name;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public double OrbitalRadius = 0;
		public double SyncAngle = 0;

		public double Mass = 0;
		public double Radius = 0;

		public enum TypeClasses
		{
			Selena = 0,
			Desert,
			Terestrial,
			Fluid,
			Gasious,
			Unknown,
		}

		public enum Climates
		{
			Baren = 0,
			Frozen,
			Cold,
			Cool,
			Temperate,
			Warm,
			Hot,
			Molten,
			Unknown,
		}

		public TypeClasses TypeClass = TypeClasses.Selena;
		public Climates Climate = Climates.Baren;

		public bool Ringed = false;

		public List<Planet> Satalites = new List<Planet>();
	}
}
