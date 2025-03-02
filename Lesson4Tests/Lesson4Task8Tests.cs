using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Lesson4Task8Tests
    {
        [Theory(DisplayName = "Урок 4. Задание 6. Является ли число степенью двойки.")]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(40, 4)]
        [InlineData(78, 87)]
        [InlineData(12345678, 87654321)]
        public void IsPowerOfTwo_SomeData_Result(int value, int resultExpected)
        {
            // Arrange
            
            // Act
            var result = Lesson4.Tasks.ReverseDigit(value);
            // Assert
            Assert.Equal(resultExpected, result);

        }
    }
}
