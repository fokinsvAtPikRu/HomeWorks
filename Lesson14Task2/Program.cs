using Lesson14Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        var warehous = new Warehous();
        warehous.AddGood("A001", 10);
        warehous.AddGood("B205", 25);
        warehous.AddGood("C307", 15);
        bool result = warehous.Contains("B205");
        Console.WriteLine($"Есть ли товар с артикулом \"B205\": {result}");
        warehous["A101"] = 8;
        int? headphonesCount = warehous.GetValue("C307");
        Console.WriteLine($"Количество наушников: {headphonesCount}");
        warehous.ChangeValue("B205", 5, (x, y) => x + y);
        warehous.Remove("C307");
        foreach(KeyValuePair<string,int> good  in warehous)
        {
            Console.WriteLine($"Артикул: {good.Key}, Количество: {good.Value}");
        }
        result = warehous.Count() == 0;
        Console.WriteLine($"Инвентарь пуст? {result}");
        warehous.Clear();
        Console.WriteLine($"Количество товаров после очистки: {warehous.Count()}");
    }
}