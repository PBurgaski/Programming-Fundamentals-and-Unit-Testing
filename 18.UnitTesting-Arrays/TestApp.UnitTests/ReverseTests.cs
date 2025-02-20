using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] singleElementArr = new int[]
        { 
            42 
        };
        // Act
        string result = Reverse.ReverseArray(singleElementArr);

        // Assert
        Assert.That(result, Is.EqualTo("42"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] multipleElementsArr = new int[]
        {
            10, 20, 30, 40, 50
        };
        // Act
        string result = Reverse.ReverseArray(multipleElementsArr);
        // Assert
        Assert.That(result, Is.EqualTo("50 40 30 20 10"));

    }
}
