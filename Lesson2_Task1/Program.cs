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
                Console.Write("Введите число:");
                var str=Console.ReadLine();
                try
                {
                    choiсe = Convert.ToInt32(str);
                    // вызов ChoiceTask надо вытащить из блока try, но есть проблема с видимостью переменной choice
                    ChoiceTask(choiсe);
                }
                catch(FormatException)
                {
                    Console.WriteLine($"Ошибка! {str} не является числом");
                }                
                Console.WriteLine("Для продолжения нажмите любую кнопку. Для выхода ESC.");
                key = Console.ReadKey().Key;
                Console.Write(((int)key));
                Console.Clear();
            }


        }
        public static void ChoiceTask(int choice) 
        {
            Console.Clear();
            switch(choice)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                case 7:
                    Task7();
                    break;
            }
        }
        public static void  Task1()
        {
            Console.Write("Введите первое значение:");
            var firstArg= Console.ReadLine();
            Console.Write("Введите второе значение:");
            var secondArg = Console.ReadLine();
            Console.Write("Введите третье значение:");
            var thirdArg = Console.ReadLine();
            Lesson2.SwapThreeVariables(ref firstArg,ref secondArg,ref thirdArg);
            Console.WriteLine($"Значения после сдвига: {firstArg}, {secondArg}, {thirdArg}");
        }
        public static void Task2()
        {
            Console.Write("Градусы:");
            // тут и дальше методы Convert надо обернуть в try catch
            var angleDegrees = Convert.ToInt32(Console.ReadLine());
            Console.Write("Угловые минуты:");
            var angleMinutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Угловые секунды:");
            var angleSeconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Величина угла в радианах: {Lesson2.AngleFromDegreesToRadians(angleDegrees, angleMinutes, angleSeconds)}");
        }
        public static void Task3()
        {
            Console.Write("Длина в дюймах:");            
            var lengthInch = Convert.ToDouble(Console.ReadLine());
            var lengthMetric = Lesson2.ConvertInchToMeter(lengthInch);
            Console.WriteLine
                ($"Длина {lengthMetric.Item1} м {lengthMetric.Item2} см {lengthMetric.Item3} мм");
        }
        public static void Task4()
        {
            Console.Write("Введите число:");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine
                ($"Меняем 2 и 4 цифру. Результат - {Lesson2.SwapSecondAndFourthFigure(number)} мм");
        }
        public static void Task5()
        {
            Console.Write("Введите число:");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine
                ($"Округляем вверх. Результат - {Lesson2.RoundUp(number)}");
        }
        public static void Task6()
        {
            Console.Write("Введите число:");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine
                ($"Округляем с точностью 0,5. Результат - {Lesson2.RoundToHalf(number)}");
        }
        public static void Task7()
        {
            Console.Write("Введите первое число:");
            var firstArg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            var secondArg = Convert.ToInt32(Console.ReadLine());
            Lesson2.SwapTwoNumbersWithoutThirdVariable(ref firstArg, ref secondArg);
            Console.WriteLine($"Первое число = {firstArg} \nВторое число = {secondArg}");
        }
    }
}