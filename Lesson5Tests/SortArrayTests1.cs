using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class SortArrayTests1
    {
        [Theory(DisplayName = "Сортировка массива.")]
        [InlineData(new int[] { 14, 11, 4, 7, 21 }, new int[] {21,14,11,7,4})]
        public static void SortArray_SomeData_Result(int[] array, int[] resultExpected)
    {
        // Arrange
        
        // Act
        var result = Lesson5.SortArray(array);
        // Assert
        Assert.Equal(resultExpected, result);
    }
}
}
