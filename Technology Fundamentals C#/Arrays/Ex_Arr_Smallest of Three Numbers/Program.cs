using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Arr_Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintSmallestNumber(firstNumber, secondNumber, thirdNumber));
        }
        static int PrintSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber < secondNumber && firstNumber < thirdNumber) return (firstNumber);
            else if (secondNumber < firstNumber && secondNumber < thirdNumber) return (secondNumber);
            else return (thirdNumber); 
        }
    }
}
