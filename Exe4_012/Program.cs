using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
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
                Console.WriteLine();
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
                    Console.WriteLine("[" + (i + 1) + "]: " + yoga[i]);
                }
            }

            bool empty()
            {
                if (top == -1)
                    return (true);
                else
                    return (false);
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
                Console.WriteLine("Exit");
                Console.WriteLine("\nEnter your choise: (1-3) ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch (ch)
                {
                    case '1':
                        Console.Write("Enter the character : ");
                        string yoga = Console.ReadLine();
                        s.push();
                        break;

                    case '2':
                        s.pop();
                        break;

                    case '3':
                        s.display();
                        break;

                    case '4':
                        return;

                    default:
                        Console.WriteLine("\nInvalid option");
                        break;
                }
            }
        }
    }
}
