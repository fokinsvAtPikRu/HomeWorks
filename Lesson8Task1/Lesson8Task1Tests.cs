using Xunit;

namespace Lesson8
{
    public class Lesson8Task1Tests
    {
        [Theory(DisplayName = "Урок 8. Задача 1. Калькулятор.")]
        [InlineData(1.0, 2.0, Operation.Add, 3.0)]
        [InlineData(5.0, 2.0, Operation.Subtract, 3.0)]
        [InlineData(5.0, 2.0, Operation.Multiply, 10.0)]
        [InlineData(5.0, 2.0, Operation.Divide, 2.5)]       
        public void CalculateTest_OperationValideData_Result(double op1, double op2, Operation action, double resultExpected)
        {
            // Arrange
            
            // Act
            var result = Lesson8.Lesson8Task1.Calculate(op1, op2, action);
            // Assert
            Assert.Equal(resultExpected, result, 5);
        }
        [Fact]
        public void CalculateTest_DivideByZero_Exception()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<DivideByZeroException>(() => Lesson8.Lesson8Task1.Calculate(1.0, 0, Operation.Divide));
        }
    }
}