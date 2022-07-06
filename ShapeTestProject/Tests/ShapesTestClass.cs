using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
    [TestClass]
    public class ShapesTestClass
    {
        [TestMethod]
        public void TrangleIsight_InputIs3_4_5ReturnTrue()
        {
            // Arrange
            Trangle trangle = new(3, 4, 5);

            // Act
            bool res = trangle.isRight;

            // Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TrangleSqare6_InputIs3_4_5ReturnTrue()
        {
            // Arrange
            Trangle trangle = new(3, 4, 5);

            // Act
            double res = trangle.GetSquare();

            // Assert
            Assert.Equals(res,(double)6.0);
        }
    }
}
