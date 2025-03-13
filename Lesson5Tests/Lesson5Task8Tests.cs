using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Lesson5Task8Tests
    {
        [Theory(DisplayName = "Урок 5. Задание 8. Два наибольших числа в массиве.")]
        [InlineData(new int[] { 18 }, 18, 18)]
        [InlineData(new int[] { -1, 25, 34 }, 34, 25)]
        [InlineData(new int[] { 1, 9,9,3 }, 9, 9)]
        
        public static void TwoGreatestValue_SomeData_Result(int[] array,
            int max1, int max2)
        {
            // Arrange
            var resultExpected = (max1,max2);
            // Act
            var result = Lesson5.TwoGreatestValue(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
