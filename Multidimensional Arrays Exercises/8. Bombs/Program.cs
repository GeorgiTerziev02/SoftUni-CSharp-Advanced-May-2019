using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int row = 0; row < n; row++)
            {
                matrix[row] = new int[n];
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = currentRow;
            }
            string[] bomb = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < bomb.Length; i++)
            {
                int[] coordinates = bomb[i].Split(",").Select(int.Parse).ToArray();
                int row = coordinates[0];
                int col = coordinates[1];
                
                int damage = matrix[row][col];
                if (damage > 0)
                {
                 if (IsValid(row - 1, col - 1, matrix,n)) matrix[row - 1][col - 1] -= damage;
                 if (IsValid(row - 1, col , matrix,n)) matrix[row - 1][col] -= damage;
                 if (IsValid(row - 1, col + 1, matrix,n)) matrix[row - 1][col + 1] -= damage;
                 if (IsValid(row , col - 1, matrix,n)) matrix[row][col - 1] -= damage;
                 if (IsValid(row , col + 1, matrix,n)) matrix[row][col + 1] -= damage;
                 if (IsValid(row + 1, col - 1, matrix,n)) matrix[row + 1][col - 1] -= damage;
                 if (IsValid(row + 1, col , matrix,n)) matrix[row + 1][col] -= damage;
                 if (IsValid(row + 1, col + 1, matrix,n)) matrix[row + 1][col + 1] -= damage;
                    matrix[row][col] = 0;
                }         
            }

            int alive = 0;
            int sum = 0;

            for (int row = 0; row< n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row][col] > 0) { alive++; sum += matrix[row][col]; }
                }
            }

            Console.WriteLine($"Alive cells: {alive}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row][col]+" ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsValid(int row, int col, int[][] matrix, int n)
        {
            if (row >= 0 && row < n && col >= 0 && col < n && matrix[row][col]>0) return true;
            else return false;         
        }
    }
}
