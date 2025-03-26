using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Lesson5Task5Tests
    {
        [Theory(DisplayName = "Урок 5. Задание 5. Половину массива упорядочить по возрастанию, половину по убыванию.")]
        [InlineData(new int[] { 4, 3, 2, 1, 0, 0, 1, 2, 3, 4 }, new int[] { 0, 1, 2, 3, 4, 4, 3, 2, 1, 0 })]


        public static void SortAscendingDescending_SomeData_Result(int[] array, int[] resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson5.SortAscendingDescending(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
