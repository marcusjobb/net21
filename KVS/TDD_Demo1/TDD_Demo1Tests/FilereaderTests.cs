// -----------------------------------------------------------------------------------------------
//  FilereaderTests.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace Namespace.Tests;

using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass()]
public class FilereaderTests
{
    [TestInitialize]
    public void Init () => File.WriteAllText("MinTest.txt", "Hello World");

    [TestMethod()]
    [DataRow("", @"z:\hello.txt")]
    [DataRow("Hello World", "MinTest.txt")]
    public void ReadTest (string expected, string data)
    {
        // Act
        var actual = Filereader.Read(data);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}