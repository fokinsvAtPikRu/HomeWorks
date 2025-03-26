using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{    
    public class Lesson5Task6
    {
        [Fact(DisplayName = "Урок 5. Задание 6. Заполнение массива как шахматная доска. Массив 2х2")]
        public static void ChessDeskArray_2x2_Array()
        {
            // Arrange
            var resultExpected=new bool[,] { { true, false }, { false, true } };
            // Act
            var result = Lesson5.ChessDeskArray(2, 2);
            // Assert
            Assert.Equal(resultExpected, result);
        }
        [Fact(DisplayName = "Урок 5. Задание 6. Заполнение массива как шахматная доска. Массив 3х4")]
        public static void ChessDeskArray_3x4_Array()
        {
            // Arrange
            var resultExpected = new bool[,] { { true, false, true, false }, { false, true, false, true }, { true, false, true, false } };
            // Act
            var result = Lesson5.ChessDeskArray(3, 4);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
