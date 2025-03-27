using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class Lesson7Task2Tests
    {
        [Theory(DisplayName = "Урок 7. Задача 2. Площадь и объем куба. Корректные данные.")]
        [InlineData(1, 6, 1)]
        [InlineData(3, 54, 27)]

        public void Task2CalcCub_ValideData_AreaResult(double edge, double areaResultExpected, double volumeResultExpected)
        {
            // Arrange
            double areaResult;
            double volumeResult;
            // Act
            Lesson7.CalcCube(edge, out volumeResult, out areaResult);
            // Assert
            Assert.Equal(areaResultExpected, areaResult);
            Assert.Equal(volumeResultExpected, volumeResult);
        }
        [Theory(DisplayName = "Урок 7. Задача 2. Площадь треугольника. Исключение.")]
        [InlineData(0)]
        [InlineData(-1.5)]
        public void Task1SquareOfTriangle_WrongData_Exeption(double edge)
        {
            // Arrange
            double areaResult;
            double volumeResult;
            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => Lesson7.CalcCube(edge, out volumeResult, out areaResult));
        }
    }
}
