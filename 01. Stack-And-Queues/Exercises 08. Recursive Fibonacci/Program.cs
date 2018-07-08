namespace Exercises_08._Recursive_Fibonacci
{
    using System;

    class Program
    {
        private static long[] fibNumbers;

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            fibNumbers = new long[number];
            long result = GetFibonaci(number);
            Console.WriteLine(result);
        }

        private static long GetFibonaci(int number)
        {
            if (number <= 2)
            {
                return 1;
            }
            if (fibNumbers[number - 1] != 0)
            {
                return fibNumbers[number - 1];
            }
            return fibNumbers[number - 1] =
                GetFibonaci(number - 1) + GetFibonaci(number - 2);
        }
    }
}
