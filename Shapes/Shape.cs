using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public virtual double GetSquare() { return Square; }

        public abstract string Name { get; }

        public double Square { get; protected set; }

    }
}
