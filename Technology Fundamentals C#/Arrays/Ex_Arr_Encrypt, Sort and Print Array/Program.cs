using System;
using System.Linq;

namespace Ex_Arr_Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] sings = new int[number];

            string vowels = "aAeEiIoOuU";
            char[] vowelsArr = vowels.ToCharArray();

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                char[] letters = name.ToCharArray();

                int sum = 0;
                for (int j = 0; j < letters.Length; j++)
                {
                    char currentChar = letters[j];
                    if (vowelsArr.Contains(currentChar))
                    {
                        sum += letters[j] * letters.Length;
                    }
                    else
                    {
                        sum += letters[j] / letters.Length;
                    }
                }
                sings[i] = sum;
            }

            Array.Sort(sings);

            foreach (var element in sings)
            {
                Console.WriteLine($"{element}");
            }
        }
    }
}
