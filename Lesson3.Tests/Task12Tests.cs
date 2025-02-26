using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Task12Tests
    {
        [Theory(DisplayName ="Урок 3. Задание 12. Вывести строковое представление число от 100 до 999.")]        
        [InlineData(212, "двести двенадцать")]
        [InlineData(341, "триста сорок один")]
        [InlineData(579, "пятьсот семдесят девять")]
        [InlineData(2457, "Ошибка! Число вне диапазона 100-999.")]      
        [InlineData(5, "Ошибка! Число вне диапазона 100-999.")]      

        public static void SayNumber_SomeInt_ResultString(int value, string resultExpected)
        {
            // Arrange
            
            // Act
            var result = Lesson3.Lesson3Tasks.SayNumber(value);
            // Assert
            Assert.Equal(resultExpected,result);
        }
    }
}
