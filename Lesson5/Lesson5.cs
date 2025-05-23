﻿namespace Lesson5
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
        public static int[,] CreateArray(int raw, int columns) => new int[raw, columns];
        public static void AddRandomElements(int[] array, int min, int max)           // заполнение массива случайными значениями 
        {
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(min, max);
        }
        // можно ввести счетчик и объеденить обе свертки
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
                accIndex = f(i, accIndex);
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
                array[elementIndex] > array[maxIndex] ? maxIndex = elementIndex : maxIndex);         // индекс мин элемента
        public static int MinElementIndex(int[] array) =>
            FoldArrayIndex(array, 0, (elementIndex, minIndex) =>
            array[elementIndex] < array[minIndex] ? minIndex = elementIndex : minIndex);
        public static void Swap(ref int x, ref int y)                                                 // обмен элементов массива
        {
            var temp = x; x = y; y = temp;
        }
        public static int[] SortArray(int[] array, int startIndex, int endIndex, Func<int, int, bool> comparer)      // сортировка массива
        {                                                                                                            // O(n^2) 
            if (startIndex < 0 || startIndex > array.Length - 1 || endIndex > array.Length - 1 || startIndex < 0)    // в Array есть метод Sort
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
            int odd = CountOfOddElements(array);                // можно сделать odd=Length-even
            return
                even > odd ? EvenAndOddElements.EvenIsMore :    // больше четных
                even < odd ? EvenAndOddElements.OddIsMore :     // больше нечетных 
                EvenAndOddElements.Equal;                       // равное количество            
        }
        public static (int, int, int) CountPositiveNegativeZeroElements(int[] array) =>
            (CountOfPositiveElements(array), CountOfNegativeElements(array), CountOfZeroElements(array));    // метод выполняет 2 задание урока 5
        public static ((int, int), (int, int)) MaxMinElement(int[] array)                                    // метод выполняет 3 задание урока 5
        {
            var maxIndex = MaxElementIndex(array);
            var minIndex = MinElementIndex(array);
            return ((maxIndex, array[maxIndex]), (minIndex, array[minIndex]));
        }
        public static int[] ReverseArray(int[] array)                                             // метод выполняет задание 4 урока 5
        {                                                                                         // в классе Array есть метод Reverse
            int[] reverse = new int[array.Length];                                                // Array.Reverse(array); делает то же самое
            for (var i = 0; i < array.Length; i++)
            {
                reverse[i] = array[array.Length - 1 - i];
            }
            return reverse;
        }
        public static int[] SortAscendingDescending(int[] array)                                   // метод выполняет задание 5 урока 5
        {
            SortArray(array, 0, 4, (element, max) => element < max ? true : false);
            SortArray(array, 5, 9, (element, max) => element > max ? true : false);
            return array;
        }
        public static bool[,] ChessDeskArray(int raw, int columns)        // метод выполняет задание 6 урока 5
        {
            bool[,] array = new bool[raw, columns];
            for (var i = 0; i < raw; i++)
                for (var j = 0; j < columns; j++)
                    array[i, j] = (i + j) % 2 == 0;
            return array;
        }
        public static int[] MaxInRaw(int[,] array)                        // метод выполняет задание 7 урока 5
        {
            int raws = array.GetUpperBound(0) + 1;       // количество строк
            int columns = array.GetUpperBound(1) + 1;    // количество столбцов
            int[] maxInRaw = new int[raws];
            int max;
            for (var i = 0; i < raws; i++)
            {
                max = array[i, 0];
                for (int j = 0; j < columns; j++)
                {
                    max = array[i, j] > max ? array[i, j] : max;
                }
                maxInRaw[i] = max;
            }
            return maxInRaw;
        }
        public static (int, int) TwoGreatestValue(int[] array)            // метод выполняет задание 8 урока 5
        {
            int[] araySorted = SortArray(array, 0, array.Length - 1, (element, max) => element > max ? true : false);
            if (araySorted.Length > 1)
                return (araySorted[0], araySorted[1]);
            else if (araySorted.Length == 1)
                return (araySorted[0], araySorted[0]);
            else
                throw new ArgumentException("Массив пустой");
        }
        public static bool IsXWins(bool[,] array)        // метод выполняет задание 10 урока 5
        {
            int rows = array.GetUpperBound(0) + 1;       // количество строк
            int columns = array.GetUpperBound(1) + 1;    // количество столбцов
            bool xWins;
            for (var i = 0; i < rows; i++)               // проверяем строки
            {
                xWins=true;
                for (int j = 0; j < columns; j++)
                {
                    if (!array[i, j])
                    {  xWins = false; break; }           // если встречаем ноль, переходим на новую строку              
                }
                if (xWins) return true;                     // строка без 0 найдена, Х выиграли
            }
            for (var i = 0; i < columns; i++)               // проверяем столбцы
            {
                xWins = true;
                for (int j = 0; j < rows; j++)
                {
                    if (!array[j, i])
                    { xWins = false; break; }            // если встречаем ноль, переходим на новую строку
                }
                if (xWins) return true;                     // столбец без 0 найдена, Х выиграли
            }
            xWins = true;
            for (var i = 0; i < columns; i++)               // проверяем диагональ
            {
                if (!array[i,i]) 
                    { xWins = false; break; }
            }
            if (xWins) return true;
            for (var i = columns-1; i <= 0; i--)            // проверяем другую диагональ
            {
                if (!array[i, i])
                { xWins = false; break; }
            }
            if (xWins) return true;
            return false;
        }
    }
}
