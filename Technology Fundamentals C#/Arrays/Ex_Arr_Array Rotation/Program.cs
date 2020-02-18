using System;
using System.Linq;

namespace Ex_Arr_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int firstNum = myArray[0];
                for (int j = 0; j < myArray.Length-1; j++)
                {
                    myArray[j] = myArray[j + 1];
                }
                myArray[myArray.Length - 1] = firstNum;
            }
            Console.WriteLine(String.Join(" ",myArray));
        }
    }
}
