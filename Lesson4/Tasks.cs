namespace Lesson4
{
    public static class Tasks
    {
        /// <summary>
        /// Task 1. Factorial recursion
        /// </summary>
        /// <returns></returns>
        // как правильнее сделать вернуть null или выкинуть исключение?
        public static int? FactorialRecursion(int n)
        {
            if (n < 0) return null;
            if (n == 0) return 1;
            else            
                return n * FactorialRecursion(--n);            
        }
        /// <summary>
        /// Task 2. The sum of the Harmonic Series.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double? HarmonicSeriesRecursion(int n)
        {
            if (n < 1) return null;
            if (n == 1) return 1;
            else
                return 1 / (double)n + HarmonicSeriesRecursion(--n);
        }
        /// <summary>
        /// Task 3. Raising to a positive power.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        public static int? PositivePowerRecursion(int value, int power)
        {
            if (power < 0) return null;
            if (power == 0) return 1;
            else
                return value * PositivePowerRecursion(value, --power);
        }
        /// <summary>
        /// Task 4. Raising to a negative power.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        public static double? NegativePowerRecursion(int value, int power)
        {
            if (power > 0) return null;
            if (power == 0) return 1;
            else
            {
                return NegativePowerRecursion(value, ++power) / value;
            }
        }
        /// <summary>
        /// Task 6. Is the number a power of 2.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPowerOfTwo(int value)
        {
            if (value == 1) return true;
            if (value == 0 || value % 2 == 1) return false;            
            return IsPowerOfTwo(value / 2);
        }
        /// <summary>
        /// Task 7. How many digits are in a number.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int DigitInNumber(int value)
        {
            return DigitInNumberHelper(value, 0);
        }
        private static int DigitInNumberHelper(int value, int counter)
        {
            if (value == 0)
                return counter;
            else
                return DigitInNumberHelper(value / 10, ++counter);
        }
        /// <summary>
        /// Task 8. Reverse digit.
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        public static int ReverseDigit(int digit)
        {
            return ReverseDigitHelper(digit, 0);
        }
        private static int ReverseDigitHelper(int digit, int digitReverse)
        {
            if (digit == 0)
                return digitReverse;
            else
                return ReverseDigitHelper(digit / 10, digitReverse * 10 + digit % 10);
        }
    }
}
