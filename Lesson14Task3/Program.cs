using Lesson14Task3;
using System.Globalization;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        var emails=new EmailContainer();
        emails.Add("alice@example.com");
        emails.Add("bob@example.com");
        emails.Add("charlie@example.com");
        bool result = emails.Add("alice@example.com");
        Console.WriteLine($"Дубликат alice@example.com добавлен? {result}");
        result = emails.Contains("bob@example.com");
        Console.WriteLine($"Есть ли bob@example.com в подписчиках? {result}");
        result = emails.Contains("dave@example.com");
        Console.WriteLine($"Есть ли dave@example.com в подписчиках? {result}");
        var other=new EmailContainer();
        other.Add("bob@example.com");
        other.Add("dave@example.com");
        other.Add("eve@example.com");
        emails.UnionWith(other);
        Console.WriteLine("Подписчики после объединения:");
        foreach(var email in emails)
            Console.WriteLine(email);
        var intersect=emails.IntersectWith(other);
        Console.WriteLine("Общие подписчики:");
        foreach (var email in intersect)
            Console.WriteLine(email);
        result = emails.Remove("charlie@example.com");
        Console.WriteLine($"Удалили charlie@example.com? {result}");
        Console.WriteLine($"Всего подписчиков: {emails.Count}");
        result = other.IsSubsetOf(emails);
        Console.WriteLine($"other является подмножеством? {result}");
        emails.Clear();
        Console.WriteLine($"Всего подписчиков после очистки: {emails.Count}");
    }
}