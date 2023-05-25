using Xunit;

namespace VeggieFood.Tests
{
    public class MathTests
    {
        [Fact]
        public void Add_WithTwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expectedSum = 15;

            var math = new Math();

            // Act
            int actualSum = math.Add(a, b);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }
    }

    public class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}