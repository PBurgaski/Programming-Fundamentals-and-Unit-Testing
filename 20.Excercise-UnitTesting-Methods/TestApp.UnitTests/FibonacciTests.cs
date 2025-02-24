using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int zeroInput = 0;
        int expected = 0;

        // Act
        int result = Fibonacci.CalculateFibonacci(zeroInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int positiveInput = 5;
        int expected = 5;

        // Act
        int result = Fibonacci.CalculateFibonacci(positiveInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}