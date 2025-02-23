namespace Lesson3
{
    public class Task1Test
    {
        [Theory(DisplayName ="Урок 3. Задание 1. Вернуть символ результата сравнения.")]
        [InlineData(5,5,'=')]
        [InlineData(0,5,'<')]
        [InlineData(5,0,'>')]
        public void SignOfTheCompraisonResult_SameValues_CompareSign(
            int value0, int value1, char resultExpected)
        {
            // Arrange
            
            // Act
            var result = Lesson3.Lesson3Task1.SignOfTheCompraisonResult(value0, value1);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
