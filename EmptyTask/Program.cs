using System.Text;

internal class Program
{    private static void Main(string[] args)
    {
        
        Console.WriteLine(PositivePowerRecursion(0, 0));
    }
    public static int? PositivePowerRecursion(int value, int power)
    {
        if (power < 0) return null;
        if (power == 0) return 1;
        else
            return value * PositivePowerRecursion(value, --power);
    }
}