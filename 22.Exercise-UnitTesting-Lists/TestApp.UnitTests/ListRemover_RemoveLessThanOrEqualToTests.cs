using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new();
        int threshold = 20;
        List<int> expected = new();

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new()
        {
            20, 15, 10, 5
        };
        int threshold = 20;
        List<int> expected = new();

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new()
        {
             44, 55, 65
        };
        int threshold = 20;
        List<int> expected = new()
        {
            44, 55, 65
        };

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        // Arrange
        List<int> input = new()
        {
            20, 44, 55, 15, 10, 5
        };
        int threshold = 20;
        List<int> expected = new()
        {
            44, 55
        };

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
