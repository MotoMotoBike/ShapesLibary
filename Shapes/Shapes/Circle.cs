using Shapes.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public class Circle : Shape
    {
        public readonly double radius;

        public override string Name => "Круг";

        public Circle(double radius)
        {
            this.radius = radius;

            if (radius > 0)
            {
                Square = Math.PI * (radius * radius);
            }
            else
            {
                throw new ShapeNotExistsException("Фигура не существует");
            }
        }
    }
}
