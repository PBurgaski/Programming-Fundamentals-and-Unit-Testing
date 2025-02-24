using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        // Arrange
        List<double> inputList = new()
        {
            1, 1.5, 1.7
        };
        string expected = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(inputList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        // Arrange
        List<double> inputList = new()
        {
            6.3, 6.5, 6.6
        };
        string expected = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(inputList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {
        // Arrange
        List<double> inputList = new()
        {
            2.3, 2.5, 2.6
        };
        string expected = "Fail";

        // Act
        string result = AverageGrade.GetGradeDefinition(inputList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        // Arrange
        List<double> inputList = new()
        {
            3.3, 3.5, 3.6
        };
        string expected = "Poor";

        // Act
        string result = AverageGrade.GetGradeDefinition(inputList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        {
            // Arrange
            List<double> inputList = new()
        {
            4.3, 4.5, 4.6
        };
            string expected = "Good";

            // Act
            string result = AverageGrade.GetGradeDefinition(inputList);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        {
            // Arrange
            List<double> inputList = new()
        {
            5.3, 5.5, 5.6
        };
            string expected = "Very good";

            // Act
            string result = AverageGrade.GetGradeDefinition(inputList);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        {
            // Arrange
            List<double> inputList = new()
        {
            6, 5.9, 6.1
        };
            string expected = "Excellent";

            // Act
            string result = AverageGrade.GetGradeDefinition(inputList);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
