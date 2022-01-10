using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Demo2;

namespace TDD_Demo2.Tests
{
    [TestClass()]
    public class ConsoleHelperTests
    {
        [TestMethod()]
        public void CenterTextTest ()
        {
            // Arrange
            var data = "Hej";
            var width = 10;
            var expected = "    Hej";
            // Act
            var actual = ConsoleHelper.CenterText(data, width);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIntTest1 ()
        {
            // Arrange
            var data = "1337";
            var expected = 1337;

            // Act
            var actual = ConsoleHelper.GetInt(data);

            // Assert
            Assert.AreEqual (expected, actual);
        }

        [TestMethod()]
        public void GetIntTest2 ()
        {
            // Arrange
            var data = "Katt";
            var expected = 0;

            // Act
            var actual = ConsoleHelper.GetInt(data);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}