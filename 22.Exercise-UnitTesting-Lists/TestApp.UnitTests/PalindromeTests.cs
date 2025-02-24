using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new()
        {
            "madam" , "oho"
        };
        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();
        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> words = new()
        {
            "madam" 
        };
        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> words = new()
        {
            "madama"
        };
        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new()
        {
            "maDam"
        };
        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }
}
