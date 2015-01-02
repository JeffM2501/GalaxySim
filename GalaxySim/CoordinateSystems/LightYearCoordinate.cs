using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxySim.CoordinateSystems
{
    public class LightYearCoordinate
    {
        public double X = 0;
        public double Y = 0;
        public double Z = 0;

        public static LightYearCoordinate Zero = new LightYearCoordinate();

        public LightYearCoordinate(){}

        public LightYearCoordinate(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public LightYearCoordinate(LightYearCoordinate lyc)
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

        public static LightYearCoordinate operator + (LightYearCoordinate lhs, LightYearCoordinate rhs)
        {
            return new LightYearCoordinate(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        public static LightYearCoordinate operator -(LightYearCoordinate lhs, LightYearCoordinate rhs)
        {
            return new LightYearCoordinate(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        public static LightYearCoordinate operator *(LightYearCoordinate lhs, double rhs)
        {
            return new LightYearCoordinate(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs);
        }

        public static LightYearCoordinate operator *(double lhs,  LightYearCoordinate rhs)
        {
            return new LightYearCoordinate(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z);
        }

        public static LightYearCoordinate operator /(LightYearCoordinate lhs, double rhs)
        {
            return new LightYearCoordinate(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs);
        }

        public static LightYearCoordinate FromEquatorial(double rightAscension, double declination, double distance)
        {
            double zed = Math.Sin(declination) * distance;

            double x = Math.Cos(rightAscension) * distance;
            double y = Math.Sin(rightAscension) * distance;

            return new LightYearCoordinate(x, y, zed);
        }

        public KilometreCoordinate ToKillometers()
        {
            return new KilometreCoordinate(X * KilometreCoordinate.LightYearInKM, Y * KilometreCoordinate.LightYearInKM, Z * KilometreCoordinate.LightYearInKM);
        }
    }
}
