using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public static class ExtensionsInt
    {
        /// <summary>
        /// Task 5. The digit ends in zero.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEndsZero(this int value) => value % 10 == 0;
        /// <summary>
        /// Task 6. The digit is even.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEven(this int value) => value % 2 == 0;
        /// <summary>
        /// Task 7. The number is two-digit.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsTwoDigitNumber(this int value) => value / 100 == 0 && value / 10 != 0;
        /// <summary>
        /// Task 8. The number is in range [-10;+10]
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsInRangeMinusTenPlusTen(this int value) => -10 <= value && value <= 10;
        /// <summary>
        /// Task 9. The number is in range (minus infinity;-10] or [+10; plus infinity)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool NotIsInRangeMinusTenPlusTen(this int value) => value <= -10 || value >= 10;

    }
}
