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
        [InlineData(1, 0)]
        [InlineData(10, -2)]
        [InlineData(2, -4)]
        public void NegativePowerRecursion_SomeData_Result(int value, int power)
        {
            // Arrange
            double resultExpected = 1;
            for (var i = -1; i >= power; i--)
            {
                resultExpected /= value;
            }
            // Act
            var result = Lesson4.Tasks.NegativePowerRecursion(value, power);
            // Assert
            Assert.Equal(resultExpected, result);

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
