using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Exeptions
{
    class ShapeNotExistsExeption : Exception
    {
        public ShapeNotExistsExeption(string mesage)
            : base(mesage) { }
    }
}
