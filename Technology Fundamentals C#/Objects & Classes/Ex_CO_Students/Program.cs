using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_CO_Students
{
    class Program
    {
        class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> listOfStudents = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split().ToArray();

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                Students student = new Students(){FirstName = firstName, LastName = lastName, Grade = grade};

                listOfStudents.Add(student);
            }

            listOfStudents = listOfStudents.OrderByDescending(x => x.Grade).ToList();

            foreach (var student in listOfStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
}
