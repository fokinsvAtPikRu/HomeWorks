using System.Numerics;
namespace Lesson7
{
    public static partial class Lesson7
    {
        /// <summary>
        /// Урок 7. Перегруженные метод умножает 2 целых числа
        /// </summary>
        /// <param name="arg1 - первый множитель"></param>
        /// <param name="arg2 - второй множитель"></param>
        /// <returns></returns>
        public static int Multiplay(int arg1, int arg2) => arg1 * arg2;
        /// <summary>
        /// Урок 7. Перегруженные метод умножает 2 числа с плавающей запятой
        /// </summary>
        /// <param name="arg1 - первый множитель"></param>
        /// <param name="arg2 - второй множитель"></param>
        /// <returns></returns>
        public static double Multiplay(double arg1, double arg2) => arg1 * arg2;
        /// <summary>
        /// Урок 7. Дженерик метод перемножает 2 аргумента
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arg1 - первый множитель"></param>
        /// <param name="arg2 - второй множитель"></param>
        /// <returns></returns>
        public static T Multiplay<T>(T arg1, T arg2)
            where T : IMultiplyOperators<T,T,T>
            => arg1* arg2;
    }
}
