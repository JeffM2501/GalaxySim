using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxySim.CoordinateSystems
{
    public class UnitVector
    {
        public double X = 0;
        public double Y = 0;
        public double Z = 0;

        public static UnitVector Zero = new UnitVector();
        public static UnitVector UnitX = new UnitVector(1,0,0);
        public static UnitVector UnitY = new UnitVector(0,1,0);
        public static UnitVector UnitZ = new UnitVector(0,0,1);

        public UnitVector(){}

        public UnitVector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public UnitVector(UnitVector uv)
        {
            X = uv.X;
            Y = uv.Y;
            Z = uv.Z;
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

        public static UnitVector operator +(UnitVector lhs, UnitVector rhs)
        {
            return new UnitVector(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        public static KilometreCoordinate operator -(UnitVector lhs, UnitVector rhs)
        {
            return new KilometreCoordinate(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        public static KilometreCoordinate operator *(UnitVector lhs, double rhs)
        {
            return new KilometreCoordinate(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs);
        }

        public static UnitVector operator *(double lhs, UnitVector rhs)
        {
            return new UnitVector(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z);
        }

        public static UnitVector operator /(UnitVector lhs, double rhs)
        {
            return new UnitVector(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs);
        }
    }
}
