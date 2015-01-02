using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using GalaxySim.CoordinateSystems;

namespace GalaxySim
{
    public class GalacticRegon
    {
        public string Name = string.Empty;

        public KiloParsecCoordinate Location = KiloParsecCoordinate.Zero;
        public double Radius = 0;

        public List<StarSystem> StarSystems = new List<StarSystem>();
    }
}
