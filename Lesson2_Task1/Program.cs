using System;
namespace Lesson2
{
    static class Program
    {
        public static void Main() 
        {
            int choiсe;
            ConsoleKey key = ConsoleKey.C;
            while (key != ConsoleKey.Escape)
            {
                Console.WriteLine("1. Циклический сдвиг 3х переменных.");
                Console.WriteLine("2. Перевод из градусов в радианы.");
                Console.WriteLine("3. Перевод дюймы в метры.");
                Console.WriteLine("4. Поменять вторую и четвертую цифру.");
                Console.WriteLine("5. Округление вверх.");
                Console.WriteLine("6. Округление до 0,5.");
                Console.WriteLine("7. Поменть значение двух переменных без третьей.");
                Console.WriteLine("Еsc - выход");
                Console.Write("Введите число:");
                var str=Console.ReadLine();
                try
                {
                    choiсe = Convert.ToInt32(str);
                    ChoiceTask(choiсe);
                }
                catch(FormatException)
                {
                    Console.WriteLine($"Ошибка! {str} не является числом");
                }
                Console.WriteLine("Для продолжения нажмите любую кнопку. Для выхода ESC.");
                key = Console.ReadKey().Key;
                Console.Write(((int)key));
            }


        }
        public static void ChoiceTask(int choice) 
        {
        switch(choice)
            {
                case 1:

                    break;
                    case 2:

                    break;
                    case 3:

                    break;
                    case 4:

                    break;
                    case 5:

                    break;
                    case 6:

                    break;
                    case 7:

                    break;
            }
        }

            
    }
}