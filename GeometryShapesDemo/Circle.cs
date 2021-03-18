using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryShapesDemo
{
    public class Circle : Shape         // Inheritance
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Circumference()
        {
            return 2 * Math.PI * Radius;
        }
        
        public override string ToString()
        {
            return $"Circle with Radius of {Radius} has Area of {Area()}"
                + $" and Circumference of {Circumference()} @ location {Location}";
        }

        public double Radius { get; set; }
    }
}
