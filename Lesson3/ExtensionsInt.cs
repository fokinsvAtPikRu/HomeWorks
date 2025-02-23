using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public static class ExtensionsInt
    {
        public static bool EndsZero(this int value) => value % 10 == 0;
        public static bool IsEven(this int value) => value % 2 == 0;

    }
}
