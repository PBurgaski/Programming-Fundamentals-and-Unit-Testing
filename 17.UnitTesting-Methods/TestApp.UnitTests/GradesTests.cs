using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [Test]
    public void Test_GradeAsWords_ReturnsCorrectString()
    {
        // Arrange
        double grade = 2.60;
        string expected = "Fail";
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual, "The grades method did not work as expected.");
    }
    [TestCase(-6.00, "Invalid!")]
    [TestCase(0, "Invalid!")]
    [TestCase(1.00, "Invalid!")]
    [TestCase(1.99, "Invalid!")]
    [TestCase(2.00, "Fail")]
    [TestCase(2.99, "Fail")]
    [TestCase(3.00, "Average")]
    [TestCase(3.01, "Average")]
    [TestCase(3.49, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(3.51, "Good")]
    [TestCase(4.49, "Good")]
    [TestCase(4.50, "Very Good")]
    [TestCase(4.51, "Very Good")]
    [TestCase(5.49, "Very Good")]
    [TestCase(5.50, "Excellent")]
    [TestCase(5.51, "Excellent")]
    [TestCase(5.99, "Excellent")]
    [TestCase(6.00, "Excellent")]
    [TestCase(6.01, "Invalid!")]
    [TestCase(7.00, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual, "The grades method did not work as expected.");
    }
}
