using System.Net.Http.Headers;

namespace Lesson11
{
    class Program
    {
        public static void Main()
        {
            Animal[] animals = { new Cat(), new Dog() };
            foreach (var anim in animals)
                Console.WriteLine(anim.ShowInfo());
            IFlyable[] flyers = { new Bird(30), new Airplane(10000, 289) };
            foreach (var flyer in flyers)
                Console.WriteLine(flyer.Fly());
        }
    }
}