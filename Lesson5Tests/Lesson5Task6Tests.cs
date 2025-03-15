using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{    
    public class Lesson5Task
    {
        [Fact]
        public static void ChessDeskArray_2and2_Array()
        {
            // Arrange
            var resultExpected=new bool[,] { { true, false }, { false, true } };
            // Act
            var result = Lesson5.ChessDeskArray(2, 2);
            // Assert
            Assert.Equal(resultExpected, result);
        }
        [Fact]
        public static void ChessDeskArray_3and4_Array()
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
