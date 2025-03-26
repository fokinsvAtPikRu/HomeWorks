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
        public static void CalcCube(double edgeCube, out double cubeVolume, double cubeArea)
        {
            cubeArea = 6*edgeCube*edgeCube;
            cubeVolume = edgeCube*edgeCube*edgeCube;
        }
    }
}
