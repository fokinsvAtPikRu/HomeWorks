namespace Lesson7
{
    public static partial class Lesson7
    {
        /// <summary>
        /// Урок 7. Задание 1. Вычисление площади треугольника.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
