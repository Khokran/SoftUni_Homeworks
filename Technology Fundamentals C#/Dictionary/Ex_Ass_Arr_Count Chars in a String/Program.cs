using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_Ass_Arr_Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> first = Console.ReadLine().Split().ToList();

            if (first.Count > 1) Merge(first);

            char[] word = first[0].ToCharArray();
            var numberChar = new Dictionary<char, int>();

            foreach (var kvp in word)
            {
                if (!numberChar.ContainsKey(kvp)) numberChar[kvp] = 0; numberChar[kvp]++;              
            }
            foreach (var kvp in numberChar)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
        public static void Merge(List<string> first)
        {
            var currentWord = new StringBuilder();

            for (int i = 0; i < first.Count; i++)
            {
                currentWord.Append(first[i]);
            }
            first.RemoveRange(0, first.Count - 1);
            first.Insert(0, currentWord.ToString());
        }
    }
}
