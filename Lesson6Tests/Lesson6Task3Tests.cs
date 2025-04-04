namespace Lesson6
{
    public class Lesson6Task3Tests
    {
        [Fact(DisplayName = "Урок 6. Задача 3. Вывести отчет.")]
        public void Task3Report_AnyData_Result()
        {
            // Arrange
            var date = new DateTime(2006, 12, 05);
            decimal totalSells = 15165165.259999m;
            uint countGoodsSells = 16;
            string resultExpected = "------------------------------------------------------------\nОтчет о продажах за декабрь 2006\n------------------------------------------------------------\nОбщая сумма продаж: 15 165 165,26 руб \nКоличество проданных товаров: 16 шт \nСредняя стоимость товаров - 947 822.83 руб/шт \n------------------------------------------------------------";
            // Act
            var result = Lesson6.Task3Report(date, totalSells, countGoodsSells);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}

