namespace Lesson5
{
    public class Lesson5Task1Tests
    {
        [Theory(DisplayName = "Урок 5. Задание 1. Каких чисел больше - четных или нечетных. Четных больше.")]
        [InlineData(new int[] { 0 }, EvenAndOddElements.EvenIsMore)]
        [InlineData(new int[] { 0, 1, 2 }, EvenAndOddElements.EvenIsMore)]
        [InlineData(new int[] { 0, 1, 2, 3, 4, 6, 8, 10 }, EvenAndOddElements.EvenIsMore)]

        public static void IsNumberOfEvenElementsGreater_MoreEven_EnumEvenIsMore(int[] array, EvenAndOddElements resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson5.IsNumberOfEvenElementsGreater(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
        [Theory(DisplayName = "Урок 5. Задание 1. Каких чисел больше - четных или нечетных. Нечетных больше")]
        [InlineData(new int[] { 1 }, EvenAndOddElements.OddIsMore)]
        [InlineData(new int[] { 1, 1, 3, 5, 4, 2 }, EvenAndOddElements.OddIsMore)]
        [InlineData(new int[] { 3, 1, 1, 15, 4, 6, 8, 10 }, EvenAndOddElements.OddIsMore)]
        [InlineData(new int[] { 3, 1, 1, 15, 4, 6, 8, 11 }, EvenAndOddElements.OddIsMore)]
        [InlineData(new int[] { 3, 1, 1, 15, 4, 6, 7, 10 }, EvenAndOddElements.OddIsMore)]

        public static void IsNumberOfEvenElementsGreater_MoreOdd_EnumOddIsMore(int[] array, EvenAndOddElements resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson5.IsNumberOfEvenElementsGreater(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
        [Theory(DisplayName = "Урок 5. Задание 1. Каких чисел больше - четных или нечетных. Нечетных больше")]
        [InlineData(new int[] { 1,2 }, EvenAndOddElements.Equal)]
        [InlineData(new int[] { 1, 1, 3, 4, 8, 10 }, EvenAndOddElements.Equal)]
        [InlineData(new int[] {  }, EvenAndOddElements.Equal)]
        [InlineData(new int[] { 3, 1, 16,42 }, EvenAndOddElements.Equal)]
        [InlineData(new int[] { 17, 19, 11, 33, 44, 66, 72, 100 }, EvenAndOddElements.Equal)]

        public static void IsNumberOfEvenElementsGreater_Equal_EnumEqual(int[] array, EvenAndOddElements resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson5.IsNumberOfEvenElementsGreater(array);
            // Assert
            Assert.Equal(resultExpected, result);
        }
    }
}

