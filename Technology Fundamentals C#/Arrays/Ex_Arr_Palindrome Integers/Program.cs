using System;

namespace Ex_Arr_Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(GetBool(input).ToString().ToLower());
                }
            }
        }
        private static bool GetBool(string a)
        {
            bool isPalindrome = false;
            if (a.Length == 1)
            {
                isPalindrome = true;
                return isPalindrome;
            }
            for (int i = 0; i < a.Length / 2; i++)
            {
                for (int j = a.Length - 1 - i; j >= a.Length / 2; j--)
                {
                    if (a[i] == a[j])
                    {
                        isPalindrome = true;
                        j--;
                        break;
                    }
                    else
                    {
                        isPalindrome = false;
                        return isPalindrome;
                    }
                }
            }
            return isPalindrome;
        }
    }
}
