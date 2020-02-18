using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_Ass_Arr_Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPair = int.Parse(Console.ReadLine());
            var ListGrades = new Dictionary<string, List<double>>();

            for (int i = 1; i <= numberPair; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!ListGrades.ContainsKey(name))
                {
                    ListGrades.Add(name, new List<double>());
                    ListGrades[name].Add(grade);
                }
                else if (ListGrades.ContainsKey(name))
                {
                    ListGrades[name].Add(grade);
                }
            }
            foreach (var item in ListGrades.OrderByDescending(x => x.Key).OrderByDescending(x => x.Value.Average()))
            {
                if (item.Value.Average() >=  4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }
        }
    }
}
