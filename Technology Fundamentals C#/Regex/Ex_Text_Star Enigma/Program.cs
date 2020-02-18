using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex_Text_Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();

                int counter = 0;
                string encryptedMessages = string.Empty;

                for (int j = 0; j < message.Length; j++)
                {
                    char currChar = message[j];

                    if (currChar == 's' || currChar == 't' || currChar == 'a' || currChar == 'r'
                        || currChar == 'S' || currChar == 'T' || currChar == 'A' || currChar == 'R')
                    {
                        counter++;
                    }
                }
                for (int j = 0; j < message.Length; j++)
                {
                    char character = (char)(message[j] - counter);
                    encryptedMessages += character.ToString();
                }
                string pattern = $"@(?<name>[A-Za-z]+)([^@:!\\->]*):(?<population>[0-9]+)([^@:!\\->]*)!(?<type>(A|D))!([^@:!\\->]*)->(?<count>[0-9]+)";

                Match match = Regex.Match(encryptedMessages, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    var type = match.Groups["type"].Value;

                    if (type == "A")
                    {
                        attackedPlanets.Add(name);
                    }
                    else
                    {
                        destroyedPlanets.Add(name);
                    }
                }
            }
            int sumAttacked = attackedPlanets.Count;
            int sumDestroyed = destroyedPlanets.Count;

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
