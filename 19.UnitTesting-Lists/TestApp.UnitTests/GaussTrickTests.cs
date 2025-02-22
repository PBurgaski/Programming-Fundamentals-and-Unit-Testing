using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> singleElementInList = new List<int>
        {
            5
        };
        List<int> expected = new List<int>
        {
            5
        };

        // Act
        List<int> result = GaussTrick.SumPairs(singleElementInList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenCountOfNumsInList = new List<int>
        {
            2, 4, 6, 8
        };
        List<int> expected = new List<int>
        {
            10, 10
        };

        // Act
        List<int> result = GaussTrick.SumPairs(evenCountOfNumsInList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> oddCountOfNumsInList = new List<int>
        {
            2, 4, 6, 8, 10
        };
        List<int> expected = new List<int>
        {
            12, 12, 6
        };

        // Act
        List<int> result = GaussTrick.SumPairs(oddCountOfNumsInList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenCountOfNumsInList = new List<int>
        {
            2, 4, 6, 8, 10, 12, 14, 16
        };
        List<int> expected = new List<int>
        {
            18, 18, 18, 18
        };

        // Act
        List<int> result = GaussTrick.SumPairs(evenCountOfNumsInList);

        // Assert
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> evenCountOfNumsInList = new List<int>
        {
            2, 4, 6, 8, 10, 12, 14
        };
        List<int> expected = new List<int>
        {
            16, 16, 16, 8
        };

        // Act
        List<int> result = GaussTrick.SumPairs(evenCountOfNumsInList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
