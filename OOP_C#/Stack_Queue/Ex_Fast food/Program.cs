using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_FastFood
{
    public class Program
    {
        private static void Main()
        {
            int quantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Console.WriteLine(orders.Max());   //Най-голямата поръчка!!!!!!!!!!!

            while (orders.Count != 0)
            {
                int currentOrder = orders.Peek();

                if (currentOrder <= quantity)
                {
                    quantity -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(orders.Count == 0 ? "Orders complete" : $"Orders left: {string.Join(" ", orders)}");
        }
    }
}