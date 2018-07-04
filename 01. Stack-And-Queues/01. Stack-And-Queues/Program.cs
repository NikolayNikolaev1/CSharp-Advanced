﻿using System;
using System.Collections.Generic;

namespace _01._Stack_And_Queues
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>();

            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
