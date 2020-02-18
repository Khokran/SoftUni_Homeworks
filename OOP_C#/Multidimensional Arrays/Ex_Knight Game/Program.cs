namespace Ex_Knight_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[,] board = new char[rows, rows];

            int[] indexes = new int[]
            {
                1, 2,
                1,-2,
               -1, 2,
               -1,-2,
                2, 1,
                2,-1,
               -2, 1,
               -2,-1
            };

            for (int row = 0; row < rows; row++)
            {
                char[] inputRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < rows; col++)
                {
                    board[row, col] = inputRow[col];
                }
            }
            int counter = 0;
            while (true)
            {
                int maxCount = 0;
                int knightRow = 0;
                int knightCol = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int currCount = 0;

                        if (board[row, col] == 'K')
                        {
                            for (int i = 0; i < indexes.Length; i += 2)
                            {
                                if (isInside(board, row + indexes[i], col + indexes[i + 1]) && 
                                              board[row + indexes[i], col + indexes[i + 1]] == 'K')
                                {
                                    currCount++;
                                }
                            }
                        }
                        if (currCount > maxCount)
                        {
                            maxCount = currCount;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }
                if (maxCount == 0)
                {
                    break;
                }
                board[knightRow, knightCol] = 'O';
                counter++;
            }
            Console.WriteLine(counter);
        }

        private static bool isInside(char[,] board, int desiredRow, int desiredCol)
        {
            return desiredRow < board.GetLength(0) && desiredRow >= 0 &&
                   desiredCol < board.GetLength(1) && desiredCol >= 0;
        }
    }
}
