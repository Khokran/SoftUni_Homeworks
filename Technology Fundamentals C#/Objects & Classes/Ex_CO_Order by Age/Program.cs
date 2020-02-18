using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_CO_Order_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string lines = Console.ReadLine();
            List<Person> persons = new List<Person>();

            while (lines != "End")
            {
                string[] line = lines.Split();
                string name = line[0];
                string id = line[1];
                int age = int.Parse(line[2]);

                Person person = new Person { Name = name, ID = id, Age = age };
                persons.Add(person);
                lines = Console.ReadLine();
            }
            foreach (Person person in persons.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
