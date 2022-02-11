using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JT_TDD_Inlämning1.Tests
{
    [TestClass()]
    public class GeometricCalculatorTests
    {

        [TestMethod()]
        public void GetAreaTest_CircleRadiusIs10_Returns314_15()
        {
            var thing = new Circle(10f);

            var actual = GeometricCalculator.GetArea(thing);

            Assert.AreEqual(314.15, actual, 0.01);
        }

        [TestMethod()]
        [DataRow(0f, 0f)]
        [DataRow(-20f, 0f)]
        public void GetAreaTest_CircleRadiusLessThanZero_ReturnsZero(float radius, float expected)
        {
            var thing = new Circle(radius);

            var actual = GeometricCalculator.GetArea(thing);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetAreaTest_PassInvalidValues_ReturnsNullException()
        {
            GeometricCalculator.GetArea(null);
        }

        [TestMethod()]
        public void GetPerimeterTest_SquareSideIs20_Returns80()
        {
            var thing = new Square(20);

            var actual = GeometricCalculator.GetPerimeter(thing);

            Assert.AreEqual(80, actual);
        }

        [TestMethod()]
        [DataRow(0f, 0f)]
        [DataRow(-20f, 0f)]
        public void GetPerimeterTest_SquareSideLessThanZero_ReturnsZero(float side, float expected)
        {
            var thing = new Square(side);

            var actual = GeometricCalculator.GetPerimeter(thing);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest_GivenCircleSquareTriangleRectangleAndAllParameterOf5_Returns86_4()
        {
            var thing = new GeometricThing[4];

            thing[0] = new Circle(5f);
            thing[1] = new Square(5f);
            thing[2] = new Triangle(5f, 5f, 5f);
            thing[3] = new Rectangle(5f, 5f);

            var actual = GeometricCalculator.GetPerimeter(thing);

            Assert.AreEqual(86.4, actual, 0.1);
        }
    }
}