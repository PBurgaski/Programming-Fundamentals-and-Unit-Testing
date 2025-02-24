using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";
        bool expected = true;

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "testexample.com";
        bool expected = false;

        // Act
        bool result = Email.IsValidEmail(invalidEmail);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string nullInput = string.Empty;
        bool expected = false;

        // Act
        bool result = Email.IsValidEmail(nullInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
