using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> singleNumInList = new List<int>
        {
            2
        };
        int expected = 2;

        // Act
        int result = MaxNumber.FindMax(singleNumInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> positiveNumsInList = new List<int>
        {
            2, 4, 6, 8
        };
        int expected = 8;

        // Act
        int result = MaxNumber.FindMax(positiveNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> negativeNumsInList = new List<int>
        {
            -2, -4, -6, -8
        };
        int expected = -2;

        // Act
        int result = MaxNumber.FindMax(negativeNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> positiveNumsInList = new List<int>
        {
            2, -4, 6, -8
        };
        int expected = 6;

        // Act
        int result = MaxNumber.FindMax(positiveNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> positiveNumsInList = new List<int>
        {
            2, 4, 6, 8, 8
        };
        int expected = 8;

        // Act
        int result = MaxNumber.FindMax(positiveNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
