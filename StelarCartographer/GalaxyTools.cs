using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using GalaxySim;
using GalaxySim.CoordinateSystems;
using GalaxySim.Utilities;

namespace StelarCartographer
{
	internal class GalaxyTools
	{
		public static bool UseMarkovNames = true;

		private static Random rand = new Random();

		private static string GetPlanetName()
		{
			if (UseMarkovNames)
				return NameTools.GetPlanetNameMarkov();
			else
				return NameTools.GetPlanetName();
		}

		private static StarSystem.DebrisField NewDebrisField (int i, double lastRadius)
		{
			StarSystem.DebrisField field = new StarSystem.DebrisField();
			field.Name = GetPlanetName();
			if (rand.NextDouble() < 0.5)
			{
				field.Name = "The " + field.Name;

				double p = rand.NextDouble();
				if (p < 0.25)
					field.Name += " Belt";
				else if (p < 0.5)
					field.Name += " Field";
				else if (p < 0.75)
					field.Name += "an Asteroids";
			}

			field.InnerRadius = lastRadius + 0.15 + (rand.NextDouble() * 0.95 * (i + 1));
			field.OuterRadius = field.InnerRadius + ((rand.NextDouble() * 0.125) + 0.01);
			field.SyncAngle = rand.NextDouble() * Math.PI * 2;
			field.Arc = rand.NextDouble() * Math.PI * 6;
			if (field.Arc > Math.PI * 2)
				field.Arc = -1;

			return field;
		}

		public static void AddRandomWorlds(GalacticRegon arm, double planetFormationFactor, double planetCountFactor)
		{
			if (planetCountFactor < 1)
				planetCountFactor = 1;

			foreach(StarSystem system in arm.StarSystems)
			{
				double lastRadius = 0;

				for (int s = 1; s < system.Stars.Count; s++)// check for stars that are coincident
				{
					StarSystem.Star star = system.Stars[s];
					if (star.Offset.MagnitudeSquared < 0.01)
					{
						star.Offset = KilometreCoordinate.FromEquatorial(rand.NextDouble() * Math.PI * 2, (rand.NextDouble() * Math.PI) - (Math.PI * 0.5), (rand.NextDouble() * 10000) + 5000);
					}
				}

				if (system.Planets.Count != 0 || rand.NextDouble() > planetFormationFactor)
				{
					if (rand.NextDouble() < (planetCountFactor*0.5))	// see if we want to do a system that just has debris fields
					{
						int fieldCount = (int)Math.Ceiling(rand.NextDouble() * (planetCountFactor * 0.75));
						if (fieldCount < 2)
							fieldCount = 2;

						for (byte i = 0; i < fieldCount; i++)
						{
							StarSystem.DebrisField field = NewDebrisField(i, lastRadius);
							lastRadius = field.OuterRadius;

							system.DebrisFields.Add(field);
						}
					}
					continue;
				}
				
				// this system has planets see if it's named and maybe populated

				bool named = rand.NextDouble() < 0.75;
				bool populated = rand.NextDouble() < 0.5;

				if (named)
					system.LocalName = GetPlanetName();

				int count = (int)Math.Ceiling(rand.NextDouble() * planetCountFactor);
				if (count < 1)
					count = 1;

				int beltCount = 0;
				bool lastWasBelt = false;
				bool hasPrimary = false;
				bool useRomans = rand.NextDouble() < 0.25;

				for(byte i = 0; i < count; i++)
				{
					if (beltCount < planetFormationFactor * 0.25 && !lastWasBelt && rand.NextDouble() < 0.25)
					{
						lastWasBelt = true;
						beltCount++;

						StarSystem.DebrisField field = NewDebrisField(i, lastRadius);
						lastRadius = field.OuterRadius;

						system.DebrisFields.Add(field);
					}
					else
					{
						lastWasBelt = false;
						Planet planet = new Planet();

						if (!hasPrimary && rand.NextDouble() < 0.25)
						{
							planet.Name = system.LocalName + " Prime";
							hasPrimary = true;
						}
						else if (useRomans)
							planet.Name += system.LocalName + " " + ToRoman(i+1);
						else
							planet.Name = GetPlanetName();

						planet.ID = i;
						planet.TypeClass = (Planet.TypeClasses)rand.Next((int)(Planet.TypeClasses.Unknown) - 1);
						planet.Climate = (Planet.Climates)rand.Next((int)(Planet.Climates.Unknown) - 1);

						planet.Radius = 1200 + (rand.NextDouble() * 68000);
						planet.Mass = 0.05 + (rand.NextDouble() * 1000);
						planet.OrbitalRadius = lastRadius + 0.15 + (rand.NextDouble() * 0.5 * (i + 1));

						planet.Ringed = rand.NextDouble() < 0.25;

						planet.SyncAngle = rand.NextDouble() * Math.PI * 2;

						int moonCount = (int)Math.Floor(rand.NextDouble() * i * 2);

						bool useMoonRomans = !useRomans && rand.NextDouble() < .6;
						for (byte m = 0; m < moonCount; m++)
						{
							Planet moon = new Planet();
							moon.ID = m;
							if (useMoonRomans)
								moon.Name = planet.Name + " " + ToRoman(m + 2);
							else
								moon.Name = GetPlanetName();
							moon.Mass = planet.Mass * ((rand.NextDouble() * 0.125) + 0.001);
							moon.Radius = 400 + (rand.NextDouble() * 1200);
							moon.OrbitalRadius = planet.Radius * 2 + (rand.NextDouble() * planet.Radius * 4);

							moon.TypeClass = (Planet.TypeClasses)rand.Next((int)(Planet.TypeClasses.Fluid));
							moon.Climate = (Planet.Climates)rand.Next((int)(Planet.Climates.Unknown) - 1);

							planet.SyncAngle = rand.NextDouble() * Math.PI * 2;

							planet.Satalites.Add(moon);
						}

						lastRadius = planet.OrbitalRadius;
						system.Planets.Add(planet);
					}

					//foreach (Starsystem)
				}
			}
		}

		public static string ToRoman(int number)
		{
			if (number >= 1000)
				return "M" + ToRoman(number - 1000);
			else if (number >= 900)
				return "CM" + ToRoman(number - 900);
			else if (number >= 500)
				return "D" + ToRoman(number - 500);
			else if (number >= 400) 
				return "CD" + ToRoman(number - 400);
			else if (number >= 100) 
				return "C" + ToRoman(number - 100);
			else if (number >= 90) 
				return "XC" + ToRoman(number - 90);
			else if (number >= 50) 
				return "L" + ToRoman(number - 50);
			else if (number >= 40) 
				return "XL" + ToRoman(number - 40);
			else if (number >= 10) 
				return "X" + ToRoman(number - 10);
			else if (number >= 9) 
				return "IX" + ToRoman(number - 9);
			else if (number >= 5) 
				return "V" + ToRoman(number - 5);
			else if (number >= 4) 
				return "IV" + ToRoman(number - 4);
			else if (number >= 1) 
				return "I" + ToRoman(number - 1);

			return string.Empty;
		}
	}

	public static class NameTools
	{
		public static string[] characters1 = new string[] { "b", "c", "d", "f", "g", "h", "i", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
		public static string[] characters2 = new string[] { "a", "e", "o", "u" };
		public static string[] characters3 = new string[] { "br", "cr", "dr", "fr", "gr", "pr", "str", "tr", "bl", "cl", "fl", "gl", "pl", "sl", "sc", "sk", "sm", "sn", "sp", "st", "sw", "ch", "sh", "th", "wh" };
		public static string[] characters4 = new string[] { "ae", "ai", "ao", "au", "a", "ay", "ea", "ei", "eo", "eu", "e", "ey", "ua", "ue", "ui", "uo", "u", "uy", "ia", "ie", "iu", "io", "iy", "oa", "oe", "ou", "oi", "o", "oy" };
		public static string[] characters5 = new string[] { "turn", "ter", "nus", "rus", "tania", "hiri", "hines", "gawa", "nides", "carro", "rilia", "stea", "lia", "lea", "ria", "nov", "phus", "mia", "nerth", "wei", "ruta", "tov", "zuno", "vis", "lara", "nia", "liv", "tera", "gantu", "yama", "tune", "ter", "nus", "cury", "bos", "pra", "thea", "nope", "tis", "clite" };
		public static string[] characters6 = new string[] { "una", "ion", "iea", "iri", "illes", "ides", "agua", "olla", "inda", "eshan", "oria", "ilia", "erth", "arth", "orth", "oth", "illon", "ichi", "ov", "arvis", "ara", "ars", "yke", "yria", "onoe", "ippe", "osie", "one", "ore", "ade", "adus", "urn", "ypso", "ora", "iuq", "orix", "apus", "ion", "eon", "eron", "ao", "omia" };

		public static List<string> EmpireNames = new List<String>();

		private static Random rand = new Random();

		static NameTools()
		{
			EmpireNames.Add("The Republic of %");
			EmpireNames.Add("The Monarchy of %");
			EmpireNames.Add("The Peoples Republic of %");
			EmpireNames.Add("The % Hegemony");
			EmpireNames.Add("The % Technocracy");
			EmpireNames.Add("The %an Empire");
			EmpireNames.Add("The United % States");
			EmpireNames.Add("The United Worlds of %");
			EmpireNames.Add("The %an Union");
			EmpireNames.Add("The %an Collective");
			EmpireNames.Add("The %an Cooperative");
			EmpireNames.Add("The %an Protectorate");
			EmpireNames.Add("The %an Commonwealth");
			EmpireNames.Add("The Commonwealth of %");

			List<string> markovNames = new List<string>();
			markovNames.Add("Alizon");
			markovNames.Add("Alphane");
			markovNames.Add("Andermani");
			markovNames.Add("Barnett");
			markovNames.Add("Basilica");
			markovNames.Add("Beowulf");
			markovNames.Add("Casimir");
			markovNames.Add("Congo");
			markovNames.Add("Deneb");
			markovNames.Add("Durandel");
			markovNames.Add("Sol");
			markovNames.Add("Elysia");
			markovNames.Add("Endicott");
			markovNames.Add("Enki");
			markovNames.Add("Epsilon");
			markovNames.Add("Erewhon");
			markovNames.Add("Grayson");
			markovNames.Add("Gregor");
			markovNames.Add("Grendelsbane");
			markovNames.Add("Gryphon");
			markovNames.Add("Hamilton");
			markovNames.Add("Hancock");
			markovNames.Add("Kemal");
			markovNames.Add("Manticore");
			markovNames.Add("Masada");
			markovNames.Add("Matapan");
			markovNames.Add("Medusa");
			markovNames.Add("Melungeon");
			markovNames.Add("Nagasaki");
			markovNames.Add("Octagon");
			markovNames.Add("Potsdam");
			markovNames.Add("Seaford");
			markovNames.Add("Sphinx");
			markovNames.Add("Toulon");
			markovNames.Add("Verdant");
			markovNames.Add("Weyland");
			markovNames.Add("Zanzibar");

			markovNames.Add("Centauri");
			markovNames.Add("Delta");

			MarkovPlanets = new MarkovNameGenerator(markovNames.ToArray(), 2, 5);
		}

		private static MarkovNameGenerator MarkovPlanets;
		public static void SeedNames(FileInfo file)
		{
			List<string> lines = new List<string>();
			StreamReader reader = file.OpenText();

			while (!reader.EndOfStream)
			{
				string line = reader.ReadLine();
				//   if ((rand.Next()) % 10 == 0)
				lines.Add(line);
			}

			MarkovPlanets = new MarkovNameGenerator(lines.ToArray(), 2, 5);
		}

		public static string GetEmpireName(string homeworldName)
		{
			string data = RandomTools.RandomElement<string>(EmpireNames);

			return data.Replace("%", homeworldName);
		}

		public static string MakeSentanceCase(string text)
		{
			return text.Substring(0, 1).ToUpper() + text.Substring(1);
		}

		public static string GetPlanetNameMarkov()
		{
			return MarkovPlanets.NextName;
		}

		public static string GetPlanetName()
		{
			int random1 = (int)(Math.Floor((rand.NextDouble() * characters1.Length)));
			int random2 = (int)(Math.Floor((rand.NextDouble() * characters2.Length)));
			int random3 = (int)(Math.Floor((rand.NextDouble() * characters3.Length)));
			int random4 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random5 = (int)(Math.Floor((rand.NextDouble() * characters5.Length)));

			int random6 = (int)(Math.Floor((rand.NextDouble() * characters2.Length)));
			int random7 = (int)(Math.Floor((rand.NextDouble() * characters3.Length)));
			int random8 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random9 = (int)(Math.Floor((rand.NextDouble() * characters1.Length)));
			int random10 = (int)(Math.Floor((rand.NextDouble() * characters6.Length)));

			int random11 = (int)(Math.Floor((rand.NextDouble() * characters3.Length)));
			int random12 = (int)(Math.Floor((rand.NextDouble() * characters2.Length)));
			int random13 = (int)(Math.Floor((rand.NextDouble() * characters1.Length)));
			int random14 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random15 = (int)(Math.Floor((rand.NextDouble() * characters5.Length)));

			int random16 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random17 = (int)(Math.Floor((rand.NextDouble() * characters1.Length)));
			int random18 = (int)(Math.Floor((rand.NextDouble() * characters2.Length)));
			int random19 = (int)(Math.Floor((rand.NextDouble() * characters3.Length)));
			int random20 = (int)(Math.Floor((rand.NextDouble() * characters6.Length)));

			int random21 = (int)(Math.Floor((rand.NextDouble() * characters1.Length)));
			int random22 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random23 = (int)(Math.Floor((rand.NextDouble() * characters3.Length)));
			int random24 = (int)(Math.Floor((rand.NextDouble() * characters2.Length)));
			int random25 = (int)(Math.Floor((rand.NextDouble() * characters5.Length)));

			int random26 = (int)(Math.Floor((rand.NextDouble() * characters2.Length)));
			int random27 = (int)(Math.Floor((rand.NextDouble() * characters1.Length)));
			int random28 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random29 = (int)(Math.Floor((rand.NextDouble() * characters3.Length)));
			int random30 = (int)(Math.Floor((rand.NextDouble() * characters6.Length)));

			int random31 = (int)(Math.Floor((rand.NextDouble() * characters3.Length)));
			int random32 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random33 = (int)(Math.Floor((rand.NextDouble() * characters1.Length)));
			int random34 = (int)(Math.Floor((rand.NextDouble() * characters2.Length)));
			int random35 = (int)(Math.Floor((rand.NextDouble() * characters5.Length)));

			int random36 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random37 = (int)(Math.Floor((rand.NextDouble() * characters3.Length)));
			int random38 = (int)(Math.Floor((rand.NextDouble() * characters2.Length)));
			int random39 = (int)(Math.Floor((rand.NextDouble() * characters1.Length)));
			int random40 = (int)(Math.Floor((rand.NextDouble() * characters6.Length)));

			int random41 = (int)(Math.Floor((rand.NextDouble() * characters3.Length)));
			int random42 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random43 = (int)(Math.Floor((rand.NextDouble() * characters1.Length)));
			int random44 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random45 = (int)(Math.Floor((rand.NextDouble() * characters5.Length)));

			int random46 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random47 = (int)(Math.Floor((rand.NextDouble() * characters1.Length)));
			int random48 = (int)(Math.Floor((rand.NextDouble() * characters4.Length)));
			int random49 = (int)(Math.Floor((rand.NextDouble() * characters3.Length)));
			int random50 = (int)(Math.Floor((rand.NextDouble() * characters6.Length)));

			List<string> names = new List<string>();

			names.Add(characters1[random1] + characters2[random2] + characters5[random5]);
			names.Add(characters2[random6] + characters3[random7] + characters6[random10]);
			names.Add(characters3[random11] + characters4[random14] + characters5[random15]);
			names.Add(characters4[random16] + characters3[random19] + characters6[random20]);
			names.Add(characters3[random23] + characters4[random22] + characters2[random24] + characters5[random25]);
			names.Add(characters2[random26] + characters1[random27] + characters3[random29] + characters6[random30]);
			names.Add(characters3[random31] + characters4[random32] + characters2[random34] + characters5[random35]);
			names.Add(characters4[random36] + characters3[random37] + characters1[random39] + characters6[random40]);
			names.Add(characters3[random41] + characters4[random42] + characters1[random43] + characters4[random44] + characters5[random45]);
			names.Add(characters4[random46] + characters1[random47] + characters4[random48] + characters3[random49] + characters6[random50]);

			return MakeSentanceCase(names[rand.Next(names.Count)]);
		}
	}

	//Generates random names based on the statistical weight of letter sequences
	//in a collection of sample names
	public class MarkovNameGenerator
	{
		//constructor
		public MarkovNameGenerator(IEnumerable<string> sampleNames, int order, int minLength)
		{
			//fix parameter values
			if (order < 1)
				order = 1;
			if (minLength < 1)
				minLength = 1;

			_order = order;
			_minLength = minLength;

			//split comma delimited lines
			foreach (string line in sampleNames)
			{
				string[] tokens = line.Split(',');
				foreach (string word in tokens)
				{
					string upper = word.Trim().ToUpper();
					if (upper.Length < order + 1)
						continue;
					_samples.Add(upper);
				}
			}

			//Build chains            
			foreach (string word in _samples)
			{
				for (int letter = 0; letter < word.Length - order; letter++)
				{
					string token = word.Substring(letter, order);
					List<char> entry = null;
					if (_chains.ContainsKey(token))
						entry = _chains[token];
					else
					{
						entry = new List<char>();
						_chains[token] = entry;
					}
					entry.Add(word[letter + order]);
				}
			}
		}

		//Get the next random name
		public string NextName
		{
			get
			{
				//get a random token somewhere in middle of sample word                
				string s = "";
				do
				{
					int n = _rnd.Next(_samples.Count);
					int nameLength = _samples[n].Length;
					s = _samples[n].Substring(_rnd.Next(0, _samples[n].Length - _order), _order);
					while (s.Length < nameLength)
					{
						string token = s.Substring(s.Length - _order, _order);
						char c = GetLetter(token);
						if (c != '?')
							s += GetLetter(token);
						else
							break;
					}

					if (s.Contains(" "))
					{
						string[] tokens = s.Split(' ');
						s = "";
						for (int t = 0; t < tokens.Length; t++)
						{
							if (tokens[t] == "")
								continue;
							if (tokens[t].Length == 1)
								tokens[t] = tokens[t].ToUpper();
							else
								tokens[t] = tokens[t].Substring(0, 1) + tokens[t].Substring(1).ToLower();
							if (s != "")
								s += " ";
							s += tokens[t];
						}
					}
					else
						s = s.Substring(0, 1) + s.Substring(1).ToLower();
				}
				while (_used.Contains(s) || s.Length < _minLength);
				_used.Add(s);
				return s;
			}
		}

		//Reset the used names
		public void Reset()
		{
			_used.Clear();
		}

		//private members
		private Dictionary<string, List<char>> _chains = new Dictionary<string, List<char>>();
		private List<string> _samples = new List<string>();
		private List<string> _used = new List<string>();
		private Random _rnd = new Random();
		private int _order;
		private int _minLength;

		//Get a random letter from the chain
		private char GetLetter(string token)
		{
			if (!_chains.ContainsKey(token))
				return '?';
			List<char> letters = _chains[token];
			int n = _rnd.Next(letters.Count);
			return letters[n];
		}
	}

	public static class RandomTools
	{
		public static Random Rand = new Random();

		public static UInt64 Next(UInt64 max)
		{
			return (UInt64)Rand.NextDouble() * max;
		}

		public static bool Chance(float factor)
		{
			double val = Rand.NextDouble();

			return val <= factor;
		}

		public static UInt64 Next(UInt64 min, UInt64 max)
		{
			return min + Next(max - min);
		}

		public static int Next(int max)
		{
			return Rand.Next(max);
		}

		public static int Next(int min, int max)
		{
			return min + Next(max - min);
		}

		public static T RandomElement<T>(List<T> l)
		{
			if (l.Count == 0)
				return default(T);

			if (l.Count == 1)
				return l[0];

			return l[Rand.Next(l.Count)];
		}

		public static T RandomElement<T>(T[] a)
		{
			int count = a.Length;

			if (count == 0)
				return default(T);

			if (count == 1)
				return a[0];

			return a[Rand.Next(count)];
		}

		public static List<T> RandomElements<T>(T[] a)
		{
			int count = Next(a.Length);

			List<T> source = new List<T>();
			source.AddRange(a);

			List<T> items = new List<T>();

			while (items.Count < count)
			{
				T i = RandomElement<T>(source.ToArray());
				source.Remove(i);
				items.Add(i);
			}

			return items;
		}

		public static List<T> RandomizeElements<T>(List<T> t)
		{
			List<T> source = new List<T>();
			source.AddRange(t.ToArray());

			List<T> items = new List<T>();

			while (items.Count < t.Count)
			{
				T i = RandomElement<T>(source.ToArray());
				source.Remove(i);
				items.Add(i);
			}

			return items;
		}
	}
}
