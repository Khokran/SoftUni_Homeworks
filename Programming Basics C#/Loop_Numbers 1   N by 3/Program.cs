using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Numbers_1___N_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int currNumber = 1; currNumber <= number; currNumber += 3)
            {
                Console.WriteLine(currNumber);
            }
        }
    }
}
