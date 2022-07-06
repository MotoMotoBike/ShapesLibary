using Shapes;
using Shapes.Shapes;
using System;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trangle trangle = new Trangle(3, 4, 5);
            Circle circle = new Circle(1);

            Console.WriteLine(trangle.isRight);

            List<Shape> shapes = new List<Shape>();

            shapes.Add(trangle);
            shapes.Add(circle);

            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Name.ToString());
                Console.WriteLine(shape.GetSquare().ToString());
            }
        }
    }
}
