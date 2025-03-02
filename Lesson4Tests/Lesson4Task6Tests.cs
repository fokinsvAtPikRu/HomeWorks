using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Lesson4Task6Tests
    {
        [Theory(DisplayName = "Урок 4. Задание 6. Является ли число степенью двойки.")]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(128)]
        [InlineData(-1)]
        [InlineData(-4)]
        [InlineData(-128)]
        public void IsPowerOfTwo_SomeData_Result(int value)
        {
            // Arrange
            bool resultExpected = false;
            int currentValue = value;
            while (currentValue > 2)
                currentValue /= 2;
            if (currentValue == 0)
                resultExpected = true;
            // Act
            var result = Lesson4.Tasks.IsPowerOfTwo(value);
            // Assert
            Assert.Equal(resultExpected, result);

        }

    }
}
