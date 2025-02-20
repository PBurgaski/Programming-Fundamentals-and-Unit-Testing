using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        // Arrange
        int[] singleElementInArr = new int[]
        {
              0
        };
        int[] expected = Array.Empty<int>();

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(singleElementInArr);

        // Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        // Arrange
        int[] singleElementInArr = new int[]
        {
            4
        };
        int[] expected = Array.Empty<int>();

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(singleElementInArr);

        // Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        // Arrange
        int[] noPrimeNumsInArr = new int[]
        {
            10, 12, 15, 21
        };
        int[] expected = Array.Empty<int>();

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(noPrimeNumsInArr);

        // Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        // Arrange
        int[] singlePrimeNumInArr = new int[]
        {
            3, 4, 6
        };
        int[] expected = new int[]
        {
            3
        };

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(singlePrimeNumInArr);

        // Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        // Arrange
        int[] mixedNumsInArr = new int[]
        {
              3, 4, 5, 6
        };
        // Act
        int[] expected = new int[]
{
            3, 5
};

        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(mixedNumsInArr);

        // Assert 
        Assert.That(result, Is.EqualTo(expected));
    }
}
