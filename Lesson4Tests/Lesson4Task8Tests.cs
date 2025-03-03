using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson4
{
    public class Lesson4Task8Tests
    {
        [Theory(DisplayName = "Урок 4. Задание 8. Вернуть число в зеркальном виде.")]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(40, 4)]
        [InlineData(78, 87)]
        [InlineData(12345678, 87654321)]
        public void ReverseDigit_SomeData_Result(int value, int resultExpected)
        {
            // Arrange
            int digit = value;
            int resultCalculated = 0;
            while (digit > 0)
            {
                resultCalculated = resultCalculated * 10 + digit % 10;
                digit /= 10;
            }
            // Act
            var result = Lesson4.Tasks.ReverseDigit(value);
            // Assert
            Assert.Equal(resultExpected, result);
            // Assert.Equal(resultExpected, resultCalculated);
        }
    }
}
