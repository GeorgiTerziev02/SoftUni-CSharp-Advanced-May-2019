using System;

namespace _5._1_Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordinates = Console.ReadLine().Split();
            int rows = int.Parse(coordinates[0]);
            int cols = int.Parse(coordinates[1]);

            char[,] matrix = new char[rows, cols];
            string input = Console.ReadLine();

            int k = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (k < input.Length)
                    {
                        matrix[row, col] = input[k];
                        k++;
                    }
                    else
                    {
                        matrix[row, col] = input[0];
                        k = 1;
                    }
                }
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    Console.Write(matrix[row, i]);
                }
                Console.WriteLine();
            }
        }
    }
}
