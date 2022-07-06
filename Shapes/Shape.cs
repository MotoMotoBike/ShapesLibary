using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public double GetSquare() { return S; }

        public abstract string Name { get; }

        public double S;

    }
}
