using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Lesson5Task7Tests
    {
        [Fact(DisplayName = "Урок 5. Задание 7. Максимальное значение в строке.")]
        public static void MaxInRaw_SomeData_ArrayMaxValue()
        {
            // Arrange
            var array = new int[,] { { 1, 2, 111 }, { 222, 2, 1 }, { 333, 5, 1 } };
            var resultExpected = new int[] { 111, 222, 333 };
            // Act
            var result = Lesson5.MaxInRaw(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
