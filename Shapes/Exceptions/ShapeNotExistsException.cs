using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Exeptions
{
    class ShapeNotExistsException : Exception
    {
        public ShapeNotExistsException(string message)
            : base(message) { }
    }
}
