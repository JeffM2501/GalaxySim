using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxySim.CoordinateSystems
{
    public class KilometreCoordinate
    {
        public double X = 0;
        public double Y = 0;
        public double Z = 0;

        public static KilometreCoordinate Zero = new KilometreCoordinate();

        public KilometreCoordinate(){}

        public KilometreCoordinate(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public KilometreCoordinate(KilometreCoordinate lyc)
        {
            X = lyc.X;
            Y = lyc.Y;
            Z = lyc.Z;
        }

        public double Magnitude
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }
        }

        public double MagnitudeSquared
        {
            get
            {
                return X * X + Y * Y + Z * Z;
            }
        }

        public static KilometreCoordinate operator +(KilometreCoordinate lhs, KilometreCoordinate rhs)
        {
            return new KilometreCoordinate(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        public static KilometreCoordinate operator -(KilometreCoordinate lhs, KilometreCoordinate rhs)
        {
            return new KilometreCoordinate(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        public static KilometreCoordinate operator *(KilometreCoordinate lhs, double rhs)
        {
            return new KilometreCoordinate(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs);
        }

        public static KilometreCoordinate operator *(double lhs, KilometreCoordinate rhs)
        {
            return new KilometreCoordinate(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z);
        }

        public static KilometreCoordinate operator /(KilometreCoordinate lhs, double rhs)
        {
            return new KilometreCoordinate(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs);
        }

        public static KilometreCoordinate FromEquatorial(double rightAscension, double declination, double distance)
        {
            double zed = Math.Sin(declination) * distance;

            double x = Math.Cos(rightAscension) * distance;
            double y = Math.Sin(rightAscension) * distance;

            return new KilometreCoordinate(x, y, zed);
        }

        public static double LightYearInKM = 9460730472580.800;
        public static double KMInLightYear = 1.0/9460730472580.800;

        public LightYearCoordinate ToLightYears()
        {
            return new LightYearCoordinate(X * KMInLightYear, Y * KMInLightYear, Z * KMInLightYear);
        }
    }
}
