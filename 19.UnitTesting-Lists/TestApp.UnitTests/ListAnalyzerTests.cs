using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        // Arrange
        List<int> emptyList = new();
        string expected = "No elements!";

        // Act
        string result = ListAnalyzer.Analyze(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> singleNumInList = new List<int>
        {
            5
        };
        string expected = $"Element count: {singleNumInList.Count}, Min value: {singleNumInList.Min()}, Max value: {singleNumInList.Max()}, Avg: {singleNumInList.Average():F2}.";

        // Act
        string result = ListAnalyzer.Analyze(singleNumInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> severalDublicatedNumsInList = new List<int>
        {
            4, 4, 4
        };
        string expected = $"Element count: {severalDublicatedNumsInList.Count}, Min value: {severalDublicatedNumsInList.Min()}, Max value: {severalDublicatedNumsInList.Max()}, Avg: {severalDublicatedNumsInList.Average():F2}.";

        // Act
        string result = ListAnalyzer.Analyze(severalDublicatedNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_DiffrentValues_ShouldReturnCorrectValues()
    {
        // Arrange
        List<int> differentNumsInList = new List<int>
        {
            5, 10, 15, 20
        };
        string expected = $"Element count: {differentNumsInList.Count}, Min value: {differentNumsInList.Min()}, Max value: {differentNumsInList.Max()}, Avg: {differentNumsInList.Average():F2}.";

        // Act
        string result = ListAnalyzer.Analyze(differentNumsInList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
