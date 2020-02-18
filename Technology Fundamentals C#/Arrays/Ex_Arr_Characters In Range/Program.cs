using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersInRange
{
    class Program
    {

        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            PrintSingleLineOfChars(start, end);
        }

        private static void PrintSingleLineOfChars(char start, char end)
        {
            if (end < start)   
            {                            
                char temp = start;
                start = end;
                end = temp;
            }
            for (char i = (char)(start + 1); i < end; i++)  
            {
                Console.Write(i + " ");
            }
        }
    }
}
