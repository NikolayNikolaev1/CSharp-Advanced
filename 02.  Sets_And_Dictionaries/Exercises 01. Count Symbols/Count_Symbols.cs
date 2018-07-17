namespace Exercises_01._Count_Symbols
{
    using System;
    using System.Collections.Generic;

    class Count_Symbols
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var set = new SortedSet<char>();
            var dic = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (dic.ContainsKey(input[i]))
                {
                    dic[input[i]]++;
                }
                else
                {
                    dic.Add(input[i], 1);
                }
            }

            foreach (var d in dic)
            {
                Console.WriteLine($"{d.Key}: {d.Value} time/s");
            }
        }
    }
}
