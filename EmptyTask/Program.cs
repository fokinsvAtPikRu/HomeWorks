
using System.Text;

public class Program
{


    public static void Main(string[] args)
    {
        Console.WriteLine(Task3Report1(new DateTime(2006, 12, 05), 15, 16));
        Console.ReadKey();
    }
    
    public static string Task3Report1(DateTime date, decimal totalSellsCent, uint countGoodsSells)
    {
        var report = new StringBuilder();
        report.AppendFormat(
        report.Append($"Отчет о продажах за {date.ToString("MMMM")} {date.Year}");
        


        return report.ToString();
    }
}