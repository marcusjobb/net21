using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRPLive;

namespace SRPLive.Tests;

using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRPLive;

/// <summary>
/// Test for Filehandler
/// </summary>
[TestClass()]
public class FileHandlerTests
{
    /// <summary>
    /// Loads the test file that does not exist.
    /// </summary>
    [TestMethod()]
    public void LoadTestFileDoesNotExist ()
    {
        // Arrange
        var sut = new FileHandler() { Filename = "z:\\z.z" };

        // Act
        var actual = sut.Load();

        // Assert
        Assert.AreEqual(string.Empty, actual);
    }

    /// <summary>
    /// Loads the test file that does exist.
    /// </summary>
    [TestMethod()]
    public void LoadTestFileDoesExist ()
    {
        // Arrange
        const string expected = "test";
        const string filename = "test.txt";
        File.WriteAllText(filename, expected);
        var sut = new FileHandler() { Filename = filename };

        // Act
        var actual = sut.Load();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    /// <summary>
    /// Tries to save the test when write protected.
    /// </summary>
    [TestMethod()]
    public void SaveTestWhenWriteProtected ()
    {
        // Arrange
        // Won't work if user is Admin
        var filename = @"c:\windows\test.txt";
        var sut = new FileHandler { Filename = filename };

        // Act
        sut.Save("Hello world");

        // Assert
        Assert.IsFalse(File.Exists(filename));
    }

    /// <summary>
    /// Saves the test.
    /// </summary>
    [TestMethod()]
    public void SaveTest ()
    {
        // Arrange
        var filename = "test.txt";
        var sut = new FileHandler { Filename = filename };

        // Act
        sut.Save("Hello world");

        // Assert
        Assert.IsTrue(File.Exists(filename));
    }
}
