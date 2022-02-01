using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class TestingTheCyclomaticIndexTests
    {
        [TestMethod()]
        [DataRow(0, "Hello")]
        [DataRow(-1, "Good bye")]
        public void GetMeAStringTest (int value, string expected)
        {
            var actual = TestingTheCyclomaticIndex.GetMeAString(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(1337,"Leet!")]
        [DataRow(10,"Tio")]
        [DataRow(-1, "")]
        public void LeetTest(int value, string expected)
        {
            var actual = TestingTheCyclomaticIndex.Leet(value);
            Assert.AreEqual(expected, actual);
        }
    }
}