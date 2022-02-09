using System;
using System.Collections.Generic;
using System.Text;

namespace Static_005
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
        }
        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.X * p2.X, p1.Y * p2.Y, p1.Z * p2.Z);
        }
        public static Point operator /(Point p1, Point p2)
        {
            return new Point(p1.X / p2.X, p1.Y / p2.Y, p1.Z / p2.Z);
        }
        public static Point operator ++(Point p1)
        {
            return new Point(p1.X + 1, p1.Y + 1, p1.Z+1);
        }
        public static Point operator --(Point p1)
        {
            return new Point(p1.X - 1, p1.Y - 1, p1.Z - 1);
        }
        public override string ToString()
        {
            return string.Format($"[{X},{Y},{Z}]");
        }
        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                if (((Point)obj).X == this.X && ((Point)obj).Y == this.Y && ((Point)obj).Z == this.Z)
                    return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
