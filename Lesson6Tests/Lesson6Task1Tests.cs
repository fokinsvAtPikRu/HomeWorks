namespace Lesson6
{
    public class Lesson6Task1Tests
    {
        [Theory(DisplayName ="Урок 6. Задача 1. Найти самое длинное слово.")]
        [InlineData("As gsrep fawpokf sdfk df", "fawpokf")]
        [InlineData("Сталин бывал в Можайске один раз, когда в 1945 году ехал поездом на Потсдамскую конференцию, где союзники делили мир.", "Потсдамскую")]
        public void Task1LongestWord_AnyData_Result(string phrase, string resultExpected)
        {
            // Arrange
            
            // Act
            var result = Lesson6.Task1LongestWord(phrase);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
    
}
