using System;
using System.Linq;

namespace _7.__Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];
            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                matrix[row] = new char[n];
                for (int col = 0; col < n; col++)
                {
                    matrix[row][col] = currentRow[col];
                }
            }
            int removedHorses = 0;

            while (true)
            {
                int knightRow = -1;
                int knightCol = -1;
                int maxAttacked = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row][col]=='K')
                        {
                            int tempAttack = CountAttacls(matrix, row, col);
                            if (tempAttack > maxAttacked)
                            {
                                maxAttacked = tempAttack;
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }
                }
                if (maxAttacked>0)
                {
                    matrix[knightRow][knightCol] = '0';
                    removedHorses++;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine(removedHorses);

        }

        private static int CountAttacls(char[][] matrix, int row, int col)
        {
            int attacks = 0;
            if (IsInMatrix(row-1, col-2, matrix.Length) && matrix[row - 1][col - 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row-1, col+2, matrix.Length) && matrix[row - 1][col + 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row+1, col-2, matrix.Length) && matrix[row + 1][col - 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row+1, col+2, matrix.Length) && matrix[row + 1][col + 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row-2, col-1, matrix.Length) && matrix[row - 2][col - 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row-2, col+1, matrix.Length) && matrix[row - 2][col + 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row+2, col-1, matrix.Length) && matrix[row + 2][col - 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row+2, col+1, matrix.Length) && matrix[row + 2][col + 1] == 'K')
            {
                attacks++;
            }
            return attacks;
        }

        private static bool IsInMatrix(int row, int col, int length)
        {
            return row >= 0 && row < length && col >= 0 && col < length;
        }
    }
}
