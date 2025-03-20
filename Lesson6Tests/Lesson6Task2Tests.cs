using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Lesson6Task2Tests
    {
        [Theory(DisplayName = "Урок 6. Задача 2. Является ли фраза палиндромом.")]
        [InlineData("А роза упала на лапу Азора", true)]
        [InlineData("Сталин бывал в Можайске один раз, когда в 1945 году ехал поездом на Потсдамскую конференцию, где союзники делили мир.", false)]
        public void Task2IsPalindrom_AnyData_Result(string phrase, bool resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson6.Task2IsPalindrom(phrase);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
