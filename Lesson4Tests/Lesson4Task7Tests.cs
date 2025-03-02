using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Lesson4Task7Tests
    {
        [Theory(DisplayName = "Урок 4. Задание 6. Является ли число степенью двойки.")]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(25)]
        [InlineData(459)]
        [InlineData(1287)]
        [InlineData(-1)]
        [InlineData(-37)]
        [InlineData(-128)]
        [InlineData(-4579)]
        public void DigitInNumber_SomeData_Result(int value)
        {
            // Arrange
            int resultExpected = 0;
            int currentValue = value;
            while (currentValue != 0)
            {
                currentValue /= 10;
                resultExpected++;
            }            
            // Act
            var result = Lesson4.Tasks.DigitInNumber(value);
            // Assert
            Assert.Equal(resultExpected, result);

        }
    }
}
