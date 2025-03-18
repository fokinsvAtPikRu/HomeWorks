namespace Lesson4;
class Lesson4Task5
{
    public static void Main()
    {
        int min = 20;
        int max = 60;
        while (true)
        {
            Console.Write($"Введите число от {min} до {max} включительно:");
            string str = Console.ReadLine();
            int? result=ConvertStringToInt(str);
            if (result is null)
            {
                Console.WriteLine($"{str} не является числом.");
                Console.ReadKey();
            }
            else if (!IsValueInRange(result, min, max))
            {
                Console.WriteLine($"{result} вне диапазона [{min},{max}].");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{result} является корректным значением.\nПрограмма завершена.");
                Console.ReadKey();
                break;
            }
            Console.Clear();
        }

    }
    private static int? ConvertStringToInt(string str) => Int32.TryParse(str, out int value) ? value : null;    
    private static bool IsValueInRange(int? value, int min, int max) => value >= min && value <= max;

}
