using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace Lesson4
{
    public class Lesson4Task1Tests
    {
        [Theory(DisplayName = "Урок 4. Задание 1. Факториал рекурсивно. Корректные исходные данные.")]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(5, 120)]
        [InlineData(10, 3628800)]
        public void FactorialRecursion_SomeData_Result(int n, int resultExpected)
        {
            // Arrange
            int resultCalculated = 1;
            for (var i = 1; i <= n; i++)
            {
                resultCalculated *= i;
            }
            // Act
            var result = (int)Lesson4.Tasks.FactorialRecursion(n);
            // Assert
            Assert.Equal(resultExpected,result);
            Assert.Equal(resultExpected, resultCalculated);
        }
        [Fact(DisplayName = "Урок 4. Задание 1. Факториал рекурсивно. Факториал отрицательного числа, возвращяем null.")]
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