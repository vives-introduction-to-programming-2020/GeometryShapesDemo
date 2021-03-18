using System;
using System.Collections.Generic;

namespace GeometryShapesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4.123);
            Console.WriteLine(circle);

            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.Location = new Point(6, 12);
            Console.WriteLine(rectangle);

            //Point point = new Point(4, 7);
            //Point secondPoint = new Point();

            Triangle triangle = new Triangle(3, 4);
            Console.WriteLine(triangle);



            //Shape shape = new Shape();
            //Console.WriteLine(shape);

            // Subtype in variable of super type
            Shape myCircle = new Circle(5);
            Console.WriteLine(myCircle);

            Shape myTriangle = new Triangle(6, 7);
            Console.WriteLine(myTriangle);


            // List of circles
            List<Circle> circles = new List<Circle>();
            circles.Add(new Circle(8));
            circles.Add(new Circle(13));

            Console.WriteLine(" ======== CIRCLES ========");
            foreach (var c in circles)
            {
                Console.WriteLine("Circle with radius = " + c.Radius);
            }

            // List of shapes
            List<Shape> shapes = new List<Shape>();
            // shapes.Add(new Shape());
            shapes.Add(new Circle(3));
            shapes.Add(new Circle(7));
            shapes.Add(new Triangle(12, 23));
            shapes.Add(new Triangle(12, 77));
            shapes.Add(new Rectangle(3, 4));

            Console.WriteLine(" ======== SHAPES ========");
            double totalArea = 0;
            foreach (var s in shapes)
            {
                Console.WriteLine("Location = " + s.Location);
                Console.WriteLine("Area = " + s.Area());
                totalArea += s.Area();
            }

            Console.WriteLine("TOTAL AREA = " + totalArea);


        }
    }
}
