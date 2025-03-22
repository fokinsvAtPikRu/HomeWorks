using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Lesson5Task4Tests
    {
        [Theory(DisplayName = "Урок 5. Задание 4. Перевернуть массив.")]
        [InlineData(new int[] { 0 }, new int[] {0})]
        [InlineData(new int[] { 0,1 }, new int[] {1,0})]
        [InlineData(new int[] { 0,1,2 }, new int[] {2,1,0})]
        
        public static void ReverseArray_SomeData_Result(int[] array, int[] resultExpected)
        {
            // Arrange
            
            // Act
            var result = Lesson5.ReverseArray(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
