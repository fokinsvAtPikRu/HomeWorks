using System.Security.Cryptography.X509Certificates;

namespace Lesson_10
{
    class Program
    {
        public static void Main()
        {
            // создаем объект типа Building
            var building = new Building("г. Москва ул. Пушкина д. 9", 1258.12, 1996);
            // создаем объект типа MultiBuilding
            var multibuilding = new MultiBuilding("г. Ленинград ул. Сталина д. 1", 999.99, 1937, 99, true);
            // апкаст MultiBulding => Bulding
            Building downCast = multibuilding;
            // даункаст Bulding => MultiBulding
            var upCast1 = downCast is MultiBuilding ? downCast as MultiBuilding : downCast;
            // вызов переопределенных методов
            Console.WriteLine($"CalculateTax override = {multibuilding.CalculateTax().ToString()}");
            Console.WriteLine($"DisplayInfo = {multibuilding.DisplayInfo()}");
            // новые метода MultiBuilding            
            Console.WriteLine($"AreaPerFloor = {multibuilding.AreaPerFloor}");
        }
    }
}