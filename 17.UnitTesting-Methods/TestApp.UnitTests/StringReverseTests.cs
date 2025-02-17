using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";
        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, result, "String reverse with empty string did not work properly.");
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";
        string expected = "a";
        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, result, "String reverse with single character in string did not work properly.");
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "Burgaski";
        string expected = "iksagruB";
        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, result, "String reverse with normal string did not work properly.");
    }
}
