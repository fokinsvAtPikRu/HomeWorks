using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Lesson4Task7Tests
    {
        [Theory(DisplayName = "Урок 4. Задание 7. Сколько цифр в числе.")]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(25,2)]
        [InlineData(459,3)]
        [InlineData(1287,4)]
        [InlineData(-1,1)]
        [InlineData(-37,2)]
        [InlineData(-128,3)]
        [InlineData(-4579,4)]
        public void DigitInNumber_SomeData_Result(int value,int resultExpected)
        {
            // Arrange
            int resultCalculated = 0;
            int currentValue = value;
            while (currentValue != 0)
            {
                currentValue /= 10;
                resultCalculated++;
            }            
            // Act
            var result = Lesson4.Tasks.DigitInNumber(value);
            // Assert
            Assert.Equal(resultExpected, result);
            Assert.Equal(resultExpected, resultCalculated);

        }
    }
}
