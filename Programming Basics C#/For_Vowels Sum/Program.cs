﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                switch (letter)
                {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;

                }
            }
            Console.WriteLine($"Sum: {sum}");





        }
    }
}
