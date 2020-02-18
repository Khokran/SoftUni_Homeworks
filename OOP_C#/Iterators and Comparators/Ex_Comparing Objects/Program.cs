using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_ComparingObjects
{
    public class Program
    {
        static void Main()
        {
            var people = new List<Person>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = Console.ReadLine().Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                var person = new Person(name, age, town);
                people.Add(person);

                input = Console.ReadLine();
            }
            int n = int.Parse(Console.ReadLine());

            int countOfMatches = 1;
            int countOfNotEqualMatches = 0;

            Person targetPerson = people[n - 1];

            foreach (var item in people)
            {
                if (item == targetPerson)
                {
                    continue;
                }
                if (item.CompareTo(targetPerson) == 0)
                {
                    countOfMatches++;
                }
                else
                {
                    countOfNotEqualMatches++;
                }
            }
            if (countOfMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {countOfNotEqualMatches} {people.Count}");
            }
        }
    }
}
