using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_List_Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> listOfArrays = input.Split('|').ToList();
            List<string> output = new List<string>();

            for (int i = listOfArrays.Count-1; i >= 0; i--)
            {
                char[] separator = new char[] { ' ' };
                string[] tempArray = listOfArrays[i].Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int k = 0; k < tempArray.Length; k++)
                {
                    output.Add(tempArray[k]);
                }
            }
            Console.WriteLine(string.Join(' ', output));            
        }
    }
}
