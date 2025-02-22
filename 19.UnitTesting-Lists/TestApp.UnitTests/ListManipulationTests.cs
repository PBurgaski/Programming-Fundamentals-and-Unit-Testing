using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListManipulationTests
{
    [Test]
    public void Test_RemoveNegativesAndReverse_EmptyListInput_ReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();
        List<int> expected = new();

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyNegativeNumbers_ReturnEmptyList()
    {
        // Arrange
        List<int> onlyNegativeNumsInList = new List<int>
        {
            -5, -10, -15, -20
        };
        List<int> expected = new();

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(onlyNegativeNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyOnePositiveNumber_ReturnSameCollection()
    {
        // Arrange
        List<int> singlePositiveNumInList = new List<int>
        {
            -5, -10, -15, -20, 20
        };
        List<int> expected = new List<int>
        {
            20
        };

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(singlePositiveNumInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyPositiveNumbers_ReturnRevursedList()
    {
        // Arrange
        List<int> onlyPositiveNumsInList = new List<int>
        {
            5, 10, 15, 20
        };
        List<int> expected = new List<int>
        {
            20, 15, 10, 5
        };

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(onlyPositiveNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_PostiveAndNegativeElements_ReturnPositiveNumbersInReversedOrder()
    {
        // Arrange
        List<int> mixedNumsInList = new List<int>
        {
            -5, -10, -15, -20, 15, 10, 20
        };
        List<int> expected = new List<int>
        {
            20, 10, 15
        };

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(mixedNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
