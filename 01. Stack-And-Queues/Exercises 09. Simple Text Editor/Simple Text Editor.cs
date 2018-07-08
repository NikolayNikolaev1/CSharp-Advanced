namespace Exercises_09._Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            var commands = new Stack<string[]>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string commandIndex = command[0];

                switch (commandIndex)
                {
                    case "1":
                        commands.Push(command);
                        string someString = command[1];
                        text.Append(someString);
                        break;
                    case "2":
                        int count = int.Parse(command[1]);
                        string sub = text.ToString().Substring(text.Length - count);
                        text.Remove(text.Length - count, count);
                        commands.Push(new string[] { "2", sub });
                        break;
                    case "3":
                        int index = int.Parse(command[1]);
                        Console.WriteLine(text.ToString().Substring(index - 1, 1));
                        break;
                    case "4":
                        string[] currentCommand = commands.Pop();
                        string currentCommandIndex = currentCommand[0];

                        if (currentCommandIndex == "1")
                        {
                            int len = currentCommand[1].Length;
                            text.Remove(text.Length - len, len);
                        }
                        else if (currentCommandIndex == "2")
                        {
                            text.Append(currentCommand[1]);
                        }
                        break;
                }
            }
        }
    }
}
