using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_Inheritance
{
    public class Student : Person
    {
        public Student(string name, string school)
            :base(name, 19)
        {
            this.School = school;
        }
        public Student(string name,int age)
            :base(name, age)
        {
            this.Age = age;
            weight = 80.6f;
        }
        public string School { get; set; }

        protected float weight;

        public void GrowOld()
        {
            Age++;
        }
        public int HowOld() 
        {
            return Age;
        }
        public double GetWeight()
        {
            double weight = 75.8;
            return weight;
        }
        public void PrintWeight()
        {
            Console.WriteLine($"Weight(double): {GetWeight()}");
            Console.WriteLine($"Weight(float): {this.weight}");
            Console.WriteLine($"Weight(int): {base.weight}");
        }
    }
}
