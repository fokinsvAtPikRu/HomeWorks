using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Task2_3Tests
    {       
        [Theory]
        [InlineData(new[] {1,3,5},5)]
        [InlineData(new[] {10,2,2,2},10)]
        [InlineData(new[] {1,3,5,159,-14,68,438,0,15,42},438)]
        public void InfinityLazyList_SomeValues_MaxAndMedianaValues(int[] data,int maxExpected)
        {
            // Arrange            
            var summa = data[0];
            var count = 1;
            InfinityLazyList list = new InfinityLazyList(data[0]);
            if (data.Length > 1)
            {
                for (var i = 1; i < data.Length; i++)
                {
                    list.AddItem(data[i]);
                    summa += data[i];
                    count++;
                }
            }
            var medianaExpected = summa / count;
            // Act
            int max = list.Max();
            double mediana = list.Mediana();
            // Assert
            Assert.Equal(maxExpected, max);
            Assert.Equal(medianaExpected, mediana);
        }
    }

    }
