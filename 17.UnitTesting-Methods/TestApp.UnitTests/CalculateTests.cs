using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition()
    {
        // Arrange
        Calculate calculator = new();
        int firstNumber = 5;
        int secondNumber = 2;
        int expected = 7;

        // Act
        int actual = calculator.Addition(firstNumber, secondNumber);

        // Assert
        Assert.AreEqual(expected, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Subtraction()
    {
        // Arrange
        Calculate calculator = new();
        int firstNumber = 5;
        int secondNumber = 2;
        int expected = 3;

        // Act
        int actual = calculator.Subtraction(firstNumber, secondNumber);

        // Assert
        Assert.AreEqual(expected, actual, "Addition did not work properly.");
    }
}
