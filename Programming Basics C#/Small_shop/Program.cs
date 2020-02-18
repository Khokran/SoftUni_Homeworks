using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double productFinalPrice = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    productFinalPrice = quantity * 0.5;
                    Console.WriteLine(productFinalPrice);
                }
                else if (product == "water")
                {
                    productFinalPrice = quantity * 0.8;
                    Console.WriteLine(productFinalPrice);
                }

                else if (product == "beer")
                {
                    productFinalPrice = quantity * 1.2;
                    Console.WriteLine(productFinalPrice);
                }

                else if (product == "sweets")
                {
                    productFinalPrice = quantity * 1.45;
                    Console.WriteLine(productFinalPrice);
                }

                else if (product == "peanuts")
                {
                    productFinalPrice = quantity * 1.6;
                    Console.WriteLine(productFinalPrice);
                }
            }
            if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    productFinalPrice = quantity * 0.4;
                    Console.WriteLine(productFinalPrice);
                }
                else if (product == "water")
                {
                    productFinalPrice = quantity * 0.7;
                    Console.WriteLine(productFinalPrice);
                }

                else if (product == "beer")
                {
                    productFinalPrice = quantity * 1.15;
                    Console.WriteLine(productFinalPrice);
                }

                else if (product == "sweets")
                {
                    productFinalPrice = quantity * 1.3;
                    Console.WriteLine(productFinalPrice);
                }

                else if (product == "peanuts")
                {
                    productFinalPrice = quantity * 1.5;
                    Console.WriteLine(productFinalPrice);
                }
            }
            if (town == "Varna")
            {
                if (product == "coffee")
                {
                    productFinalPrice = quantity * 0.45;
                    Console.WriteLine(productFinalPrice);
                }
                else if (product == "water")
                {
                    productFinalPrice = quantity * 0.7;
                    Console.WriteLine(productFinalPrice);
                }

                else if (product == "beer")
                {
                    productFinalPrice = quantity * 1.1;
                    Console.WriteLine(productFinalPrice);
                }

                else if (product == "sweets")
                {
                    productFinalPrice = quantity * 1.35;
                    Console.WriteLine(productFinalPrice);
                }

                else if (product == "peanuts")
                {
                    productFinalPrice = quantity * 1.55;
                    Console.WriteLine(productFinalPrice);
                }

            }

        }
    }
}

