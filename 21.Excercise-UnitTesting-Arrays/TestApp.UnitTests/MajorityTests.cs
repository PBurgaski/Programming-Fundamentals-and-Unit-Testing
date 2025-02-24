﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        // Arrange
        int[] input = Array.Empty<int>();
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        // Arrange
        int[] input = new int[]
        {
            0, 0, 0, 0
        };
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        // Arrange
        int[] input = new int[]
        {
            1, 2, 3, 4, 5, 6
        };
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        // Arrange
        int[] input = new int[]
        {
            1, 2, 3, 4, 5, 6, 7
        };
        int expected = -1;

        // Act
        int result = Majority.IsEvenOrOddMajority(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        // Arrange
        int[] input = new int[]
        {
            1, 2, 3, 4, 5, 6, 8
        };
        int expected = 1;

        // Act
        int result = Majority.IsEvenOrOddMajority(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
