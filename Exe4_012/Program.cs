﻿using System;
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
    }
}
