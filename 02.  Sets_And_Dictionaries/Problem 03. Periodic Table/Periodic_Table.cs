namespace Problem_03._Periodic_Table
{
    using System;
    using System.Collections.Generic;

    class Periodic_Table
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();

            for (int i = 0; i < input; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var el in elements)
                {
                    set.Add(el);
                }
            }

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
