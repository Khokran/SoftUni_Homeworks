using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Filter_by_Age
{
    class _5_Filter_by_Age
    {
        static void Main(string[] args)
        {
            int peopleCount = Int32.Parse(Console.ReadLine());
            var people = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] person = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                people.Add(new KeyValuePair<string, int>(person[0], Int32.Parse(person[1])));
            }
            string filter = Console.ReadLine();
            int age = Int32.Parse(Console.ReadLine());
            string[] printPattern = Console.ReadLine()
                    .Split(' ');

            people.Where(p => filter == "younger" ? p.Value < age : p.Value >= age)
                  .ToList()
                  .ForEach(p =>Printer(p, printPattern));
        }
        static void Printer(KeyValuePair<string, int> person, string[] printPattern)
        {
            if (printPattern.Length == 2)
            {
                Console.WriteLine(printPattern[0] == "name" ?
                           $"{person.Key} - {person.Value}" :
                           $"{person.Value} - {person.Key}");
            }
            else
            {
                Console.WriteLine(printPattern[0] == "name" ?
                           $"{person.Key} " :
                           $"{person.Value}");
            }
        }
    }
}
