using Lesson14Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        var team=new TeammateList();
        team.AddTeammate("Иванов");
        team.AddTeammate("Петров");
        team.AddTeammate("Сидоров");
        team.AddTeammate("Козлов", 1);
        bool result = team.ContainsTeammate("Петров");
        Console.WriteLine($"Есть ли игрок Петров в команде? {result}");
        team.RemoveTeammate("Сидоров");
        var index = team.IndexOf("Козлов");
        Console.WriteLine($"Индекс игрока Козлов: {index}");
        team.Sort();
        var teamArray=team.ToArray();
        for (var i=0; i<teamArray.Length; i++)
            Console.WriteLine($"{i+1}. {teamArray[i]}");
        result=team.IsEmpty();
        Console.WriteLine($"Команда пуста? {result}");
        team.Clear();
        Console.WriteLine($"Количество игроков после очистки: {team.Count}");
    }
}