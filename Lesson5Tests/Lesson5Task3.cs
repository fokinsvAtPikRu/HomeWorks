using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Lesson5Task3
    {
        public class Lesson5Task2Tests
        {
            [Theory(DisplayName = "Урок 5. Задание 3. Максимальный и минимальный элемент и их индексы.")]
            [InlineData(new int[] { 0 }, 0, 0, 0, 0)]
            [InlineData(new int[] { -1, 1 }, 1, 1, 0, -1)]
            [InlineData(new int[] { 0,1,2,3,4,999,6 }, 5, 999, 0, 0)]
            
            public static void MaxMinElement_SomeData_Result(int[] array,
                int maxElementIndex, int maxElementValue, int minElementIndex, int minElementValue)
            {
                // Arrange
                ((int, int), (int, int)) resultExpected = ((maxElementIndex, maxElementValue), (minElementIndex, minElementValue));
                // Act
                var result = Lesson5.MaxMinElement(array);
                // Assert
                Assert.Equal(resultExpected, result);
            }

        }
    }
}
