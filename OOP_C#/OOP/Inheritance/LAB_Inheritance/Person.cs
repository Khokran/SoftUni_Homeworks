using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_Inheritance
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            weight = 80;
        }
        public Person(int age)
        {
            this.Age = age;
        }
        public string Name { get; set; }
        protected int Age { get; set; }
        public string Address { get; set; }
        protected int weight;

    }
}
