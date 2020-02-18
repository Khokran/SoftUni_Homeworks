namespace Ex_Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var warderobe = new Dictionary<string, Dictionary<string, int>>();
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] inputArgs = Console.ReadLine().Split(" -> ");
                string color = inputArgs[0];
                if (!warderobe.ContainsKey(color))
                {
                    warderobe.Add(color, new Dictionary<string, int>());
                }
                string[] clothes = inputArgs[1].Split(',');
                foreach (var cloth in clothes)
                {
                    if (!warderobe[color].ContainsKey(cloth))
                    {
                        warderobe[color].Add(cloth, 0);
                    }
                    warderobe[color][cloth]++;
                }
            }
            string[] targetClothInfo = Console.ReadLine().Split();
            string targetColor = targetClothInfo[0];
            string targetCloth = targetClothInfo[1];
            foreach (var (color, clothes) in warderobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var (cloth,count) in clothes)
                {
                   string result = $"* {cloth} - {count}";
                    if (color==targetColor&&targetCloth ==cloth)
                    {
                        result += " (found!)";
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}
