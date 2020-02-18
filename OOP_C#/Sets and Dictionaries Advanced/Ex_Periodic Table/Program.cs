namespace Ex_Periodic_Table
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var elements = new SortedSet<string>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in size)
                {
                    elements.Add(item);
                }
            }
            foreach (var item in elements)
            {
                if (elements.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
