namespace Lab_3._DecimalToBinaryConverter
{
    using System;
    using System.Collections.Generic;

    class DecimalToBinaryConverter
    {
        static void Main()
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            if (decimalNumber == 0)
            {
                Console.Write(0);
            }

            while (decimalNumber != 0)
            {
                stack.Push(decimalNumber % 2);
                decimalNumber /= 2;
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
