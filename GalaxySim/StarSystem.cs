using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GalaxySim.CoordinateSystems;

namespace GalaxySim
{
    public class StarSystem
    {
        public string Name = String.Empty;
        public string LocalName = string.Empty;

		public override string ToString()
		{
			return Name;
		}
        
        public class Star
        {
            public string Name = string.Empty;
            public enum SpectraTypes
            {
                O = 0,
                B,
                A,
                F,
                G,
                K,
                M,
                L,
                T,
                Unknown,
            }
            public SpectraTypes SpectralType = SpectraTypes.Unknown;
            public double Temperature = 0;
            public double Luminosity = 0;
            public double Magnitude = 1;

            public KilometreCoordinate Offset = KilometreCoordinate.Zero;

            public void ParseCategory(string category)
            {
                if (category == string.Empty)
                    return;

                if (category.Contains("/"))
                    category = category.Substring(0, category.IndexOf('/'));

                string catId = category.Substring(0,1).ToUpper();
                try
                {
                    SpectralType = (SpectraTypes)Enum.Parse(typeof(SpectraTypes), catId);
                }
                catch(Exception)
                {
                    SpectralType = SpectraTypes.Unknown;
                }

                string temp = string.Empty;
                string lum = string.Empty;
                int i = 1;
                for (i = 1; i < category.Length; i++)
                {
                    if (Char.IsDigit(category[i]) || Char.IsSymbol(category[i]) || Char.IsPunctuation(category[i]))
                        temp += category[i];
                    else
                        break;
                }
                lum = category.Substring(i);

                Temperature = -1;
                double.TryParse(temp, out Temperature);

                string[] lums = lum.ToUpper().Split("-".ToCharArray());
                foreach(string l in lums)
                {
                    double val = 0;

                    if (l == "VI")
                        val = 6;
                    else if (l == "V")
                        val = 5;
                    else if (l == "IV")
                        val = 4;
                    else if (l == "III")
                        val = 3;
                    else if (l == "II")
                        val = 2;
                    else if (l == "I")
                        val = 1;

                    Luminosity = val;
                }
            }

			public override string ToString()
			{
				return Name + "(" + SpectralType.ToString() + Temperature.ToString("G4") + ")";
			}
        }

        public List<Star> Stars = new List<Star>();

        public LightYearCoordinate Location = LightYearCoordinate.Zero;
        public double Radius = 0;

        public UnitVector OrbitalPlane = UnitVector.UnitZ;
        public double SyncDate = 0;

        public class Planet
        {
            public string Name = string.Empty;
            public byte ID = 0;

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
			}

			public TypeClasses TypeClass = TypeClasses.Selena;
			public Climates Climate = Climates.Baren;

			public bool Ringed = false;

			public List<Planet> Satalites = new List<Planet>();
        }

		public List<Planet> Planets = new List<Planet>();
		
		public class DebrisField
		{
			public string Name = string.Empty;

			public override string ToString()
			{
				return Name == string.Empty ? "Un-Named Field" : Name;
			}

			public byte ID = 0;

			public double InnerRadius = 0;
			public double OuterRadius = 0;

			public double Arc = -1;
			public double SyncAngle = 0;
		}

		public List<DebrisField> DebrisFields = new List<DebrisField>();
    }
}
