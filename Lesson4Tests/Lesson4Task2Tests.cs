using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Lesson4Task2Tests
    {
        [Theory(DisplayName = "Урок 4. Задание 2. Сумма гармонического ряда рекурсивно. Корректные исходные данные.")]
        [InlineData(1, 1)]
        [InlineData(5, 2.283333333)]
        [InlineData(10, 2.928968254)]
        [InlineData(40, 4.278543039)]
        public void HarmonicSeriesRecursion_SomeData_Result(int n, double resultExpected)
        {
            // Arrange
            double resultCalculated = 0;
            for (var i = 1; i <= n; i++)
            {
                resultCalculated += 1 / (double)i;
            }
            // Act
            var result = (double)Lesson4.Tasks.HarmonicSeriesRecursion(n);
            // Assert
            Assert.Equal(resultCalculated, result, 9);
            Assert.Equal(resultExpected, result, 9);
        }
        [Fact(DisplayName = "Урок 4. Задание 2. Сумма гармонического ряда рекурсивно. Отрицательное число или 0 возвращаем null.")]
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
        [Fact(DisplayName = "Урок 4. Задание 2. Сумма гармонического ряда рекурсивно. Ноль возвращаем null.")]
        public void HarmonicSeriesRecursion_ZeroInt_Null()
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
