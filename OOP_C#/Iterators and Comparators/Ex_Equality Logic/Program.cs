using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_EqualityLogic
{
    public class Program
    {
        public static void Main()
        {
            var hashSet = new HashSet<Person>();
            var sortedSet = new SortedSet<Person>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                var person = new Person(name, age);

                Console.WriteLine(person.GetHashCode());

                hashSet.Add(person);
                sortedSet.Add(person);

                Console.WriteLine(hashSet.Count);
                Console.WriteLine(sortedSet.Count);
            }
        }
    }
}
