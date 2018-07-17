namespace Exercises_02._Phonebook
{
    using System;
    using System.Collections.Generic;

    class Phonebook
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            var phonebook = new Dictionary<string, String>();

            while (input[0] != "search")
            {
                string name = input[0];
                string number = input[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, number);
                }
                else
                {
                    phonebook[name] = number;
                }

                input = Console.ReadLine()
                    .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            }

            input = Console.ReadLine()
                .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "stop")
            {
                string name = input[0];

                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phonebook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }

                input = Console.ReadLine()
                    .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
