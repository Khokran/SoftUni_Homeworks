using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_Predicated_Party
{
    class Predicated_Party
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine()
                        .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandItems = command
                        .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                string condition = commandItems[2];

                Func<string, bool> filter;

                switch (commandItems[0])
                {
                    case "Remove" when commandItems[1] == "StartsWith":
                        filter = x => !x.StartsWith(condition);
                        break;

                    case "Remove" when commandItems[1] == "EndsWith":
                        filter = x => !x.EndsWith(condition);
                        break;

                    case "Remove":
                        filter = x => x.Length != int.Parse(condition);
                        break;

                    case "Double" when commandItems[1] == "StartsWith":
                        filter = x => x.StartsWith(condition);
                        break;

                    case "Double" when commandItems[1] == "EndsWith":
                        filter = x => x.EndsWith(condition);
                        break;

                    default:
                        filter = x => x.Length == int.Parse(condition);
                        break;
                }
                if (commandItems[0] == "Remove")
                {
                    guests = guests.Where(filter).ToList();
                }
                else
                {
                    var tempList = guests.Where(filter).ToList();

                    foreach (var name in tempList)
                    {
                        var index = guests.IndexOf(name);
                        guests.Insert(index, name);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(guests.Any()
                ? $"{String.Join(", ", guests)} are going to the party!"
                : "Nobody is going to the party!");
        }
    }
}
