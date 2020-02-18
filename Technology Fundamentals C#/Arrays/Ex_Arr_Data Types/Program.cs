using System;

namespace Ex_Arr_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            bool isInteger = int.TryParse(input, out int integer);
            bool isDouble = double.TryParse(input, out double floating);

            if (isInteger)
            {
                Console.WriteLine($"{number*2}");
            }
            else if (isDouble)
            {
                Console.WriteLine($"{number * 1.5:f2}");
            }
            else if (input == "real")
            {
                Console.WriteLine("$" + input + "$");
            }
        }
    }
}
