using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Task2Test
    {
        [Fact]
        public void SignOfTheCompraisonResult_SameValuesInt_RavensSign()
        {
            // Arrange
            int value0 = 5;
            int value1 = 5;
            // Act
            var result = Lesson3.Lesson3Methods.SignOfTheCompraisonResult(value0, value1);
            // Assert
            Assert.Equal('=', result);
        }
    }

}
