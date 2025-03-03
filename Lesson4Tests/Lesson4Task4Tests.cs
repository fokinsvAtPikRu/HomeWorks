using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Lesson4Task4Tests
    {
        [Theory(DisplayName = "Урок 4. Задание 4. Возведение в отрицательную степень. Корректные данные.")]
        [InlineData(1, 0, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(10, -2, 0.01)]
        [InlineData(2, -4, 0.0625)]
        public void NegativePowerRecursion_SomeData_Result(int value, int power, double resultExpected)
        {
            // Arrange
            double resultCalculated = 1;
            for (var i = -1; i >= power; i--)
            {
                resultCalculated /= value;
            }
            // Act
            var result = Lesson4.Tasks.NegativePowerRecursion(value, power);
            // Assert
            Assert.Equal(resultExpected, result);
            Assert.Equal(resultExpected, resultCalculated);

        }
        [Fact(DisplayName = "Урок 4. Задание 4. Возведение в отрицательную степень. Положительная степень, возвращаем null.")]
        public void NegativePowerRecursion_NegativeInt_Null()
        {
            // Arrange
            int value = 1;
            int power = 1;
            int? resultExpected = null;
            // Act
            var result = Lesson4.Tasks.NegativePowerRecursion(value, power);
            // Assert
            Assert.Equal(resultExpected, result);

        }
    }
}
