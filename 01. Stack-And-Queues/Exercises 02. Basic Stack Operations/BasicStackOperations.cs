using System;
using System.Collections.Generic;

namespace Exercises_02._Basic_Stack_Operations
{
    class BasicStackOperations
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(numbers[i]));
            }

            for (int i = 0; i < s; i++)
            {
                if (stack.Count != 0)
                {
                    stack.Pop();
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestNum = stack.Pop();

                while (stack.Count != 0)
                {
                    int currentNum = stack.Pop();

                    if (currentNum < smallestNum)
                    {
                        smallestNum = currentNum;
                    }
                }

                Console.WriteLine(smallestNum);
            }
        }
    }
}
