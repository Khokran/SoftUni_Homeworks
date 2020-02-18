using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Exam_Toy_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int carsCount = int.Parse(Console.ReadLine());

            double puzzle = 2.60;
            double doll = 3;
            double bear = 4.10;
            double minion = 8.20;
            double car = 2;

            double Sum = (puzzlesCount * puzzle) + (dollsCount * doll) + (bearCount * bear) + (minionsCount * minion) + (carsCount * car);
            double toysCount = puzzlesCount + dollsCount + bearCount + minionsCount + carsCount;


            if(toysCount >= 50)
            {
                Sum = (1 - 0.25) * Sum;
            }

            Sum = (1 - 0.10) * Sum;

            if (Sum >= price)
            {
                double leftMoney = Sum - price;
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }
            else 
            { 
                double neededMoney = price - Sum;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
        }
    }
}
