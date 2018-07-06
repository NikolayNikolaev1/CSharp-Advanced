namespace Exercises_04._Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;

    class BasicQueueOperations
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] number = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);
            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(int.Parse(number[i]));
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestElement = queue.Dequeue();

                while (queue.Count != 0)
                {
                    int currentElement = queue.Dequeue();

                    if (currentElement < smallestElement)
                    {
                        smallestElement = currentElement;
                    }
                }

                Console.WriteLine(smallestElement);
            }
        }
    }
}
