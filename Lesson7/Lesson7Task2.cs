namespace Lesson7
{
    public static partial class Lesson7
    {
        /// <summary>
        /// Урок 7. Задание 2. Объем и площадь куба
        /// </summary>
        /// <param name="edgeCube"></param>
        /// <param name="cubeVolume"></param>
        /// <param name="cubeArea"></param>
        public static void CalcCube(double edgeCube, out double cubeVolume, out double cubeArea)
        {
            if (edgeCube <= 0 )
                throw new ArgumentException("Длина ребра куба должна быть положительным числом!");
            cubeVolume = edgeCube*edgeCube*edgeCube;
            cubeArea = 6 * edgeCube * edgeCube;
        }
    }
}
