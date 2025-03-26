namespace Lesson7
{
    public static partial class Lesson7
    {
        /// <summary>
        /// Урок 7. Задание 4. Максимальное значение из переменного числа параметров
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMax(params int[] nums) =>
            Lesson5.Lesson5.FoldArrayValue(nums, nums[0], (element, acc) => element > acc ? element : acc);
    }
}
