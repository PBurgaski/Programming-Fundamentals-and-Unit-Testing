using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] onlyEvenNumsInArr = new int[]
        {
            2, 4, 6, 8
        };
        int expected = 20;

        // Act
        int result = EvenOddSubtraction.FindDifference(onlyEvenNumsInArr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] onlyOddNumsInArr = new int[]
        {
            1, 3, 5, 7, 9
        };
        int expected = 25;

        // Act
        int result = EvenOddSubtraction.FindDifference(onlyOddNumsInArr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] mixedNumsInArr = new int[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9
        };
        int expected = 5;

        // Act
        int result = EvenOddSubtraction.FindDifference(mixedNumsInArr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
