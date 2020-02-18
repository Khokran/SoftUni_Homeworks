using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_SingleInheritance
{
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.Beep(5000, 800);
        }
        //public void Bark()
        //{
        //    if (Age < 12)
        //    {
        //        Weep();
        //    }
        //    else
        //    {
        //        base.Bark();
        //    }
        //}
        public Puppy(int age)
        {
            Age = age;
        }

        public int Age { get; set; }
        public override string ToString()
        {
            return $"Puppy by the age of {Age}";
        }
    }
}
