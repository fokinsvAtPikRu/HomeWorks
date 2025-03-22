using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Lesson6Task6Tests
    {
        [Theory(DisplayName = "Урок 6. Задача 6. Regex проверка валидности пароля.")]
        [InlineData("3!UdF08i65Y7c4", true)]
        [InlineData("de#bT9qoFnYM3b", true)]
        [InlineData("YDC;azM904GBjq", true)]
        [InlineData("jb3C%bxFC7Hls1", true)]
        [InlineData("Sa3Ab:X12UyYGo", true)]
        [InlineData("rDuj4Q?F1vOMQk", true)]
        [InlineData("lEBTbA5*uVmDk5", true)]
        [InlineData("uvc8f8#r8vq8fs", false)] // не содержит заглавные
        [InlineData("8INJGEG#!;QMEI", false)] // не содержит строчные
        [InlineData("dnrZzxSqWfpc!D", false)] // не содержит цифры
        [InlineData("zhOb55KYWiVmwm", false)] // не содержит спецсимволы
        
        

        public void Task6Report_AnyData_Result(string password, bool resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson6.Task6IsValidPassword(password);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}






