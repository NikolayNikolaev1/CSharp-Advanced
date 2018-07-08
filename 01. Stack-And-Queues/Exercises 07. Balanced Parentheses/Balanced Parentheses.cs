namespace Exercises_07._Balanced_Parentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Balanced_Parentheses
    {
        static void Main()
        {
            string paranthesisLine = Console.ReadLine();
            var stack = new Stack<char>();
            char[] openingCases = new char[] { '{', '[', '(' };
            bool missmatch = false;

            for (int i = 0; i < paranthesisLine.Length; i++)
            {
                if (openingCases.Contains(paranthesisLine[i]))
                {
                    stack.Push(paranthesisLine[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (paranthesisLine[i])
                    {
                        case '}':
                            if (stack.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (stack.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (stack.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
