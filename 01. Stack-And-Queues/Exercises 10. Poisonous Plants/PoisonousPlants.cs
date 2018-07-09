namespace Exercises_10._Poisonous_Plants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PoisonousPlants
    {
        static void Main()
        {
            int numberOfPlants = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>(plants.Reverse());
            bool hadDiedPlants = true;
            int rightPlant;
            int leftPlant;
            int days = 0;
            int diedPlants = 0;

            while (hadDiedPlants)
            {
                for (int i = 0; i < numberOfPlants - 1; i++)
                {
                    rightPlant = queue.Dequeue();
                    leftPlant = queue.Peek();

                    if (rightPlant <= leftPlant)
                    {
                        queue.Enqueue(rightPlant);
                    }
                    else
                    {
                        diedPlants++;
                    }
                }

                int lastPlant = queue.Dequeue();
                queue.Enqueue(lastPlant);

                if (diedPlants == 0)
                {
                    hadDiedPlants = false;
                }

                numberOfPlants -= diedPlants;
                diedPlants = 0;
                days++;
            }

            Console.WriteLine(days - 1);
        }
    }
}

