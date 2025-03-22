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
            int row = 2;
            int columns = 2;
            int[,] resultExpected = { { 1, 2 }, { 4, 3 } };

            // Act
            var result = new FilledArray(row, columns).GetArray();
            // Assert
            Assert.Equal(resultExpected, result);
        }

        [Fact(DisplayName = "Урок 5. Задание 9. Заполнить массив по спирали. Массив 3х3")]
        public static void FilledArray_3x3_ArrayInt()
        {
            // Arrange
            int row = 3;
            int columns = 3;
            int[,] resultExpected = { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } };

            // Act
            var result = new FilledArray(row, columns).GetArray();
            // Assert
            Assert.Equal(resultExpected, result);
        }
        [Fact(DisplayName = "Урок 5. Задание 9. Заполнить массив по спирали. Массив 3х4")]
        public static void FilledArray_3x4_ArrayInt()
        {
            // Arrange
            int row = 4;
            int columns = 3;
            int[,] resultExpected = { { 1, 2, 3 }, { 10, 11, 4 }, { 9, 12, 5 }, { 8, 7, 6 } };

            // Act
            var result = new FilledArray(row, columns).GetArray();
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
