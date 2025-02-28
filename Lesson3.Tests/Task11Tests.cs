using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Tests
{
    public class Task11Tests
    {
        [Theory(DisplayName = "Урок 3. Задание 11. Достаточно ли места для двух домов.")]
        [InlineData(1, 1, 1, 1, 5, 5, true)]
        [InlineData(1, 2, 5, 3, 5, 4, true)]
        [InlineData(1, 1, 1, 1, 0, 0, false)]
        [InlineData(7, 1, 15, 12, 10, 10, false)]
        [InlineData(-1, -1, -1, -1, 0, 0, true)]
        public static void IsEnoughPlace_SomeValues_ResultBool
            (int p, int q, int r, int s, int a, int b, bool resultExpected)
        {
            // Arrange
            var house1 = (p, q);
            var house2 = (r, s);
            var area = (a, b);
            // Act
            var result = Lesson3.Lesson3Tasks.IsEnoughPlace(house1, house2, area);
            // Assert
            if (resultExpected)
                Assert.True(result);
            else
                Assert.False(result);
        }

    }
}
