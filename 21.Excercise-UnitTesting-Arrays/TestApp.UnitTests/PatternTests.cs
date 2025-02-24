using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] input = new int[]
        {
            1, 2, 3, 4, 5, 1, 4, 2, 55, 23, 94, 69
        };
        int[] expected = new int[]
        {
            1, 94, 2, 69, 3, 55, 4, 23, 5
        };

        // Act
        int[] result = Pattern.SortInPattern(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = Array.Empty<int>();
        int[] expected = Array.Empty<int>();

        // Act
        int[] result = Pattern.SortInPattern(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] input = new int[]
        {
            1
        };
        int[] expected = new int[]
        {
            1
        };

        // Act
        int[] result = Pattern.SortInPattern(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
