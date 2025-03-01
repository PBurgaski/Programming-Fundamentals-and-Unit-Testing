using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "5 5 13 13")]
    [TestCase(new int[] { } , "")]
    [TestCase(new int[] { 2, 3, 3, 4, 5, 6, 0, -1 }, "6 6 4 6")]
    [TestCase(new int[] { 4, 5, 3, 4, 5, -6, 2, 3 }, "8 8 8 -4")]
    [TestCase(new int[] { 6, -7, 3, 4, 5, 6, 4, 5 }, "-4 10 10 10")]
    [TestCase(new int[] { 0, 0, 3, 4, 5, 6, 0, 0 }, "3 4 5 6")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        // Act 
        string result = FoldSum.FoldArray(arr);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
