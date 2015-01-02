using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxySim.CoordinateSystems
{
    public class KiloParsecCoordinate
    { 
        public double X = 0;
        public double Y = 0;
        public double Z = 0;

        public static KiloParsecCoordinate Zero = new KiloParsecCoordinate();

        public KiloParsecCoordinate(){}

        public KiloParsecCoordinate(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public KiloParsecCoordinate(KiloParsecCoordinate lyc)
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

        public static KiloParsecCoordinate operator +(KiloParsecCoordinate lhs, KiloParsecCoordinate rhs)
        {
            return new KiloParsecCoordinate(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        public static KiloParsecCoordinate operator -(KiloParsecCoordinate lhs, KiloParsecCoordinate rhs)
        {
            return new KiloParsecCoordinate(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        public static KiloParsecCoordinate operator *(KiloParsecCoordinate lhs, double rhs)
        {
            return new KiloParsecCoordinate(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs);
        }

        public static KiloParsecCoordinate operator *(double lhs, KiloParsecCoordinate rhs)
        {
            return new KiloParsecCoordinate(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z);
        }

        public static KiloParsecCoordinate operator /(KiloParsecCoordinate lhs, double rhs)
        {
            return new KiloParsecCoordinate(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs);
        }

        public static KiloParsecCoordinate FromEquatorial(double rightAscension, double declination, double distance)
        {
            double zed = Math.Sin(declination) * distance;

            double x = Math.Cos(rightAscension) * distance;
            double y = Math.Sin(rightAscension) * distance;

            return new KiloParsecCoordinate(x, y, zed);
        }
    }
}
