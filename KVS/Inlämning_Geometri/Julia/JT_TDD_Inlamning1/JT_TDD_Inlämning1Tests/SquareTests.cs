using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JT_TDD_Inlämning1.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        public void AreaTest_SquareSideIs30_Returns100()
        {
            var thing = new Square(10f);

            var actual = thing.Area();

            Assert.AreEqual(100, actual);
        }

        [TestMethod()]
        public void PerimeterTest_SquareSideIs60_Returns240()
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