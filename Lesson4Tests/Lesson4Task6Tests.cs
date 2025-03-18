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
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(6, false)]
        [InlineData(12, false)]
        [InlineData(14, false)]
        [InlineData(1024, true)]
        [InlineData(1025, false)]
        [InlineData(-1024, false)]
        [InlineData(-1025, false)]
        public void IsPowerOfTwo_SomeData_Result(int value, bool resultExpected)
        {
            // Arrange
            bool resultCalculated = false;
            int currentValue = value;
            while (currentValue > 1 && currentValue % 2 == 0)
                currentValue /= 2;
            if (currentValue == 1)
                resultCalculated = true;
            // Act
            var result = Lesson4.Tasks.IsPowerOfTwo(value);
            // Assert
            Assert.Equal(resultExpected, result);
            Assert.Equal(resultExpected, resultCalculated);
        }

    }
}
