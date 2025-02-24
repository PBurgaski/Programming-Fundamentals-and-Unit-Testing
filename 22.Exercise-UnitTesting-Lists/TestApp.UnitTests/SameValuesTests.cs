using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        // Arrange
        List<int> sameValues1 = new();
        List<int> sameValues2 = new() 
        {
            1, 2 
        };
        List<int> expected = new();
        // Act
        List<int> result = SameValues.FindSameValues(sameValues1, sameValues2);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        // Arrange
        List<int> sameValues2 = new();
        List<int> sameValues1 = new()
        {
            1, 2
        };
        List<int> expected = new();
        // Act
        List<int> result = SameValues.FindSameValues(sameValues1, sameValues2);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    { 
        // Arrange
        List<int> sameValues1 = new()
        {
            1, 2 , 3
        };
    List<int> sameValues2 = new()
        {
            4, 5, 6
        };
    List<int> expected = new();
    // Act
    List<int> result = SameValues.FindSameValues(sameValues1, sameValues2);

    // Assert
    CollectionAssert.AreEqual(expected, result);
    }
    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
       {
        // Arrange
        List<int> sameValues1 = new()
        {
            1, 2
        };
    List<int> sameValues2 = new()
        {
            1, 2
        };
    List<int> expected = new()
        {
            1, 2
        };
    // Act
    List<int> result = SameValues.FindSameValues(sameValues1, sameValues2);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
