namespace Lesson6
{
    public class Lesson6Task1
    {
        [Theory(DisplayName ="Урок 6. Задача 1. Найти самое длинное слово.")]
        [InlineData("As gsrep fawpokf sdfk df", "fawpokf")]
        [InlineData("Сталин бывал в Можайске один раз, когда в 1945 году ехал поездом на Потсдамскую конференцию, где союзники делили мир.", "Потсдамскую")]
        public void Test1(string phrase, string resultExpected)
        {
            // Arrange
            
            // Act
            var result = Lesson6.Task1LongestWord(phrase);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
    public class Lesson6Task2Tests
    {
        [Theory(DisplayName = "Урок 6. Задача 2. Является ли фраза палиндромом.")]
        [InlineData("А роза упала на лапу Азора", true)]
        [InlineData("Сталин бывал в Можайске один раз, когда в 1945 году ехал поездом на Потсдамскую конференцию, где союзники делили мир.", false)]
        public void Test1(string phrase, bool resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson6.Task2IsPalindrom(phrase);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}
