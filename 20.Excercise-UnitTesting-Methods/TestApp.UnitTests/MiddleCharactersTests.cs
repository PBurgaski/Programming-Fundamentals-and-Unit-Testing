using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string emptyInput = string.Empty;
        string expected = "Empty string";

        // Act
        string result = MiddleCharacters.GetMiddleChars(emptyInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string whiteSpaceInput = " ";
        string expected = "Empty string";

        // Act
        string result = MiddleCharacters.GetMiddleChars(whiteSpaceInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        // Arrange
        string singleCharInput = "a";
        string expected = "a";

        // Act
        string result = MiddleCharacters.GetMiddleChars(singleCharInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        // Arrange
        string evenStringInput = "Burgaski";
        string expected = "ga";

        // Act
        string result = MiddleCharacters.GetMiddleChars(evenStringInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        // Arrange
        string oddStringInput = "Burgaski.";
        string expected = "a";

        // Act
        string result = MiddleCharacters.GetMiddleChars(oddStringInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
