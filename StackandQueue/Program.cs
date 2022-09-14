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
        
            stacklist.Push(70);
            stacklist.Push(30);
            stacklist.Push(56);
            stacklist.Peek();
            stacklist.Pop();
            stacklist.Display();
            Console.ReadLine();
        }
    }
}
