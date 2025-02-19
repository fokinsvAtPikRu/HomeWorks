using System;
namespace Lesson2_Task1
{
    static class Program
    {
        public static void Main() 
        {
            int i = 1234;
            string s =i.ToString();
            string s1 = s[2] + s[1] + s[0] + s[3];

            Console.WriteLine(i.ToString());
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