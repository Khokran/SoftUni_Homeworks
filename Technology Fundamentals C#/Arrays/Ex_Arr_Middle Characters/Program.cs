using System;

namespace Ex_Arr_Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int idx = word.Length / 2;

            if (word.Length % 2 == 0) 
            {
                char char1 = word[idx - 1];
                char char2 = word[idx];

                Console.WriteLine(char1.ToString() + char2.ToString());
            }
            else 
            {
                Console.WriteLine(word[idx]);
            }
        }
    }
}
