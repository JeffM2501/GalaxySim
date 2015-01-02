using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxySim.CoordinateSystems
{
    public class AUDistance
    {
        public static double ToKilometers(double value)
        {
            return value * 149597870.700;
        }

        public static double FromKilometers(double value)
        {
            return value / 149597870.700;
        }

        public static double ToLightYears(double value)
        {
            return value / 63241.077;
        }

        public static double FromLightYears(double value)
        {
            return value * 63241.077;
        }
    }
}
