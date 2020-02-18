using System;

namespace Ex_Arr_Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            VowelsCount();
        }

        static void VowelsCount()
        {
            string word = Console.ReadLine().ToLower();

            var letters = new string[] {"a", "e", "o", "u", "i", "y"};
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (word[i].ToString().Contains(letters[j]))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
