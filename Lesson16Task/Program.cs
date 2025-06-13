namespace Lesson16Task
{
    internal class Program
    {
        private static async Task Main()
        {
            Console.WriteLine("Задача продолжения");
            Console.Write("Метод Main запущен");            
            Task<int[]> task1 =new Task<int[]>(() => { return ArrayTools.CreateArray(5); });
            task1.Start();
            Task<int> task2 = task1.ContinueWith(t =>
            {
                int[] array=t.Result;
                return ArrayTools.GetArraySumma(array);
            });
            Console.WriteLine($"Сумма массива равна {task2.Result}");
            Console.Write("Метод Main завершен");
            Console.WriteLine("Задача продолжения");
            Console.Write("Метод Main запущен");
            int[] array=await ArrayTools.CreateArrayAsync(5);
            int sum = await ArrayTools.GetArraySummaAsync(array);
            Console.WriteLine($"Сумма массива равна {sum}");
            Console.Write("Метод Main завершен");
        }
    }
}