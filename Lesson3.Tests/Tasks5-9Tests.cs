using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Tests
{
    public class Tasks5_9Tests
    {
        // Task 5 tests
        #region
        [Fact]        
        public void EndsZero_159_false()
        {
            // Arrange
            int value = 159;            
            // Act
            var result = value.EndsZero();
            // Assert
            Assert.False(result);
        }
        [Fact]
        public void EndsZero_80_true()
        {
            // Arrange
            int value = 80;
            // Act
            var result = value.EndsZero();
            // Assert
            Assert.True(result);
        }
        #endregion
        // Task 6 tests
        #region
        [Fact]
        public void IsEven_341_false()
        {
            // Arrange
            int value = 341;
            // Act
            var result = value.IsEven();
            // Assert
            Assert.False(result);
        }
        [Fact]
        public void IsEven_42_true()
        {
            // Arrange
            int value = 42;
            // Act
            var result = value.IsEven();
            // Assert
            Assert.True(result);
        }
        #endregion
        // Task 7 tests
        #region
        [Fact]
        public void IsTwoDigitNumber_3_false()
        {
            // Arrange
            int value = 3;
            // Act
            var result = value.IsTwoDigitNumber();
            // Assert
            Assert.False(result);
        }
        [Fact]
        public void IsTwoDigitNumber_42_true()
        {
            // Arrange
            int value = 42;
            // Act
            var result = value.IsTwoDigitNumber();
            // Assert
            Assert.True(result);
        }
        [Fact]
        public void IsTwoDigitNumber_345_false()
        {
            // Arrange
            int value = 345;
            // Act
            var result = value.IsTwoDigitNumber();
            // Assert
            Assert.False(result);
        }
        #endregion
        // Task 8 tests
        #region
        [Fact]
        public void IsInRangeMinusTenPlusTen_minus20_false()
        {
            // Arrange
            int value = -20;
            // Act
            var result=value.IsInRangeMinusTenPlusTen();
            // Assert
            Assert.False(result);        
        }
        [Fact]
        public void IsInRangeMinusTenPlusTen_minus10_true()
        {
            // Arrange
            int value = -10;
            // Act
            var result = value.IsInRangeMinusTenPlusTen();
            // Assert
            Assert.True(result);
        }
        [Fact]       
        public void IsInRangeMinusTenPlusTen_0_true()
        {
            // Arrange
            int value = 0;
            // Act
            var result = value.IsInRangeMinusTenPlusTen();
            // Assert
            Assert.True(result);
        }
        [Fact]
        public void IsInRangeMinusTenPlusTen_10_true()
        {
            // Arrange
            int value = 10;
            // Act
            var result = value.IsInRangeMinusTenPlusTen();
            // Assert
            Assert.True(result);
        }
        [Fact]
        public void IsInRangeMinusTenPlusTen_42_false()
        {
            // Arrange
            int value = 42;
            // Act
            var result = value.IsInRangeMinusTenPlusTen();
            // Assert
            Assert.False(result);
        }
        #endregion
        // Task 9 tests
        #region
        [Fact]
        public void NotIsInRangeMinusTenPlusTen_minus42_true()
        {
            // Arrange
            int value = -42;
            // Act
            var result = value.NotIsInRangeMinusTenPlusTen();
            // Assert
            Assert.True(result);
        }
        [Fact]
        public void NotIsInRangeMinusTenPlusTen_minus10_true()
        {
            // Arrange
            int value = -10;
            // Act
            var result = value.NotIsInRangeMinusTenPlusTen();
            // Assert
            Assert.True(result);
        }
        [Fact]
        public void NotIsInRangeMinusTenPlusTen_2_false()
        {
            // Arrange
            int value = 2;
            // Act
            var result = value.NotIsInRangeMinusTenPlusTen();
            // Assert
            Assert.False(result);
        }
        [Fact]
        public void NotIsInRangeMinusTenPlusTen_10_true()
        {
            // Arrange
            int value = 10;
            // Act
            var result = value.NotIsInRangeMinusTenPlusTen();
            // Assert
            Assert.True(result);
        }
        [Fact]
        public void NotIsInRangeMinusTenPlusTen_22_false()
        {
            // Arrange
            int value = 22;
            // Act
            var result = value.NotIsInRangeMinusTenPlusTen();
            // Assert
            Assert.True(result);
        }
        #endregion
    }
}
