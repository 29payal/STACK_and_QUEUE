using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queuelist = new Queue();
            queuelist.Enqueue(56);
            queuelist.Enqueue(30);
            queuelist.Enqueue(70);
            queuelist.Dequeue();
            queuelist.Display();

            Console.ReadLine();
        }
    }
}
