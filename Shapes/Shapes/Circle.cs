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
        public readonly double R;

        public override string Name => "Круг";

        public Circle(double R)
        {
            this.R = R;

            if (R > 0)
            {
                S = Math.PI * (R * R);
            }
            else
            {
                throw new ShapeNotExistsExeption("Фигура не существует");
            }
        }
    }
}
