using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryShapesDemo
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            //Console.WriteLine("Constructor Rectangle");
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Circumference()
        {
            return 2 * (Width + Height);
        }

        public override string ToString()
        {
            return $"Rectangle with Height of {Height} and Width of {Width} has "
                + $"Area of {Area()} and Circumference of {Circumference()} @ location {Location}";
        }

        public double Width { get; set; }
        public double Height { get; set; }
    }
}
