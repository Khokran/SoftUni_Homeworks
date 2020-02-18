namespace Product_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();
            var entry = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (entry[0] != "Revision")
            {
                if (!shops.ContainsKey(entry[0]))
                {
                    shops.Add(entry[0], new Dictionary<string, double>());
                }
                if (!shops[entry[0]].ContainsKey(entry[0]))
                {
                    shops[entry[0]].Add(entry[1], 0);
                }
                shops[entry[0]][entry[1]] = Double.Parse(entry[2]);
                entry = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
