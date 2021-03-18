using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryShapesDemo
{
    public class Triangle : Shape
    {
        public Triangle(double _base, double height)
        {
            Base = _base;
            Height = height;
        }

        public override double Area()
        {
            return Base * Height / 2;
        }

        public override double Circumference()
        {
            // a^2 + b^2 = c^2
            double c = Math.Sqrt(Base * Base + Height * Height);
            return Base + Height + c;
        }

        public override string ToString()
        {
            return $"Triangle with Height of {Height} and Base of {Base} has "
                + $"Area of {Area()} and Circumference of {Circumference()} @ location {Location}";
        }

        public double Height { get; set; }
        public double Base { get; set; }
    }
}
