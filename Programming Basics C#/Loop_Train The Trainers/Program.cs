using System;
using System.Linq;

namespace NestedLoopsExercises
{
    class Program
    {
        static void Main()
        {
            int judges = int.Parse(Console.ReadLine());
            string presentName = string.Empty;

            double currPresentGrade = 0;
            double totalGradeSum = 0;
            int gradesCount = 0;

            while ((presentName = Console.ReadLine()) != "Finish")
            {
                currPresentGrade = 0;
                for (int i = 0; i < judges; i++)
                {
                    currPresentGrade += double.Parse(Console.ReadLine());
                    gradesCount++;
                }
                totalGradeSum += currPresentGrade;
                double averageGradeSum = currPresentGrade / judges;
                Console.WriteLine($"{presentName} - {averageGradeSum:f2}.");
            }
            Console.WriteLine($"Student's final assessment is {totalGradeSum / gradesCount:F2}.");
        }
    }
}
