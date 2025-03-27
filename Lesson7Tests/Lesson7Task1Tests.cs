namespace Lesson7
{
    public class Lesson7Task1Tests
    {
        [Theory(DisplayName = "Урок 7. Задача 1. Площадь треугольника.")]
        [InlineData(1, 1, 1, 0.433013)]
        [InlineData(3, 4, 5, 6.0)]

        public void Task1SquareOfTriangle_ValideData_Result(double a, double b, double c, double resultExpected)
        {
            // Arrange

            // Act
            var result = Lesson7.Square(a, b, c);
            // Assert
            Assert.Equal(resultExpected, result, 5);
        }
        [Theory(DisplayName = "Урок 7. Задача 1. Площадь треугольника.")]
        [InlineData(0, 1, 1)]
        [InlineData(3, -4, 5)]
        [InlineData(3, -4, -7)]
        public void Task1SquareOfTriangle_WrongData_Exeption(double a, double b, double c)
        {
            // Arrange
            
            // Act
            
            // Assert
            Assert.Throws<ArgumentException>(()=> Lesson7.Square(a, b, c));            
        }
    }
}