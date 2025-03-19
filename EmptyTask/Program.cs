using System.Text;

public class Program
{
   
    public static void Main(string[] args)
    {
        int[] array = new int[] { 1, 2, 3, 4 };
        Array.Reverse(array);
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}