using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_SingleInheritance
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Bau, Bau!");
        }
        public override string ToString()
        {
            return "I'm a dog";
        }
    }
}
