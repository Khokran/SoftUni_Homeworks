using System;
using System.Text;

namespace Ex_TEXT_Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();

            foreach (var symbol in input)
            {
                char encryptedSymbol = (char)(symbol + 3);
                sb.Append(encryptedSymbol);
            }
            Console.WriteLine(sb);
        }
    }
}
