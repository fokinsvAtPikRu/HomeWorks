using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Tasks5_9Tests
    {
        // Task 5 tests
        #region
        [Theory(DisplayName = "Урок 3. Задание 5. Последняя цифра числа ноль.")]
        [InlineData(159, false)]
        [InlineData(80, true)]
        [InlineData(0, true)]
        [InlineData(-14, false)]
        [InlineData(-100, true)]

        public void EndsZero_SomeValue_ResultBool(int value, bool resultExpected)
        {
            // Arrange

            // Act
            var result = value.IsEndsZero();
            // Assert
            if (resultExpected)
                Assert.True(result);
            else
                Assert.False(result);
        }
        #endregion
        // Task 6 tests
        #region
        [Theory(DisplayName = "Урок 3. Задание 6. Четность числа.")]
        [InlineData(-99, false)]
        [InlineData(-48, true)]
        [InlineData(0, true)]
        [InlineData(17, false)]
        [InlineData(42, true)]
        public void IsEven_SomeValues_ResultBool(int value, bool resultExpected)
        {
            // Arrange

            // Act
            var result = value.IsEven();
            // Assert
            if (resultExpected)
                Assert.True(result);
            else
                Assert.False(result);

        }
        #endregion
        // Task 7 tests
        #region
        [Theory(DisplayName = "Урок 3. Задание 7. Является ли число двузначным.")]
        [InlineData(3, false)]
        [InlineData(31, true)]
        [InlineData(378, false)]
        [InlineData(-28, true)]
        public void IsTwoDigitNumber_SomeValues_BoolResult(int value, bool resultExpected)
        {
            // Arrange

            // Act
            var result = value.IsTwoDigitNumber();
            // Assert
            if (resultExpected)
                Assert.True(result);
            else
                Assert.False(result);
        }
        #endregion
        // Task 8 tests
        #region
        [Theory(DisplayName = "Урок 3. Задание 8. Значение находится в диапазоне [-10;+10].")]
        [InlineData(-30, false)]
        [InlineData(-10, true)]
        [InlineData(-5, true)]
        [InlineData(10, true)]
        [InlineData(54, false)]
        public void IsInRangeMinusTenPlusTen_minus20_false(int value, bool resultExpected)
        {
            // Arrange

            // Act
            var result = value.IsInRangeMinusTenPlusTen();
            // Assert
            if (resultExpected)
                Assert.True(result);
            else
                Assert.False(result);
        }
        #endregion
        // Task 9 tests
        #region
        [Theory(DisplayName = "Урок 3. Задание 9. Значение не находится в диапазоне (-10,+10).")]
        [InlineData(-25, true)]
        [InlineData(-10, true)]
        [InlineData(5, false)]
        [InlineData(10, true)]
        [InlineData(25, true)]
        public void NotIsInRangeMinusTenPlusTen_minus42_true(int value, bool resultExpected)
        {
            // Arrange

            // Act
            var result = value.NotIsInRangeMinusTenPlusTen();
            // Assert
            if (resultExpected)
                Assert.True(result);
            else 
                Assert.False(result);
        }        
        #endregion
    }
}
