namespace Exercises_06._Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Truck_Tour
    {
        static void Main()
        {
            int totalPetrolPumps = int.Parse(Console.ReadLine());
            int totalPetrol = 0;
            var queue = new Queue<int[]>();
            int startIndex = 0;

            for (int i = 0; i < totalPetrolPumps; i++)
            {
                int[] petrolPump = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int amountPetrol = petrolPump[0];
                int distance = petrolPump[1];
                totalPetrol += amountPetrol;

                if (totalPetrol >= distance)
                {
                    totalPetrol -= distance;
                }
                else
                {
                    totalPetrol = 0;
                    startIndex = i + 1;
                }
            }

            Console.WriteLine(startIndex);
        }
    }
}
