using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new();
        int threshold = 20;
        List<int> expected = new();

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new()
        {
            33, 44, 55, 
        };
        int threshold = 20;
        List<int> expected = new();

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new()
        {
            20, 15, 10, 5
        };
        int threshold = 20;
        List<int> expected = new()
        {
            20, 15, 10, 5
        };

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> input = new()
        {
            20, 44, 55, 15, 10, 5
        };
        int threshold = 20;
        List<int> expected = new()
        {
            20, 15, 10, 5
        };

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
