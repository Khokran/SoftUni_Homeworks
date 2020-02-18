namespace Ex_The_V_Logger
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var vloggerColection = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                if (input.Contains("joined"))
                {
                    string username = input.Split()[0];
                    if (!vloggerColection.ContainsKey(username))
                    {
                        vloggerColection.Add(username, new Dictionary<string, HashSet<string>>());
                        vloggerColection[username].Add("followings", new HashSet<string>());
                        vloggerColection[username].Add("followers", new HashSet<string>());
                    }
                }
                else if (input.Contains("followed"))
                {
                    string[] usernames = input.Split();
                    string firstVlogger = usernames[0];
                    string secondVlogger = usernames[2];

                    if (!vloggerColection.ContainsKey(firstVlogger) ||
                        !vloggerColection.ContainsKey(secondVlogger) ||
                        firstVlogger == secondVlogger)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    vloggerColection[firstVlogger]["followings"].Add(secondVlogger);
                    vloggerColection[secondVlogger]["followers"].Add(firstVlogger);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggerColection.Count} vloggers in its logs.");
            int count = 1;

            var sortedVloggers = vloggerColection
                .OrderByDescending(f => f.Value["followers"].Count)
                .ThenBy(f => f.Value["followings"].Count)
                .ToDictionary(k => k.Key, y => y.Value);

            foreach (var (username, value) in sortedVloggers)
            {
                int followersCount = sortedVloggers[username]["followers"].Count;
                int followingsCount = sortedVloggers[username]["followings"].Count;

                Console.WriteLine($"{count}. {username} : {followersCount} followers, {followingsCount} following");

                if (count == 1)
                {
                    var followersCollection = value["followers"].OrderBy(x => x).ToList();
                    foreach (var currUsername in followersCollection)
                    {
                        Console.WriteLine($"*  {currUsername}");
                    }
                }
                count++;
            }
        }
    }
}
