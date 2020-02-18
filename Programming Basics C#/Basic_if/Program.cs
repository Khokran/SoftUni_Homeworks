using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_if
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = Console.ReadLine();

            if (color == "red")
            {
                Console.WriteLine("tomato");
            }
            else if (color == "green")
            {
                Console.WriteLine("apple");
            }
            else if (color == "yellow")
            {
                Console.WriteLine("banana");
            }

        }
    }
}