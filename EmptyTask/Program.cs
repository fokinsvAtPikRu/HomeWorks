
using System;
using System.Text;

public class Program
{


    public static void Main(string[] args)
    {
        string path= new string(@"C:\myRepo\Task3Text\test.txt");
        SaveStringWithEscapeSequences(Task3Report1(new DateTime(2006, 12, 05), 15165165.259999m, 16),path);
        Console.ReadKey();
    }

    public static string Task3Report1(DateTime date, decimal totalSells, uint countGoodsSells)
    {
        double averageProductPrice = (double)totalSells / countGoodsSells;
        var report = new StringBuilder(new string('-', 60));
        report.Append("\n");
        report.Append($"Отчет о продажах за {date.ToString("MMMM")} {date.Year}");
        report.Append("\n");
        report.Append('-', 60);
        report.Append("\n");
        report.Append($"Общая сумма продаж: {totalSells:0,0.00} руб \n");        
        report.Append($"Количество проданных товаров: {countGoodsSells} шт \n");        
        report.Append($"Средняя стоимость товаров - {averageProductPrice:N2} руб/шт \n");
        report.Append('-', 60);
        return report.ToString();
    }
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