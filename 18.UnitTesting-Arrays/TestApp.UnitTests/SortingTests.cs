using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SortingTests
{
    [Test]
    public void Test_ShallowAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        // Arrange
        double[] emptyArr = Array.Empty<double>();
        double[] expected = Array.Empty<double>();

        // Act
        double[] result = Sorting.ShallowAscendingSort(emptyArr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_DeepAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        // Arrange
        double[] emptyArr = Array.Empty<double>();
        double[] expected = Array.Empty<double>();

        // Act
        double[] result = Sorting.DeepAscendingSort(emptyArr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ShallowAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesNotChangeTheOriginalArray()
    {
        // Arrange
        double[] unorderedNumsInArr = new double[]
        {
            3.14, 69.9, 25.55
        };
        double[] expected = new double[]
        {
            3.14, 25.55, 69.9
        };

        // Act
        double[] result = Sorting.ShallowAscendingSort(unorderedNumsInArr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DeepAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesChangeTheOriginalArray()
    {
        // Arrange
        double[] unorderedNumsInArr = new double[]
        {
            3.14, 69.9, 25.55
        };
        double[] expected = new double[]
        {
            3.14, 25.55, 69.9
        };
        
        // Act
        double[] result = Sorting.DeepAscendingSort(unorderedNumsInArr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
