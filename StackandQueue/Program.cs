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
            Stack stacklist = new Stack();
            Console.WriteLine("Push elements in the stacklist :");
            stacklist.Push(70);
            stacklist.Push(30);
            stacklist.Push(56);
            stacklist.Display();
            Console.ReadLine();
        }
    }
}
