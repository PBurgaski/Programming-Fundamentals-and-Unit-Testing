using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        // Arrange
        List<char> aLetterInList = new List<char>
        {
            'a'
        };
        string sentance = string.Empty;
        string expected = string.Empty;

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentance, aLetterInList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        // Arrange
        List<char> emptyList = new();
        string sentance = "Nicola Tesla";
        string expected = "Nicola Tesla";

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentance, emptyList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        // Arrange
        List<char> aLetterInList = new List<char>
        {
            'a'
        };
        string sentance = "a";
        string expected = string.Empty;

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentance, aLetterInList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        // Arrange
        List<char> severalLettersInList = new List<char>
        {
            'a', 'e', 'o'
        };
        string sentance = "palindrome";
        string expected = "plindrm";

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentance, severalLettersInList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
