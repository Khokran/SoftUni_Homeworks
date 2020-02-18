using System;
using System.Linq;
using System.Collections.Generic;

namespace SummerCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingredientsValues = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();

            int[] freshnessValues = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            Queue<int> ingredients = new Queue<int>(ingredientsValues);
            Stack<int> freshnessLevel = new Stack<int>(freshnessValues);

            Dictionary<int, string> advancedMaterials = new Dictionary<int, string>()
            {
                { 150,"Mimosa" },
                { 250,"Daiquiri" },
                { 300,"Sunshine" },
                { 400,"Mojito" }
            };
            Dictionary<string, int> cocktailName = new Dictionary<string, int>()
            {
                {"Mimosa", 0 },
                {"Daiquiri", 0 },
                {"Sunshine", 0 },
                {"Mojito", 0 }
            };
            while (ingredients.Count > 0 && freshnessLevel.Count > 0)
            {
                int liquidValue = ingredients.Dequeue();
                int freshValue = freshnessLevel.Peek();
                int sum = liquidValue + freshValue;
                if (advancedMaterials.ContainsKey(sum))
                {
                    freshnessLevel.Pop();
                    string newMaterial = advancedMaterials[sum];

                    if (!cocktailName.ContainsKey(newMaterial))
                    {
                        cocktailName[newMaterial] = 0;
                    }
                    cocktailName[newMaterial]++;
                }
                else
                {
                    freshnessLevel.Pop();
                    freshnessLevel.Push(freshValue + 5);
                }
            }

            bool canBild = true;
            foreach (var part in cocktailName)
            {
                foreach (var item in advancedMaterials)
                {
                    if (part.Value <= 0 && item.Key <= 0)
                    {
                        canBild = false;
                        break;
                    }
                }
            }

            if (canBild)
            {
                Console.WriteLine($"It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }

            if (ingredients.Count <= 0)
            {
                int sum = ingredientsValues.Length + freshnessValues.Length;

                Console.WriteLine($"Ingredients left: {sum}");
            }

            if (freshnessLevel.Count <= 0)
            {
                int sum = ingredientsValues.Length + freshnessValues.Length;

                Console.WriteLine($"Freshness values left: {sum}");
            }

            foreach (var cocktail in cocktailName.OrderBy(p => p.Key))
            {
                if (cocktail.Value > 0)
                {
                    Console.WriteLine($" # {cocktail.Key} --> {cocktail.Value}");
                }
            }
        }
    }
}
