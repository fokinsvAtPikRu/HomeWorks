
internal class Program
{
    public delegate T Transformer<T>(int value);
    private static void Main(string[] args)
    {
        Transformer<int> add2 = x => x + 2;
        Transformer<int> id = x => x;
        Transformer<double> divadeBy2 = x => (double)x / 2;
        int[] data = { 1, 2, 5, 7, 9 };
        int[] result = Transform<int>(data, add2);
        PrintArray(result);
        result = Transform<int>(data, id);
        PrintArray(result);
        var resultF = Transform<double>(data, divadeBy2);
        PrintArray(resultF);
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