using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class Lesson7Task3Tests
    {
        [Theory(DisplayName = "Урок 7. Задача 3. Вывести массив в строку без реверса. Корректные данные.")]
        [InlineData(new int[] {  }, "")]
        [InlineData(new int[] { 1 }, "1 ")]
        [InlineData(new int[] { 1 ,2 }, "1 2 ")]
        [InlineData(new int[] { 3,4,5 }, "3 4 5 ")]
        public void Task3PrintNumbers_ValideDataNotReverse_Result(int[] numbers, string resultExpected)
        {
            // Arrange
            
            // Act
            var result = Lesson7.PrintNumbers(numbers);
            // Assert
            Assert.Equal(resultExpected, result);
        }
        [Theory(DisplayName = "Урок 7. Задача 3. Вывести массив в строку реверс. Корректные данные.")]
        [InlineData(new int[] { 1 }, "1 ")]
        [InlineData(new int[] { 1, 2 }, "2 1 ")]
        [InlineData(new int[] { 3, 4, 5 }, "5 4 3 ")]
        public void Task3PrintNumbers_ValideDataReverse_Result(int[] numbers, string resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson7.PrintNumbers(numbers,true);
            // Assert
            Assert.Equal(resultExpected, result);
        }
        [Fact]        
        public void Task3PrintNumbers_Null_Exception()
        {
            // Arrange
            int[] numbers=null;
            // Act

            // Assert
            Assert.Throws<ArgumentNullException>(() => Lesson7.PrintNumbers(numbers, true));
        }
    }
}
