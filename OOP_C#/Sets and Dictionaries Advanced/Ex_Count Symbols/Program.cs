namespace Ex_Count_Symbols
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var symbolsCount = new SortedDictionary<char, int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (!symbolsCount.ContainsKey(currChar))
                {
                    symbolsCount.Add(currChar,0);
                }
                symbolsCount[currChar]++;
            }
            foreach (var (key, value) in symbolsCount)
            {
                Console.WriteLine($"{key}: {value} time/s");
            }
        }
    }
}
