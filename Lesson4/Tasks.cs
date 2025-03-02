using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public static class Tasks
    {
        /// <summary>
        /// Task 1. Factorial recursion
        /// </summary>
        /// <returns></returns>
        public static int? FactorialRecursion(int n)
        {
            if (n < 0) return null;
            int factorial;
            if (n == 0) return 1;
            else
            {
                return factorial=n*(int)FactorialRecursion(--n);
            }            
        }
        public static double? HarmonicSeriesRecursion(int n)
        {            
            if (n < 1) return null;
            double summa;
            if (n == 1) return 1;
            else
            {
                return summa=1/n+(double)HarmonicSeriesRecursion(--n);
            }
        }
    }
}
