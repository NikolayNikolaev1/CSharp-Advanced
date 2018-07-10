namespace Problem_01._Unique_Usernames
{
    using System;
    using System.Collections.Generic;

    class Unique_Usernames
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);
            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
