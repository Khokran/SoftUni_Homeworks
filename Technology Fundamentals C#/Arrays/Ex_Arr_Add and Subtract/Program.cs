using System;

namespace Ex_Arr_Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = SumFirstAndSecondNumber(firstNum, secondNum);

            Console.WriteLine(Subtrack(sum, thirdNum));
        }

        private static int Subtrack(int sum, int thirdNum)
        {
            return sum - thirdNum;
        }

        private static int SumFirstAndSecondNumber(int firstNum, int secondNum)
        {
            int sumFirstAndSecondNumber = firstNum + secondNum;
            return sumFirstAndSecondNumber;
        }
    }
}
