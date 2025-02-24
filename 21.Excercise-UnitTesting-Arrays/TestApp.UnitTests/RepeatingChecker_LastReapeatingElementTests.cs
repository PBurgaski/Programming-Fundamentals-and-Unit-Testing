using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = Array.Empty<int>();
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(result, Is.Negative.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[]
        {
            1
        };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(result, Is.Negative.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[]
        {
            1, 2, 3, 4, 5, 6, 7
        };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[]
        {
            -1, -1
        };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(result, Is.Negative.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] input = new int[]
        {
            1, 2, 1, 2
        };
        int expected = 2;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(result, Is.Positive.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] input = new int[]
        {
            5, 6, -7, 8, 6, -7, 8
        };
        int expected = 8;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(result, Is.Positive.And.EqualTo(expected));
    }
}
