using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_School_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double food1 = double.Parse(Console.ReadLine());
            double food2 = double.Parse(Console.ReadLine());
            double food3 = double.Parse(Console.ReadLine());

            double neededFood = days * (food1 + food2 + food3);

            if (neededFood <= food)
            {
                Console.WriteLine($"{Math.Floor(food - neededFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(neededFood - food)} more kilos of food are needed.");
            }
        }
    }
}
