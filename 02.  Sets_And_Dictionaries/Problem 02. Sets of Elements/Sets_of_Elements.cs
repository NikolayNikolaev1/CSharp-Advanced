namespace Problem_02._Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Sets_of_Elements
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            var result = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }

            for (int i = 0; i < input[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }

            foreach (var firstNum in firstSet)
            {
                foreach (var secondNum in secondSet)
                {
                    if (firstNum == secondNum)
                    {
                        result.Add(firstNum);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
