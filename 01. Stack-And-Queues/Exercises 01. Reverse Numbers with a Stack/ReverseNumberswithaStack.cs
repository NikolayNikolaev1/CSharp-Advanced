namespace Exercises_01._Reverse_Numbers_with_a_Stack
{
    using System;
    using System.Collections.Generic;

    class ReverseNumberswithaStack
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<int>();

            foreach (var number in input)
            {
                stack.Push(int.Parse(number));
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
