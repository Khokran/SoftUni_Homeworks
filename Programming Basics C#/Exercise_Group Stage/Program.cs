using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Group_Stage
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());

            int points = 0;
            int totalGoalsScored = 0;
            int totalGoalsRecieved = 0;

            for (int i = 0; i < gamesPlayed; i++)
            {
                int goalsScored = int.Parse(Console.ReadLine());
                totalGoalsScored += goalsScored;
                int goalsRecieved = int.Parse(Console.ReadLine());
                totalGoalsRecieved += goalsRecieved;

                if (goalsScored > goalsRecieved)
                {
                    points += 3;
                }
                else if (goalsScored == goalsRecieved)
                {
                    points += 1;
                }
            }
            if (totalGoalsScored > totalGoalsRecieved)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {totalGoalsScored - totalGoalsRecieved}.");

                // Console.WriteLine($"{teamName} has finished the group phase with {finalScore} points." +
                //                   $"\nGoal difference: {scoredGoals - recievedGoals}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {totalGoalsScored - totalGoalsRecieved}.");

               // Console.WriteLine($"{teamName} has been eliminated from the group phase." +
               //                   $"\nGoal difference: {scoredGoals - recievedGoals}.");
            }
        }
    }
}
