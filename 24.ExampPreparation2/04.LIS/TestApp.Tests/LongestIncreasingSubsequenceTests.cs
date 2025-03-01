using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[] ints = null;


        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => LongestIncreasingSubsequence.GetLis(ints));
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] ints = new int[] { };
        string expected = string.Empty;

        // Act
        string result = LongestIncreasingSubsequence.GetLis(ints);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrange
        int[] ints = new int[] 
        {
            5
        };
        string expected = "5";

        // Act
        string result = LongestIncreasingSubsequence.GetLis(ints);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrange
        int[] ints = new int[] 
        {
            4, 1, 9
        };
        string expected = "4 9";

        // Act
        string result = LongestIncreasingSubsequence.GetLis(ints);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        // Arrange
        int[] ints = new int[] 
        {
            2, 3, 4
        };
        string expected = "2 3 4";

        // Act
        string result = LongestIncreasingSubsequence.GetLis(ints);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
