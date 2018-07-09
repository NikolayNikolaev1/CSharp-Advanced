namespace Lab_04._Academy_Graduation
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class Academy_Graduation
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < number; i++)
            {
                string student = Console.ReadLine();
                List<double> result = Console.ReadLine()
                    .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => double.Parse(n, CultureInfo.InvariantCulture))
                    .ToList();
                students.Add(student, result);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value}");
            }
        }
    }
}
