using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = Array.Empty<int>();
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.That(result, Is.Negative.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[]
        {
            1
        };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.That(result, Is.Negative.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[]
        {
            10, 20, -30, 40, 50
        };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.That(result, Is.Negative.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] 
        {
            -1, -1
        };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.That(result, Is.Negative.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] input = new int[] 
        { 
            1, 2, 1, 2
        };
        int expected = 1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.That(result, Is.Positive.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] input = new int[] 
        {
            5, 6, -7, 8, 6, -7, 8
        };
        int expected = 6;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(input);

        // Assert
        Assert.That(result, Is.Positive.And.EqualTo(expected));
    }
}
