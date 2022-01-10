// -----------------------------------------------------------------------------------------------
//  CalcTests.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Namespace.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void AddTest_Sum16 ()
        {
            // Arrange
            //var testObject = new Calc();
            var expected = 16;

            // Act
            var actual = Calc.Add(10, 6);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTest_Sum8 ()
        {
            // Arrange
            //var testObject = new Calc();
            var expected = 8;

            // Act
            var actual = Calc.Add(4, 4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTest_SumMinus5 ()
        {
            // Arrange
            //var testObject = new Calc();
            var expected = 5;

            // Act
            var actual = Calc.Add(10, -5);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}