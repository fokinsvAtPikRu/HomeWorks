using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Lesson5Task9Tests
    {
        [Fact(DisplayName = "Урок 5. Задание 9. Заполнить массив по спирали.")]
        public static void FillSpiral_RawAndColumns_ArrayInt()
        {
            // Arrange
            int raw = 5;
            int columns = 4;
            var resultExpected = new int[,] { 111, 222, 333 };
            // Act
            var result = Lesson5.MaxInRaw(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
