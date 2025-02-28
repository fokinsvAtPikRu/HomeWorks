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
        public static int FactorialRecursion(int n)
        {
            int factorial;
            if (n == 1) return 1;
            else
            {
                factorial=n*FactorialRecursion(--n);
            }
            return 0;
        }
    }
}
