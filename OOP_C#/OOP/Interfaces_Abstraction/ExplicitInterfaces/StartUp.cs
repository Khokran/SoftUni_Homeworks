using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            while (input[0].ToLower() != "end")
            {
                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                Citizen citizen = new Citizen(name, country, age);

                IPerson person = citizen as IPerson;
                Console.WriteLine(person.GetName());

                IResident resident = citizen as IResident;
                Console.WriteLine(resident.GetName());

                input = Console.ReadLine()
                .Split();
            }
        }
    }
}