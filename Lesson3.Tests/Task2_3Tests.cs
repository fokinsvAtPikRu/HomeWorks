using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Task2_3Tests
    {
        [Fact]
        public void InfinityLazyList_ThreeValues_Max5Mediana3()
        {
            // Arrange
            InfinityLazyList list = new InfinityLazyList(1);
            list.AddItem(3);
            list.AddItem(5);
            var maxExpected = 5;
            var medianaExpected = (1.0 + 3.0 + 5.0) / 3.0;
            // Act
            int max = list.Max();
            double mediana = list.Mediana();
            // Assert
            Assert.Equal(maxExpected, max);
            Assert.Equal(medianaExpected, mediana);
        }
        [Fact]
        public void InfinityLazyList_FourValues_Max10Mediana4()
        {
            // Arrange
            InfinityLazyList list = new InfinityLazyList(10);
            list.AddItem(2);
            list.AddItem(2);
            list.AddItem(2);
            var maxExpected = 10;
            var medianaExpected = (10.0 + 2.0 * 3.0) / 4.0;
            // Act
            int max = list.Max();
            double mediana = list.Mediana();
            // Assert
            Assert.Equal(maxExpected, max);
            Assert.Equal(medianaExpected, mediana);
        }
        [Fact]
        public void InfinityLazyList_TwentyValues_Max152MedianaCalculated()
        {
            // Arrange
            int[] data = {10,20,40,1,7,6,8,152,-4,12,
                          34,42,61,19,-159,2,64,13,1,2};
            var summa = data[0];
            InfinityLazyList list = new InfinityLazyList(data[0]);
            for (var i = 1; i < data.Length; i++)
            {
                list.AddItem(data[i]);
                summa += data[i];
            }           
            var maxExpected = 152;
            var medianaExpected = (double)summa / data.Length;
            // Act
            int max = list.Max();
            double mediana = list.Mediana();
            // Assert
            Assert.Equal(maxExpected, max);
            Assert.Equal(medianaExpected, mediana);
        }
    }

    }
