using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            decimal budget = decimal.Parse(Console.ReadLine());

            do
            {
                while (!(budget <= 0))
                {
                    decimal saving = decimal.Parse(Console.ReadLine());
                    budget -= saving;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                budget = decimal.Parse(Console.ReadLine());

            } while (true);
        }
    }
}
