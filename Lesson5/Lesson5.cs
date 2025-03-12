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
        public static int FoldArrayValue(int[] array, int acc, Func<int, int, int> f)             // свертка массива foreach
        {                                                                                         // для задач где не нужен              
            foreach (int element in array)                                                        // индекс элемента  
                acc = f(element, acc);
            return acc;
        }
        public static int FoldArrayIndex(int[] array, int accIndex, Func<int, int, int> f)       // свертка для задач где нужен индекс
        {
            for (int i = 0; i < array.Length; i++)
            {
                accIndex = f(array[i], array[accIndex]);
            }
            return accIndex;
        }
        public static int CountOfEvenElements(int[] array) =>
            FoldArrayValue(array, 0, (element, acc) => element % 2 == 0 ? ++acc : acc);              // количество четных элементов
        public static int CountOfOddElements(int[] array) =>
            FoldArrayValue(array, 0, (element, acc) => element % 2 != 0 ? ++acc : acc);              // количество нечетных элементов
        public static int CountOfPositiveElements(int[] array) =>
            FoldArrayValue(array, 0, (element, acc) => element > 0 ? ++acc : acc);                   // количество положительных чисел

        public static int CountOfNegativeElements(int[] array) =>
            FoldArrayValue(array, 0, (element, acc) => element < 0 ? ++acc : acc);                   // количество отрицательных чисел

        public static int CountOfZeroElements(int[] array) =>
            FoldArrayValue(array, 0, (element, acc) => element == 0 ? ++acc : acc);                  // количество нулей
        // 
        public static int MaxElementIndex(int[] array) =>                                            // индекс макс элемента
            FoldArrayIndex(array, 0,
                (elementIndex, maxIndex) =>
                array[elementIndex] > array[maxIndex] ? maxIndex = elementIndex : maxIndex);
        public static int MinElementIndex(int[] array) =>
            FoldArrayIndex(array, 0,(elementIndex,minIndex)=>
            array[elementIndex] < array[minIndex] ? minIndex = elementIndex : minIndex);
        public static void Swap(ref int x, ref int y)                                                 // обмен элементов массива
        {
            var temp=x; x=y; y=temp;
        }
        public static int[] SortArray(int[] array,int startIndex, int endIndex, Func<int,int,bool> comparer)                        // сортировка массива
        {                                                                                                                           // O(n^2) 
            if(startIndex < 0 || startIndex > array.Length-1 ||endIndex > array.Length-1 || startIndex < 0)
                throw new ArgumentOutOfRangeException("Значения стартового или конечного индекса вне диапазона!");
            for (int i = startIndex; i <= endIndex; i++)
            {
                var max = array[i];
                var maxIndex = i;
                for (int j = i; j <= endIndex; j++)
                {
                    if (comparer(array[j], max))
                    {
                        max = array[j];
                        maxIndex = j;
                    }
                }
                Swap(ref array[i], ref array[maxIndex]);
            }
            return array;
        }

        public static EvenAndOddElements IsNumberOfEvenElementsGreater(int[] array)  // метод выполняет 1 задание урока 5
        {
            int even = CountOfEvenElements(array);
            int odd = CountOfOddElements(array);
            return
                even > odd ? EvenAndOddElements.EvenIsMore :    // больше четных
                even < odd ? EvenAndOddElements.OddIsMore :     // больше нечетных 
                EvenAndOddElements.Equal;                                                                     // равное количество            
        }
        public static (int, int, int) CountPositiveNegativeZeroElements(int[] array) =>
            (CountOfPositiveElements(array), CountOfNegativeElements(array), CountOfZeroElements(array));    // метод выполняет 2 задание урока 5
        public static ((int,int), (int,int)) MaxMinElement(int[] array)                                      // метод выполняет 3 задание урока 5
        {
            var maxIndex = MaxElementIndex(array);
            var minIndex = MinElementIndex(array);
            return ((maxIndex, array[maxIndex]), (minIndex, array[minIndex]));
        }
            
        


    }
}
