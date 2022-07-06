using Shapes.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public class Trangle : Shape
    {
        public readonly double[] Sides = { 0, 0, 0 };

        public readonly double p;

        public readonly bool isRight;

        public override string Name => "Треугольник";

        public Trangle(double a, double b, double c)
        {
            Sides[0] = a;
            Sides[1] = b;
            Sides[2] = c;
            if (IsTrangleExists())
            {
                isRight = IsTrangleRight();

                p = Sides.Sum() / 2; // Полупериметр
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
            {
                throw new ShapeNotExistsExeption("Фигура не существует");
            }
        }

        bool IsTrangleExists()
        {
            double max = Sides.Max();
            double[] others = Sides.Where(i => i != max).ToArray();

            if (others.Length == 1)
            {
                return true;
            }
            else
            {
                if (others.Sum() > max)
                {
                    return true;
                }
            }
            return false;
        }

        bool IsTrangleRight()
        {
            double max = Sides.Max();
            double[] others = Sides.Where(i => i != max).ToArray();

            if (others.Length == 2)
            {
                if ((max * max) == (others[0] * others[0]) + (others[1] * others[1]))
                {
                    return true;
                }
            }
             
            return false;
        }
    }
}
