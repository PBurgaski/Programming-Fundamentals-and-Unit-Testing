using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    TopIntegers ti;
    [SetUp]
    public void SetUp()
    {
        ti = new TopIntegers();
    }

    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        // Arrange
        int[] input = Array.Empty<int>();
        string expected = string.Empty;

        // Act
        string result = ti.FindTopIntegers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        // Arrange
        int[] input = new int[]
        {
            17, 16, 15
        };
        string expected = "17 16 15";

        // Act
        string result = ti.FindTopIntegers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        // Arrange
        int[] input = new int[]
        {
            17
        };
        string expected = "17";

        // Act
        string result = ti.FindTopIntegers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        // Arrange
        int[] input = new int[]
        {
            17, 30, 15, 24, 10, 19
        };
        string expected = "30 24 19";

        // Act
        string result = ti.FindTopIntegers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
