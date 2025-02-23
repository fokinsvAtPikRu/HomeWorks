namespace Lesson3
{
    public class Task1Test
    {
        [Fact]
        public void SignOfTheCompraisonResult_SameValuesInt_RavensSign()
        {
            // Arrange
            int value0 = 5;
            int value1 = 5;
            // Act
            var result = Lesson3.Lesson3Task1.SignOfTheCompraisonResult(value0, value1);
            // Assert
            Assert.Equal('=', result);
        }

        [Fact]
        public void SignOfTheCompraisonResult_FirstValueLessSecondValue_SmallerSign()
        {
            // Arrange
            int value0 = 0;
            int value1 = 5;
            // Act
            var result = Lesson3.Lesson3Task1.SignOfTheCompraisonResult(value0, value1);
            // Assert
            Assert.Equal('<', result);
        }
        [Fact]
        public void SignOfTheCompraisonResult_FirstValueGreaterSecondValue_BiggerSign()
        {
            // Arrange
            int value0 = 5;
            int value1 = 0;
            // Act
            var result = Lesson3.Lesson3Task1.SignOfTheCompraisonResult(value0, value1);
            // Assert
            Assert.Equal('>', result);
        }        
    }
}
