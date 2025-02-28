using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    /// <summary>
    /// Task 2, 3, 4 Summa and Mediana for lazy infinity list 
    /// </summary>
    public class InfinityLazyList
    {
        private int count;
        private int max;
        private int summa;
        public InfinityLazyList(int value)
        {
            max = value;
            summa = value;
            count = 1;
        }
        public void AddItem(int value)
        {
            max=max>value?max:value;
            count++;
            summa += value;
        }
        public int Max() => max;
        public double Mediana() => (double)summa/(double)count;
    }
}
