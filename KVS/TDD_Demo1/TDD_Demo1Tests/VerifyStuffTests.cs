// -----------------------------------------------------------------------------------------------
//  VerifyStuffTests.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Namespace.Tests
{
    [TestClass()]
    public class VerifyStuffTests
    {
        [TestMethod()]
        public void VerifyPhoneNumberTestWithLetters ()
        {
            // Arrange
            var sut = new VerifyStuff();
            var expected = false;
            var testData = "+46000000000 Katt";

            // Act
            var actual = sut.VerifyPhoneNumber(testData);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VerifyPhoneNumberTestWithoutPlus ()
        {
            // Arrange
            var c = new VerifyStuff();
            var expected = false;
            var testData = "000000000";
            // Act
            var actual = c.VerifyPhoneNumber(testData);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VerifyPhoneNumberTestWithPlus ()
        {
            // Arrange
            var sut = new VerifyStuff();
            var expected = true;
            var testData = "+46000000000";

            // Act
            var actual = sut.VerifyPhoneNumber(testData);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

// -----------------------------------------------------------------------------------------------
//  VerifyStuffTests.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------