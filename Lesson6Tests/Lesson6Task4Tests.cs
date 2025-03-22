using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Lesson6Task4Tests
    {
        [Theory(DisplayName = "Урок 6. Задача 4. Строка в формате ИмяВозрастГород.")]
        [InlineData("Мурчеслав",4,"Муром", "Имя: Мурчеслав, Возраст: 4, Город: Муром")]
        public void Task4Report_AnyData_Result(string name, int age, string city, string resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson6.Task4StringBuilder(name, age, city);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
