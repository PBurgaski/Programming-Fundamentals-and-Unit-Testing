using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arrange
        string expected = "";
        // Act
        string result = Triangle.PrintTriangle(0);
        // Assert 
        Assert.AreEqual(expected, result, "The triangle method did not work properly.");
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        string expected =
            "1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";
        // Act
        string result = Triangle.PrintTriangle(3);
        // Assert 
        Assert.AreEqual(expected, result, "The triangle method did not work properly.");
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arrange
        string expected = 
            "1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3 4 5" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";
        // Act
        string result = Triangle.PrintTriangle(5);
        // Assert 
        Assert.AreEqual(expected, result, "The triangle method did not work properly.");
    }
}
