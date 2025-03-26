using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Lesson5Task10Tests
    {
        [Fact(DisplayName ="Урок 5. Задача 10. Проверить, выиграли крестики. Поле 3х3. Проиграли")]
        public static void IsXWins_3x3_False()
        {
            // Arrange
            int row = 3;
            int columns = 3;
            bool[,] array = { 
                { true, true,false }, 
                { true, false, true }, 
                { false, true, true } };
            bool resultExpected = false;
            // Act
            var result = Lesson5.IsXWins(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
        [Fact(DisplayName = "Урок 5. Задача 10. Проверить, выиграли крестики. Поле 3х3. Выиграли строку")]
        public static void IsXWins_3x3_RowTrue()
        {
            // Arrange
            int row = 3;
            int columns = 3;
            bool[,] array = { 
                { false, true, false }, 
                { true, true, true }, 
                { false, true, false } };
            bool resultExpected = true;
            // Act
            var result = Lesson5.IsXWins(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
        [Fact(DisplayName = "Урок 5. Задача 10. Проверить, выиграли крестики. Поле 3х3. Выиграли столбец")]
        public static void IsXWins_3x3_ColumnTrue()
        {
            // Arrange            
            bool[,] array = { 
                { false, true, false }, 
                { true, true, true }, 
                { false, true, false } };
            bool resultExpected = true;
            // Act
            var result = Lesson5.IsXWins(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
        [Fact(DisplayName = "Урок 5. Задача 10. Проверить, выиграли крестики. Поле 3х3. Выиграли диагональ")]
        public static void IsXWins_3x3_DiagonalTrue()
        {
            // Arrange
            int row = 3;
            int columns = 3;
            bool[,] array = {
                { false, true, true },
                { false, true, false },
                { true, true, false } };
            bool resultExpected = true;
            // Act
            var result = Lesson5.IsXWins(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
