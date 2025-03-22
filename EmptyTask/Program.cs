
using System;
using System.Text;

public class Program
{


    public static void Main(string[] args)
    {
        string path= new string(@"E:\test.txt");
        SaveStringWithEscapeSequences(Task4StringBuilder("Мурчеслав", 4, "Муром"),path);
        Console.ReadKey();
    }

    public static string Task4StringBuilder(string name, int age, string city) =>
            new StringBuilder().Append($"Имя: {name}, ").Append($"Возраст: {age}, ").Append($"Город: {city}").ToString();
    static void SaveStringWithEscapeSequences(string input, string filePath)
    {
        try
        {
            string escapedText = input
                .Replace("\n", "\\n")
                .Replace("\r", "\\r")
                .Replace("\t", "\\t");

            File.WriteAllText(filePath, escapedText, Encoding.UTF8);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при сохранении файла: {ex.Message}");
        }
    }
}