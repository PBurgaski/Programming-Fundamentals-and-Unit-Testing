using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = new char[]
        {
            'a', '6', 'b', 'c', '9'
        };
        char[] expected = new char[]
        {
            'a', 'b', 'c'
        };

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = new char[]
        {
            'a', 'b', 'c'
        };
        char[] expected = new char[]
        {
            'a', 'b', 'c'
        };

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = Array.Empty<char>();
        char[] expected = Array.Empty<char>();

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
