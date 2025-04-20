using MyCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MyEducation
{
    internal class Program
    {
        static void Main()
        {
            // Реализация с IEnumerable с yield return
            var collection = new MyCollection<int>(1, 2, 3);
            Console.WriteLine("Моя коллекция");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            // Очередь на связанном списке
            Console.WriteLine("\nОчередь на односвязаном списке");
            var queue = new MyQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            foreach (var item in queue)
                Console.WriteLine(item);
            while (!queue.IsEmpty)
                Console.WriteLine(queue.Dequeue());


            // возвращает 0,1,2,0,1,2,...
            Func<int, int> iterator = (x) =>
            {
                x++;
                return x % 3;
            };
            // создаем ленивую последовательность и печатаем 30 первых элементов
            var sequence = new MyLazySequence<int>(0, iterator);
            int i = 0;
            Console.WriteLine("\nЛенивая коллекция");
            foreach (var item in sequence)
            {
                Console.WriteLine(item);
                i++;
                if (i > 30)
                    break;
            }
        }
    }
}