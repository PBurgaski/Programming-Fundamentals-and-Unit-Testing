using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [Test]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage()
    {
        // Arrange
        string invalidInput = "numbers";
        string expected = "The input is not an integer!";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(invalidInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        // Arrange
        string zeroInput = "0";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(zeroInput);
        string expected = $"The number {int.Parse(zeroInput)} is zero.";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {
        // Arrange
        string negativeInput = "-10";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(negativeInput);
        string expected = $"The number {int.Parse(negativeInput)} is negative.";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        // Arrange
        string positiveInput = "10";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(positiveInput);
        string expected = $"The number {int.Parse(positiveInput)} is positive.";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
