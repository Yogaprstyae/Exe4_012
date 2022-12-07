using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_012
{
    class Stack
    {
        private string[] yoga = new string[210];
        private int top;
        public Stack()
        {
            top = -1;
        }
         public void push()
        {
            if (top == -1)
            {
                Console.WriteLine("Push");
                return;
            }
            else
            {
                top++;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + yoga[top]);
                top--;
                return top;
            }
        }

        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + yoga[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Stack s = new Stack();
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
            }
        }
    }
}
