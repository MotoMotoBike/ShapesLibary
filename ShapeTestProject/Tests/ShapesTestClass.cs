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
        public void TrangleSqare_InputIs3_4_5Return6()
        {
            // Arrange
            Trangle trangle = new(3, 4, 5);

            // Act
            double res = trangle.GetSquare();

            // Assert
            Assert.AreEqual(res,6.0);
        }

        [TestMethod]
        public void CircleSqare_InputIs1_5Return3_141592653589793()
        {
            // Arrange
            Circle circle = new(1);

            // Act
            double res = circle.GetSquare();

            // Assert
            Assert.AreEqual(res, 3.141592653589793);
        }
    }
}
