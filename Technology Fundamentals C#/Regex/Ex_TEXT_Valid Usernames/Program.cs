using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_TEXT_Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ").ToArray();
            var validUsername = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string word= words[i];
                bool isValid = false;

                if (word.Length>= 3&& word.Length<=16)
                {
                    for (int k = 0; k < word.Length; k++)
                    {
                        char currChar = word[k];
                        if (char.IsLetterOrDigit(currChar)|| currChar == '-' || currChar == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false; break;
                        }
                    }
                }
                if (isValid) Console.WriteLine(word);
            }
        }
    }
}
