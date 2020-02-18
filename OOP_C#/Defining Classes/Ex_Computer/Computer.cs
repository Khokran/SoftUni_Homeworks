using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Computer
    {
        private string make;

        public Computer()
        {
            this.Make = "n/a";
        }
        public Computer(string make)
        {
            this.Make = make;
        }
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public override string ToString()
        {
            return $"{this.Make}"; 
        }
    }
}
