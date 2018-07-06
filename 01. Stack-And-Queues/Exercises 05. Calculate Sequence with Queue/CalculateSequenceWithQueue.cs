namespace Exercises_05._Calculate_Sequence_with_Queue
{
    using System;
    using System.Collections.Generic;

    class CalculateSequenceWithQueue
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            var membersQueue = new Queue<int>();
            queue.Enqueue(number);

            while (queue.Count < 50)
            {
                if (queue.Count < 50)
                {
                    queue.Enqueue(number + 1);
                    membersQueue.Enqueue(number + 1);
                }

                if (queue.Count < 50)
                {
                    queue.Enqueue(2 * number + 1);
                    membersQueue.Enqueue(2 * number + 1);
                }

                if (queue.Count < 50)
                {
                    queue.Enqueue(number + 2);
                    membersQueue.Enqueue(number + 2);
                }

                number = membersQueue.Dequeue();
            }

            Console.WriteLine(string.Join(" ", queue));
        }
    }
}
