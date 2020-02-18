using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int max = int.MinValue;
            int min = int.MaxValue;

            while (true)
            {
                if(command == "END")
                {
                    Console.WriteLine("Max number: " + max);
                    Console.WriteLine("Min number: " + min);
                    break;
                }
                int num = int.Parse(command);
                if (max < num)
                {
                    max = num;
                }
                if(min >num)
                {
                    min = num;
                }
                command = Console.ReadLine();
            }


        }
    }
}
