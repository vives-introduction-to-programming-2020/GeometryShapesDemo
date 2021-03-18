using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryShapesDemo
{
    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
            //Console.WriteLine("Executing Point(double x, double y)");
        }

        public Point()
            : this(0, 0)
        {
            //X = 0;
            //Y = 0;
            //Console.WriteLine("Executing Point()");
        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }

        public double X { get; set; }
        public double Y { get; set; }
    }
}
