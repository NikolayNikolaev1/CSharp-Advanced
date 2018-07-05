namespace Exercises_03._Maximum_Element
{
    using System;
    using System.Collections.Generic;

    class MaximumElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            int maxElement = 0;

            for (int i = 0; i < n; i++)
            {
                string[] query = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (query[0] == "1")
                {
                    int currentElement = int.Parse(query[1]);

                    if (maxElement < currentElement)
                    {
                        maxElement = currentElement;
                    }

                    stack.Push(currentElement);
                }
                else if (query[0] == "2")
                {
                    int removedElement = stack.Pop();

                    if (removedElement == maxElement)
                    {
                        maxElement = 0;

                        int[] arr = stack.ToArray();

                        for (int y = 0; y < arr.Length; y++)
                        {
                            if (maxElement < arr[y])
                            {
                                maxElement = arr[y];
                            }
                        }
                    }
                }
                else if (query[0] == "3")
                {
                    Console.WriteLine(maxElement);
                }
            }
        }
    }
}
