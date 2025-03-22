using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Lesson6Task5Tests
    {
        [Theory(DisplayName = "Урок 6. Задача 5. Regex проверка телефонного номера.")]
        [InlineData("+7(123)456-78-89",true)]
        [InlineData("+7(1230)456-78-89",false)]
        [InlineData("+7 123)456-78-89",false)]
        [InlineData("+7(123) 456-78-89",false)]
        [InlineData("+7(123)46-78-89",false)]
        [InlineData("+7(123)456 78-89",false)]
        [InlineData("7+(123)456-7889",false)]
        [InlineData("7+(123)456-78-8",false)]
        
        public void Task5Report_AnyData_Result(string password, bool resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson6.Task5IsValidPhoneNumber(password);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
