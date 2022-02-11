using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JT_TDD_Inlämning1.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void AreaTest_RectangleWidth10AndHeight30_Returns300()
        {
            var thing = new Rectangle(10f, 30f);

            var actual = thing.Area();

            Assert.AreEqual(300, actual);
        }

        [TestMethod()]
        public void PerimeterTest_RectangleWidth20AndHeight5_Returns50()
        {
            var thing = new Rectangle(20f, 5f);

            var actual = thing.Perimeter();

            Assert.AreEqual(50, actual);
        }

        [TestMethod()]
        [DataRow(0f, 0f, 0f)]
        [DataRow(-20f, 20f, 0f)]
        [DataRow(null, 50f, 0f)]
        public void PerimeterTest_RectangleWidthOrHeightLessThanZero_ReturnsZero(float width, float height, float expected)
        {
            var thing = new Rectangle(width, height);

            var actual = thing.Perimeter();

            Assert.AreEqual(expected, actual);
        }
    }
}