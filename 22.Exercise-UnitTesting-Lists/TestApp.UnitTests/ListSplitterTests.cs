using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        // Arrange
        List<int> input = new();

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.evens, Is.Empty);
        Assert.That(result.odds, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        // Arrange
        List<int> input = new()
        {
            2, 4, 6, 8
        };
        List<int> expected = new()
        {
            2, 4, 6, 8
        };

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.evens, Is.EqualTo(expected));
        Assert.That(result.odds, Is.Empty);

    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        // Arrange
        List<int> input = new()
        {
            1, 3, 5, 7, 9
        };
        List<int> expected = new()
        {
            1, 3, 5, 7, 9
        };

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.evens, Is.Empty);
        Assert.That(result.odds, Is.EqualTo(expected));

    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        // Arrange
        List<int> input = new()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9
        };
        List<int> expectedEven = new()
        {
            2, 4, 6, 8
        };
        List<int> expectedOdd = new()
        {
            1, 3, 5, 7, 9
        };

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.evens, Is.EqualTo(expectedEven));
        Assert.That(result.odds, Is.EqualTo(expectedOdd));

    }
}
