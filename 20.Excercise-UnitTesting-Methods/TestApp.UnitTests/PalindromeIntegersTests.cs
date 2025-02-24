using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    PalindromeIntegers pi;

    [SetUp]
    public void SetUp()
    {
        pi = new PalindromeIntegers();
    }

    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        List<int> emptyList = new();
        List<int> expected = new();

        // Act
        List<int> result = pi.FindPalindromes(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        // Arrange
        List<int> noPalinList = new List<int>
        {
            123, 321, 522
        };
        List<int> expected = new();

        // Act
        List<int> result = pi.FindPalindromes(noPalinList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> singleDigitsList = new List<int>
        {
            4, 3, 2, 1
        };
        List<int> expected = new List<int>
        {
            4, 3, 2, 1
        };

        // Act
        List<int> result = pi.FindPalindromes(singleDigitsList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> allPalinsList = new List<int>
        {
            424, 333, 202, 101
        };
        List<int> expected = new List<int>
        {
            424, 333, 202, 101
        };

        // Act
        List<int> result = pi.FindPalindromes(allPalinsList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> mixedPalinsList = new List<int>
        {
            424, 333, 204, 102
        };
        List<int> expected = new List<int>
        {
            424, 333
        };

        // Act
        List<int> result = pi.FindPalindromes(mixedPalinsList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
