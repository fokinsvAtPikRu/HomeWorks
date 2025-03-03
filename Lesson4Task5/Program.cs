namespace Lesson4;
class Lesson4Task5
{
    public static void Main()
    {
        int min = 20;
        int max = 60;
        while (true)
        {
            Console.WriteLine($"Введите число от {min} до {max} включительно:");
            string str = Console.ReadLine();
            int? result=ConvertStringToInt(str);
            if (result != null && IsValueInRange(result, min, max))
            {
                Console.WriteLine($"{result} корректное значение.");
                break;
            }
            Console.Clear();
        }

    }
    private static int? ConvertStringToInt(string str)
    {
        if (Int32.TryParse(str, out int value))
        {
            return value;
        }
        else
        {
            Console.WriteLine($"{str} не является числом.");
            return null;
        }
    }
    private static bool IsValueInRange(int? value, int min, int max) => value >= min && value <= max;

}
