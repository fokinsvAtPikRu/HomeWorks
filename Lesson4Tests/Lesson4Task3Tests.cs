using System;
namespace Lesson4
{
    public class Lesson4Task3Tests
    {
        [Theory(DisplayName = "Урок 4. Задание 3. Возведение в положительную степень. Корректные данные.")]
        [InlineData(0,0,1)]
        [InlineData(1,1,1)]
        [InlineData(0,1,0)]
        [InlineData(2,2,4)]
        [InlineData(2,10,1024)]
        public void PositivePowerRecursion_SomeData_Result(int value, int power, int resultExpected)
        {
            // Arrange
            int resultCalculated = 1;
            for (var i = 1; i <= power; i++)
            {
                resultCalculated *= value;
            }
            // Act
            var result = Lesson4.Tasks.PositivePowerRecursion(value,power);
            // Assert
            Assert.Equal(resultExpected, result);
            Assert.Equal(resultExpected, resultCalculated);

        }
        [Fact(DisplayName = "Урок 4. Задание 3. Возведение в положительную степень. Отрицательная степень, возвращаем null.")]
        public void PositivePowerRecursion_NegativeInt_Null()
        {
            // Arrange
            int value = 1;
            int power = -1;
            int? resultExpected = null;
            // Act
            var result = Lesson4.Tasks.PositivePowerRecursion(value,power);
            // Assert
            Assert.Equal(resultExpected, result);

        }

    }
}
