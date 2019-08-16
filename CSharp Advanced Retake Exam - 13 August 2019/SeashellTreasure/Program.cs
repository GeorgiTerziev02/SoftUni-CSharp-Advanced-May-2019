using System;
using System.Collections.Generic;
using System.Linq;

namespace SeashellTreasure
{
    class Program
    {
        static void Main(string[] args)
        {
            int stolenShells = 0;
            List<char> collectedShells = new List<char>();

            int rows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                matrix[row] = new char[currentRow.Length];
                matrix[row] = currentRow;
            }

            string command = Console.ReadLine();

            while (command != "Sunset")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Collect")
                {
                    int row = int.Parse(commandArgs[1]);
                    int col = int.Parse(commandArgs[2]);

                    if (IsInMatrix(matrix, row, col))
                    {
                        if (matrix[row][col] != '-')
                        {
                            collectedShells.Add(matrix[row][col]);
                            matrix[row][col] = '-';
                        }
                    }
                }
                else if (commandArgs[0] == "Steal")
                {
                    int row = int.Parse(commandArgs[1]);
                    int col = int.Parse(commandArgs[2]);
                    string direction = commandArgs[3];

                    if (IsInMatrix(matrix, row, col))
                    {
                        if (matrix[row][col] != '-')
                        {
                            matrix[row][col] = '-';
                            stolenShells++;
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            switch (direction)
                            {
                                case "up": row--; break;
                                case "down": row++; break;
                                case "right": col++; break;
                                case "left": col--; break;
                            }

                            if (IsInMatrix(matrix, row, col))
                            {
                                if (matrix[row][col]!='-')
                                {
                                    matrix[row][col] = '-';
                                    stolenShells++;
                                }
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            PrintMatrix(matrix);

            if (collectedShells.Count > 0)
            {
                Console.WriteLine($"Collected seashells: {collectedShells.Count}" + " -> " + string.Join(", ", collectedShells));
            }
            else
            {
                Console.WriteLine($"Collected seashells: {collectedShells.Count}");
            }

            Console.WriteLine($"Stolen seashells: {stolenShells}");
        }

        private static void PrintMatrix(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static bool IsInMatrix(char[][] matrix, int row, int col)
        {
            if (matrix.GetLength(0) <= row || row < 0)
            {
                return false;
            }

            if (matrix[row].Length <= col || col < 0)
            {
                return false;
            }

            return true;
        }
    }
}
