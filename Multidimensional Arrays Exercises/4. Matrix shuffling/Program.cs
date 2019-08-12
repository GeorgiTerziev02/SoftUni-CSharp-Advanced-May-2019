using System;
using System.Linq;

namespace _4._Matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordinates = Console.ReadLine().Split();
            int rows = int.Parse(coordinates[0]);
            int cols = int.Parse(coordinates[1]);
            string[][] matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                matrix[row] = currentRow;
            }

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] currentCommand = command.Split();

                if (currentCommand.Length == 5 && currentCommand[0].ToLower() == "swap")
                {
                    int row1 = int.Parse(currentCommand[1]);
                    int col1 = int.Parse(currentCommand[2]);
                    int row2 = int.Parse(currentCommand[3]);
                    int col2 = int.Parse(currentCommand[4]);

                    if (IsValid(row1, col1, rows, cols) && IsValid(row2, col2, rows, cols))
                    {
                        string toSwap = matrix[row1][col1];

                        matrix[row1][col1] = matrix[row2][col2];
                        matrix[row2][col2] = toSwap;

                        PrintMatrix(matrix);

                    }
                    else Console.WriteLine("Invalid input!");

                }
                else Console.WriteLine("Invalid input!");

                command = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }

        private static bool IsValid(int row, int col, int rows, int cols)
        {
            if (row >= 0 && row < rows && col >= 0 && col < cols) return true;
            else return false;
        }
    }
}
