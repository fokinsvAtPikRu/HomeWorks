using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Lesson8Task2Tests
    {
        [Fact]
        public void ValidateAge_NegativeValue_ArgumentException()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => Lesson8.Lesson8Task2.ValidateAge(-3));
        }
        [Fact]
        public void ValidateAge_BigValue_ArgumentOutOfRangeException()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Lesson8.Lesson8Task2.ValidateAge(500));
        }
    }
}
