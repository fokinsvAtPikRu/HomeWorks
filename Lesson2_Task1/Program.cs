using System;
namespace Lesson2_Task1
{
    static class Program
    {
        public static void Main() 
        {
            var res = Lesson2.Lesson2.ConvertInchToMeter(157.0);
            Console.WriteLine($"meter {res.Item1}");
            Console.WriteLine($"santimeter {res.Item2}");
            Console.WriteLine($"milimeter {res.Item3}");
            //ConsoleKey key=ConsoleKey.C;                
            //    while (key != ConsoleKey.Escape)
            //{
            //    Console.WriteLine("1.");
            //    Console.WriteLine("2.");
            //    Console.WriteLine("3.");
            //    Console.WriteLine("4.");
            //    Console.WriteLine("5.");
            //    Console.WriteLine("6.");
            //    Console.WriteLine("Еsc - выход");
            //    Console.Write("Введите число:");
            //    key=Console.ReadKey().Key;
            //    Console.Write(((int)key));
            //}

            
        }
    }
}