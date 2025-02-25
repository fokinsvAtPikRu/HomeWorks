using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Task10Tests
    {
        [Theory(DisplayName ="Урок 3. Задание 10. Мы построили дома.")]
        [InlineData(0, "домов")]
        [InlineData(11, "домов")]
        [InlineData(14, "домов")]
        [InlineData(15, "домов")]
        [InlineData(1, "дом")]
        [InlineData(10, "домов")]
        [InlineData(22, "дома")]
        [InlineData(34, "дома")]
        [InlineData(1287, "домов")]
        [InlineData(-15, "Мы все поломали")]
        
        public static void SayWeBuildSomeHouses_SomeValues_StringResult(int houses, string resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson3.Lesson3Tasks.SayWeBuildSomeHouses(houses);
            // Assert
            Assert.Equal(resultExpected, result);



        }
    }
}
