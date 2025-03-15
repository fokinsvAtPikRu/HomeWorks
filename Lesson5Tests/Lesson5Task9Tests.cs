using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson5
{
    public class Lesson5Task9Tests
    {
        [Fact(DisplayName = "Урок 5. Задание 9. Заполнить массив по спирали. Массив 2х2")]
        public static void FilledArray_2x2_ArrayInt()
        {
            // Arrange
            int raw = 2;
            int columns = 2;
            int[,] resultExpected = { { 0, 1 }, { 3, 2 } };

            // Act
            var result = new FilledArray(raw, columns).GetArray();
            // Assert
            Assert.Equal(resultExpected, result);
        }

        [Fact(DisplayName = "Урок 5. Задание 9. Заполнить массив по спирали. Массив 3х3")]
        public static void FilledArray_RawAndColumns_ArrayInt()
        {
            // Arrange
            int raw = 3;
            int columns = 3;
            int[,] resultExpected = { { 0, 1, 2 }, { 7, 8, 3 }, { 6, 5, 4 } };

            // Act
            var result = new FilledArray(raw, columns).GetArray();
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
