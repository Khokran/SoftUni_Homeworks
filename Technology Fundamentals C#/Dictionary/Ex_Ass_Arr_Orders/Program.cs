using System;
using System.Collections.Generic;

namespace Ex_Ass_Arr_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var collections = new Dictionary<string, double[]>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] order = input.Split();

                string product = order[0];
                double price = double.Parse(order[1]);
                double quantity = double.Parse(order[2]);

                if (!collections.ContainsKey(product))
                {
                    collections.Add(product, new double[2]);
                }
                collections[product][0] = price;
                collections[product][1] += quantity;
            }
            foreach (var products in collections)
            {
                Console.WriteLine($"{products.Key} -> {(products.Value[0] * products.Value[1]):F2}");
            }
        }
    }
}
