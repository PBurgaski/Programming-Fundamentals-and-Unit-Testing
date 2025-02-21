using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        // Arrange
        string[] emptyArr = Array.Empty<string>();

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(emptyArr);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        // Arrange
        string[] singleOddWordInArr = new string[]
        {
            "updated"
        };

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(singleOddWordInArr);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        // Arrange
        string[] oddWordsInArr = new string[]
        {
             "Sofia", "Varna", "Plovdiv"
        };

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(oddWordsInArr);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        // Arrange
        string[] singleEvenWordInArr = new string[]
        {
            "Burgaski"
        };
        string expected = "Burgaski";

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(singleEvenWordInArr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        // Arrange
        string[] evenAndOddWordsInArr = new string[]
        {
            "Burgaski", "is", "good", "in", "testing.", "lek"
        };
        string expected = "Burgaski is good in testing.";

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(evenAndOddWordsInArr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

