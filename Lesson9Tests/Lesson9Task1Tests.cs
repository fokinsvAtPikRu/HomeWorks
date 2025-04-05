namespace Lesson9
{
    public class Lesson9Task1Tests
    {
        [Theory(DisplayName = "���� 9. ������ 1. ����� Book.")]
        [InlineData("����� � ���", "�. �������", 1869, 1225, "����� � ���, �. �������, 1869, 1225 ���.")]

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