using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16Task
{
    internal static class ArrayTools
    {
        public static int[] CreateArray(int count)
        {
            Console.WriteLine("Метод CreateArray запущен");
            var rand=new Random();
            var array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(0, 100);
                Console.WriteLine($"Элементу массива {i} присвоено значение:{array[i]}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Метод CreateArray завершен");
            return array;            
        }
        public static async Task<int[]> CreateArrayAsync(int count)
        {
            Console.WriteLine($"Метод CreateArrayAsync запущенн");
            int[] array=await Task.Run(() => CreateArray(count));            
            Console.WriteLine($"Метод CreateArrayAsync завершен");
            return array;
        }
        public static int GetArraySumma(int[] array)
        {
            Console.WriteLine("Метод GetArraySumma запущен");           
            int sum = 0;
            foreach (var item in array)
            {                
                sum += item;
                Console.WriteLine($"Элемент массива {item} обработан. Текущая суммма:{sum}");
                Thread.Sleep(800);
            }
            Console.WriteLine("Метод GetArraySumma завершен");
            return sum;
        }
        public static async Task<int> GetArraySummaAsync(int[] array)
        {
            Console.WriteLine($"Метод GetArraySummaAsync запущенн");
            int sum = await Task.Run(() => GetArraySumma(array));
            Console.WriteLine($"Метод GetArraySummaAsync завершен");
            return sum;

        }
    }
}
