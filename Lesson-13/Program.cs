
internal class Program
{
    public delegate T Transformer<T>(int value);
    private static void Main(string[] args)
    {
        Transformer<int>[] transformerList =
        {
            x=>x*2,
            x=>x*x,
            x=>Math.Abs(x)
        };        
        int[] data = { 1, 2, 5, -7, 9 };
        int[] result;
        foreach(var transformer in transformerList)
        {
            result=Transform<int>(data, transformer);
            PrintArray(result);
        }   
        
    }
    public static T[] Transform<T>(int[] data, Transformer<T> transformer)
    {
        T[] result = new T[data.Length];
        for (var i = 0; i < data.Length; i++)
        {
            result[i] = transformer(data[i]);
        }
        return result;
    }

    public static void PrintArray<T>(T[] result)
    {
        foreach (var i in result)
        {
            Console.Write(i);
            Console.Write("  ");
        }
        Console.WriteLine();
    }
}