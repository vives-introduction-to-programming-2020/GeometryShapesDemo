using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryShapesDemo
{
    public abstract class Shape
    {
        public Shape()
        {
            //Console.WriteLine("Default constructor Shape");
            Location = new Point();
        }

        // VIRTUAL = Allow subclass to override this method
        // Problem here is that we do not actually have a sensible
        // value for Area
        //public virtual double Area()
        //{
        //    // TODO - Is this ok ?
        //    return 0;
        //}

        //public virtual double Circumference()
        //{
        //    // TODO - Is this ok ?
        //    return 0;
        //}

        // ABSTRACT = Don't have an implementation in this class,
        // but you should provide one in a subclass
        // Once a method is made abstract, the class should be made abstract.
        // This means we cannot create objects of this class anymore
        // Shape shape = new Shape();           // FAILS if Shape is abstract (class is incomplete)
        // BETTER SOLUTION
        // This creates a CONTRACT, subclass has Area() and Circumference() method !
        public abstract double Area();
        public abstract double Circumference();

        public override string ToString()
        {
            return $"Shape @ Location {Location}";
        }

        public Point Location { get; set; }     // = null !
    }
}
