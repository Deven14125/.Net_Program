using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class QueueClass
    {
        public void GetQueueValue()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            queue.Enqueue(11);  
            queue.Enqueue(12);

            Console.WriteLine("After Enqueue Value in Queue : ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======================================================");

            
            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine("After Dequeue Value in Queue : ");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======================================================");

            Console.WriteLine("Peek Value in Queue : ");

            Console.WriteLine(queue.Peek());

            Console.WriteLine("=======================================================");

            Console.WriteLine("After Ckeck Value Contains Queue or Not : ");

            Console.WriteLine(queue.Contains(4));
            Console.WriteLine(queue.Contains(20));

            Console.WriteLine("=======================================================");

            queue.Clear();
        }
    }
}
