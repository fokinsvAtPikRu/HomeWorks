using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Tests
{
    public class Lesson4Task2Tests
    {
        [Theory(DisplayName = "Урок 4. Задание 2. Сумма гармонического ряда рекурсивно.")]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void HarmonicSeriesRecursion_SomeData_Result(int n)
        {
            // Arrange
            double resultExpected = 0;
            for (int i = 1; i <= n; i++)
            {
                resultExpected += 1 / i;
            }
            // Act
            var result = Lesson4.Tasks.HarmonicSeriesRecursion(n);
            // Assert
            Assert.Equal(resultExpected, result);

        }
        [Fact]
        public void HarmonicSeriesRecursion_NegativeInt_Null()
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
