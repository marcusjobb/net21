using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDLiveTorsd13Jan.Helpers.Tests
{
    [TestClass()]
    public class YearCheckTests
    {
        [TestMethod()]
        [DataRow(1970, false)]
        [DataRow(2023, false)]
        [DataRow(2020, true)]
        public void IsLeapyearTest (int year, bool expected)
        {
            // Arrange

            // Act
            var actual = YearCheck.IsLeapyear(year);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(1970)]
        public void IsNotLeapYearTest (int year)
        {
            // Act
            var actual = YearCheck.IsLeapyear(year);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        [DataRow(2020)]
        public void IsReallyLeapYearTest (int year)
        {
            // Act
            var actual = YearCheck.IsLeapyear(year);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}