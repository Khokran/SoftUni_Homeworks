using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_Ass_Arr_Courses
{
    class Program
    {
        public static object Sort { get; private set; }

        static void Main(string[] args)
        {
            string command = string.Empty;
            var courseInfo = new Dictionary<string, List<string>>();
            
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" : ").ToArray();

                string nameCourse = input[0];
                string nameStudent = input[1];
                if (!courseInfo.ContainsKey(nameCourse))
                {
                    courseInfo.Add(nameCourse, new List<string>());
                    courseInfo[nameCourse].Add(nameStudent);
                }
                else courseInfo[nameCourse].Add(nameStudent);
            }
            foreach (var kvp in courseInfo.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var item in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
