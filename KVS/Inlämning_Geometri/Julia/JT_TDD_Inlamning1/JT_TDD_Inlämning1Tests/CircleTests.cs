using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JT_TDD_Inlämning1.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void AreaTest_CircleRadiusOf10_Return314_15()
        {
            GeometricThing circle = new Circle(radius: 10f);

            var actual = circle.Area();

            Assert.AreEqual(314.15, actual, 0.01);
        }

        [TestMethod()]
        [DataRow(0f, 0f)]
        [DataRow(-20f, 0f)]
        public void AreaTest_CircleRadiusLessThanZero_ReturnsZero(float radius, float expected)
        {
            GeometricThing circle = new Circle(radius);

            var actual = circle.Area();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(0f, 0f)]
        [DataRow(-20f, 0f)]
        public void PerimeterTest_CircleRadiusLessThanZero_ReturnsZero(float radius, float expected)
        {
            GeometricThing circle = new Circle(radius);

            var actual = circle.Perimeter();

            Assert.AreEqual(expected, actual);
        }
    }
}