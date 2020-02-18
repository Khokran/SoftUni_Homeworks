namespace Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfStudents = 0;
            var students = new Dictionary<string, List<double>>();
            numberOfStudents = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                var entry = Console.ReadLine().Split();

                if (students.ContainsKey(entry[0]))
                {
                    students[entry[0]].Add(double.Parse(entry[1]));
                }
                else
                {
                    students[entry[0]] = new List<double>() {Double.Parse(entry[1])};
                } 
            }
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {String.Join(" ", item.Value.Select(i => i.ToString("f2")))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
