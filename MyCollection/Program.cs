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
            //var collection = new MyCollection<int>(1, 2, 3);
            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}

            // Очередь на связанном списке
            var queue = new MyQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            foreach (var item in queue)
                Console.WriteLine(item);
            while (!queue.IsEmpty)
                Console.WriteLine(queue.Dequeue());
        }
    }
}
