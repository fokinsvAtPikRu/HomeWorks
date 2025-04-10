namespace Lesson9
{
    public class Lesson9Task1Tests
    {
        [Theory(DisplayName = "Урок 9. Задача 1. Класс Book.")]
        [InlineData("Война и мир", "Л. Толстой", 1869, 1225, "Война и мир, Л. Толстой, 1869, 1225 стр.")]

        public void ClassBookTest_Data_Result(string title, string author, int year, int pages, string resultExpected)
        {
            // Arrange
            var book = new Lesson9.Book(title, author, year, pages);
            // Act
            var result = book.GetInfo();
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}