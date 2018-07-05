namespace Lab_5._HotPotato
{
    using System;
    using System.Collections.Generic;

    class HotPotato
    {
        static void Main()
        {
            string[] children = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(children);

            while (queue.Count != 1)
            {
                for (int i = 0; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
