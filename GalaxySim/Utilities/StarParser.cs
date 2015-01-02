using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using GalaxySim;
using GalaxySim.CoordinateSystems;

namespace GalaxySim.Utilities
{
    public static class StarParser
    {
        public static double ParseHourAngle(string hourAngle)
        {
            double angle = 0;
            
            if (hourAngle.Length == 1) 
            {
                double.TryParse(hourAngle, out angle);
                return angle / (Math.PI * 180.0);
            }

            string[] parts = hourAngle.Split(" ".ToCharArray());
            foreach(string part in parts)
            {
                char lastC = part.ToLower()[part.Length - 1];
                double value = 0;
                string numberPart = part.Substring(0, part.Length - 1);
                double factor = 1;

                if (double.TryParse(numberPart, out value))
                {
                    value *= factor;

                    switch(lastC)
                    {
                        case 'h':
                            angle += (Math.PI * 2.0) * (value / 24.0);
                            break;

                        case 'm':
                            angle += (Math.PI/12.0) * (value / 60.0);
                            break;

                        case 's':
                            angle += (Math.PI / (12.0*60)) * (value / 60.0);
                            break;
                    }
                }
            }

            return angle;
        }

        public static double ParseMinuteAngle(string minuteAngle)
        {
            double angle = 0;

            if (minuteAngle.Length == 1)
            {
                double.TryParse(minuteAngle, out angle);
                return angle / (Math.PI * 180.0);
            }

            string[] parts = minuteAngle.Split(" ".ToCharArray());
            foreach (string part in parts)
            {
                char lastC = part.ToLower()[part.Length - 1];
                double value = 0;
                string numberPart = part.Substring(0, part.Length - 1);

                double factor = 1;
                if (double.TryParse(numberPart, out value))
                {
                    value *= factor;

                    switch (lastC)
                    {
                        case '°':
                            angle += (Math.PI * 2.0) * (value / 360.0);
                            break;

                        case '′':
                            angle += (Math.PI / 180.0) * (value / 60.0);
                            break;

                        case '″':
                            angle += (Math.PI / (12.0 * 60)) * (value / 60.0);
                            break;
                    }
                }
            }

            return angle;
        }

        public static GalacticRegon ReadStarChart(FileInfo file)
        {
            GalacticRegon regon = new GalacticRegon();
            regon.Name = Path.GetFileNameWithoutExtension(file.Name);

            StreamReader reader = file.OpenText();

            // header 6
            // Star Designation,Sub Code,Stellar Class,Magnitude,Right Ascension,Declination,Distance
            //  0               1           2           3           4               5           6
            reader.ReadLine();

            string lastFullStar = string.Empty;

            StarSystem system = null;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine().Replace('−', '-');

                string[] fields = line.Split(",".ToCharArray());
                if (fields.Length < 7)
                    continue;

                double ascension = ParseHourAngle(fields[4]);
                double declination = ParseMinuteAngle(fields[5]);
                double distance = 0;
                double.TryParse(fields[6], out distance);

                LightYearCoordinate location = LightYearCoordinate.FromEquatorial(ascension,declination,distance);

                if (fields[0] != string.Empty || system == null)
                {
                    system = new StarSystem();
                    regon.StarSystems.Add(system);

                    system.Name = fields[0];

                    system.Location = location;
                }

                StarSystem.Star star = new StarSystem.Star();
				star.Name = system.Name + (fields[1] == string.Empty ? string.Empty : (" " + fields[1]));
                star.ParseCategory(fields[2]);
                double.TryParse(fields[3], out star.Magnitude);

                LightYearCoordinate delta = system.Location - location;
                if (delta.MagnitudeSquared > 0)
                {
                    star.Offset = delta.ToKillometers();
                }

                system.Stars.Add(star);
            }

            reader.Close();
            return regon;
        }
    }
}
