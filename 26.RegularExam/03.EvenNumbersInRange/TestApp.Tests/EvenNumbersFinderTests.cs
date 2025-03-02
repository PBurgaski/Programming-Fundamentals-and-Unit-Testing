using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class EvenNumbersFinderTests
    {
        [Test]
        public void Test_FindEvenNumbers_StartGreaterThanEnd_ReturnsErrorMessage()
        {
            // Arrange
            int start = 10;
            int end = 1;
            string expected = "Start number should not be greater than end number.";

            // Act
            string result = EvenNumbersFinder.FindEvenNumbers(start, end);

            // Assert
            CollectionAssert.AreEqual(result, expected);
        }

        [Test]
        public void Test_FindEvenNumbers_NoEvenNumbersInRange_ReturnsEmptyString()
        {
            // Arrange
            int start = 1;
            int end = 1;
            string expected = string.Empty;

            // Act
            string result = EvenNumbersFinder.FindEvenNumbers(start, end);

            // Assert
            CollectionAssert.AreEqual(result, expected);
        }

        [Test]
        public void Test_FindEvenNumbers_SingleEvenNumberInRange_ReturnsThatNumber()
        {
            // Arrange
            int start = 1;
            int end = 3;
            string expected = "2";

            // Act
            string result = EvenNumbersFinder.FindEvenNumbers(start, end);

            // Assert
            CollectionAssert.AreEqual(result, expected);
        }

        [Test]
        public void Test_FindEvenNumbers_MultipleEvenNumbersInRange_ReturnsEvenNumbers()
        {
            // Arrange
            int start = 1;
            int end = 10;
            string expected = "2 4 6 8 10";

            // Act
            string result = EvenNumbersFinder.FindEvenNumbers(start, end);

            // Assert
            CollectionAssert.AreEqual(result, expected);
        }

        [Test]
        public void Test_FindEvenNumbers_ZeroInRange_ReturnsZero()
        {
            // Arrange
            int start = 0;
            int end = 0;
            string expected = "0";

            // Act
            string result = EvenNumbersFinder.FindEvenNumbers(start, end);

            // Assert
            CollectionAssert.AreEqual(result, expected);
        }
    }
}
