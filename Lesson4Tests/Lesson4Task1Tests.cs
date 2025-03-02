using Newtonsoft.Json.Linq;

namespace Lesson4
{
    public class Lesson4Task1Tests
    {
        [Theory(DisplayName = "Урок 4. Задание 1. Факториал рекурсивно.")]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void FactorialRecursion_SomeData_Result(int n)
        {
            // Arrange
            int resultExpected = 1;
            for (var i = 1; i <= n; i++)
            {
                resultExpected *= i;
            }
            // Act
            var result = Lesson4.Tasks.FactorialRecursion(n);
            // Assert
            Assert.Equal(resultExpected, result);

        }
        [Fact]
        public void FactorialRecursion_NegativeInt_Null()
        {
            // Arrange
            int n = -1;
            int? resultExpected = null;
            // Act
            var result = Lesson4.Tasks.FactorialRecursion(n);
            // Assert
            Assert.Equal(resultExpected, result);

        }
    }
}