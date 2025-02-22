﻿using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{

    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> numsWithoutAdjacentInList = new List<int>
        {
            1, 2, 3, 4, 5
        };
        string expected = "1 2 3 4 5";

        // Act
        string result = AdjacentEqual.Sum(numsWithoutAdjacentInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> singleAdjacentNumInList = new List<int>
        {
            1, 2, 3, 3, 4, 5, 5, 6
        };
        string expected = "1 2 6 4 10 6";

        // Act
        string result = AdjacentEqual.Sum(singleAdjacentNumInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> allAdjacentNumsInList = new List<int>
        {
            5, 5, 5, 5
        };
        string expected = "20";

        // Act
        string result = AdjacentEqual.Sum(allAdjacentNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> severalAdjacentNumsInList = new List<int>
        {
            1, 1, 2, 3, 4, 5
        };
        string expected = "2 2 3 4 5";

        // Act
        string result = AdjacentEqual.Sum(severalAdjacentNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> severalAdjacentNumsInList = new List<int>
        {
            1, 2, 3, 4, 5, 5
        };
        string expected = "1 2 3 4 10";

        // Act
        string result = AdjacentEqual.Sum(severalAdjacentNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> oneAdjacentNumInList = new List<int>
        {
            1, 2, 3, 3, 4, 5
        };
        string expected = "1 2 6 4 5";

        // Act
        string result = AdjacentEqual.Sum(oneAdjacentNumInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
