using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests
{
    [TestFixture]
    public class ConsonantsCounterTests
    {
        [Test]
        public void Test_CountTotalConsonants_GetEmptyList_ReturnsZero()
        {
            // Arrange
            List<string> input = new List<string>();
            int expected = 0;

            // Act
            int result = ConsonantsCounter.CountTotalConsonants(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_GetListWithEmptyStringValues_ReturnsZero()
        {
            // Arrange
            List<string> input = new List<string>() 
            {
                string.Empty 
            };
            int expected = 0;

            // Act
            int result = ConsonantsCounter.CountTotalConsonants(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_MultipleStrings_ReturnsConsonantsCount()
        {
            // Arrange
            List<string> input = new List<string>() 
            {
                "first", "second" 
            };
            int expected = 8;

            // Act
            int result = ConsonantsCounter.CountTotalConsonants(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_GetStringsWithNoConsonants_ReturnsZero()
        {
            // Arrange
            List<string> input = new List<string>()
            {
                "aia", "ooo"
            };
            int expected = 0;

            // Act
            int result = ConsonantsCounter.CountTotalConsonants(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_StringsWithMixedCaseConsonants_ReturnsConsonantsCount()
        {
            // Arrange
            List<string> input = new List<string>()
            {
                "FirsT", "seCond"
            };
            int expected = 8;

            // Act
            int result = ConsonantsCounter.CountTotalConsonants(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }

}

