using Lesson3;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson5
{
    public enum EvenAndOddElements // для результата первого задания
    {
        EvenIsMore,
        OddIsMore,
        Equal
    }
    public class Lesson5
    {
        public static int[] CreateArray(int length) => new int[length];               // фабрика массивов
        public static void AddRandomElements(int[] array, int min, int max)           // заполнение массива случайными значениями 
        {
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(min, max);
        }
        public static int FoldMassive(int[] array, int init, Predicate<int> predicate, Action<int> action) // свертка массива
        {
            foreach (int element in array)
                if (predicate(element)) action(init);
            return init;
        }
        public static int NumberOfEvenElements(int[] array) =>
            FoldMassive(array, 0, (x) => x % 2 == 0, (x) => x++);                                 // количество четных элементов

        public static int CountOfPositiveElements(int[] array) =>
            FoldMassive(array, 0, (x) => x > 0, (x) => x++);                                      // количество положительных чисел

        public static int CountOfNegativeElements(int[] array) =>
            FoldMassive(array, 0, (x) => x < 0, (x) => x++);                                      // количество отрицательных чисел

        public static int CountOfZeroElements(int[] array) =>
            FoldMassive(array, 0, (x) => x == 0, (x) => x++);                                     // количество нулей

        public static int MaxElementValue(int[] array) =>
            FoldMassive(array, array[0], (x) => true, (x) => x++);


        public static EvenAndOddElements IsNumberOfEvenElementsGreater(int[] array)  // метод выполняет 1 задание урока 5
        {
            int countOfEvenElements = NumberOfEvenElements(array);
            return
                countOfEvenElements > array.Length - countOfEvenElements ? EvenAndOddElements.EvenIsMore :    // больше четных
                countOfEvenElements < array.Length - countOfEvenElements ? EvenAndOddElements.OddIsMore :     // больше нечетных 
                EvenAndOddElements.Equal;                                                                     // равное количество            
        }
        public static (int, int, int) CountPositiveNegativeZeroElements(int[] array) =>
            (CountOfPositiveElements(array), CountOfNegativeElements(array), CountOfZeroElements(array)); // метод выполняет 2 задание урока 5



    }
}
