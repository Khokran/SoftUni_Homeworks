using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batch = int.Parse(Console.ReadLine());
            bool isFlourPresent = false;
            bool areEggsPresent = false;
            bool isSugarPresent = false;
            int successfulBake = 0;

            while (successfulBake < batch)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (ingredient == "flour")
                {
                    isFlourPresent = true;
                }
                else if (ingredient == "eggs")
                {
                    areEggsPresent = true;
                }
                else if (ingredient == "sugar")
                {
                    isSugarPresent = true;
                }

                else if (ingredient == "bake!")
                {
                    if (isFlourPresent && areEggsPresent && isSugarPresent)
                    {
                        successfulBake++;
                        Console.WriteLine($"Baking batch number {successfulBake}...");
                        isFlourPresent = false;
                        areEggsPresent = false;
                        isSugarPresent = false;
                    }
                    else
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    }
                }
            }
        }
    }
}