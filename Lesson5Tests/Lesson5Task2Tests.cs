using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Lesson5Task2Tests
    {
        [Theory(DisplayName = "Урок 5. Задание 2. Количество положительных, отрицательных и нулевых элементов.")]
        [InlineData(new int[] { 0 }, 0, 0, 1)]
        [InlineData(new int[] { -1 }, 0, 1, 0)]
        [InlineData(new int[] { 1 }, 1, 0, 0)]
        [InlineData(new int[] { -1, 0, 1 }, 1, 1, 1)]
        [InlineData(new int[] { -2,-1, 0,0, 1,2 }, 2, 2, 2)]
        [InlineData(new int[] { -1,-1,-1, 0,0,0, 1,1,1 }, 3, 3, 3)]
        [InlineData(new int[] { -4,-3,-2,-1,0, 0,0,0, 1,2,3,4 }, 4, 4, 4)]
        public static void CountPositiveNegativeZeroElements_SomeData_Result(int[] array,
            int positiveExpected, int negativeExpected, int zeroExpected)
        {
            // Arrange
            (int, int, int) resultExpected = (positiveExpected, negativeExpected, zeroExpected);
            // Act
            var result = Lesson5.CountPositiveNegativeZeroElements(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }

    }
}
