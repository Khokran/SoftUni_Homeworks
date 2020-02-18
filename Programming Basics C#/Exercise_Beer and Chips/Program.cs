using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Beer_and_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerCount = int.Parse(Console.ReadLine());
            int chipsCount = int.Parse(Console.ReadLine());

            double totalBeerPrice = beerCount * 1.2;
            double chipsPrice = totalBeerPrice * 0.45;
            double totalChipsPrice =  Math.Ceiling(chipsPrice * chipsCount);

            double totalMoneySpent = totalBeerPrice + totalChipsPrice;
            double moneyResult = Math.Abs(budget - totalMoneySpent);

            if (budget >= totalMoneySpent)
            {
                double moneyLeft = budget - totalMoneySpent;
                Console.WriteLine($"{name} bought a snack and has {moneyResult:F2} leva left.");
            }
            else
            {
                double moneyShort = totalMoneySpent - budget;
                Console.WriteLine($"{name} needs {moneyResult:F2} more leva!");
            }

        }
    }
}
