using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JT_TDD_Inlämning1.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void AreaTest_TriangleTbaseIs10SideIs10HeightIs10_Returns50()
        {
            var thing = new Triangle(10f, 10f, 10f);

            var actual = thing.Area();

            Assert.AreEqual(50, actual);
        }

        [TestMethod()]
        public void PerimeterTest_TriangleTbaseIs10SideIs10HeightIs10_Returns30()
        {
            var thing = new Triangle(10f, 10f, 10f);

            var actual = thing.Perimeter();

            Assert.AreEqual(30, actual);
        }

        [TestMethod()]
        [DataRow(0f, 0f, 0f, 0f)]
        [DataRow(-20f, 20f, 50f, 0f)]
        [DataRow(null, 50f, 80f, 0f)]
        public void PerimeterTest_TriangleWithOneSideLessThanZero_ReturnsZero(float tbase, float side, float height, float expected)
        {
            var thing = new Triangle(tbase, side, height);

            var actual = thing.Perimeter();

            Assert.AreEqual(expected, actual);
        }
    }
}