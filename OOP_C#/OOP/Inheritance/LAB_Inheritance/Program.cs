using System;

namespace LAB_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            var student= new Student("Pesho", 19);
            Console.WriteLine(student.HowOld());
            student.GrowOld();
            Console.WriteLine(student.HowOld());

            student.PrintWeight();
        }
    }
}
