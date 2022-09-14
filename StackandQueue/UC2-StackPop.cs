using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    public class Stack
    {
        Node top;
        internal class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
               // Console.WriteLine("Stack is empty");
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
           // Console.WriteLine("{0} is pushed to stack ",data);
        }

        public void Display()
        {
            if (top == null)
                Console.WriteLine("stack is empty");

            while (top != null)
            {
                Console.WriteLine("| " + top.data + "| ");
                top = top.next;   //null
            }
        }
        public void Peek()
        {
            if (top == null)
            {
               // Console.WriteLine("stack is empty");
                return;
            }

            Console.WriteLine("{0} is on the top of stack ", top.data);
        }

        public void Pop()
        {
            if (top == null)
            {
                //Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is deleted from the stack ", top.data);
            top = top.next;
        }
    }

}
