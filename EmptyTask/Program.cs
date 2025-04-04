
using System;
using System.Text;

public class Program
{


    public static void Main()
    {
        int n = 5;
        Console.WriteLine(FactorialRecursion(n));        
        Console.ReadKey();
    }
    public static int? FactorialRecursion(int n)
    {
        if (n < 0) return null;
        if (n == 0) return 1;
        else
            return n * FactorialRecursion(--n);
    }
}