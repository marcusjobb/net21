using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRPLive;

namespace SRPLive.Tests;

using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRPLive;


[TestClass()]
public class FileHandlerTests
{
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
