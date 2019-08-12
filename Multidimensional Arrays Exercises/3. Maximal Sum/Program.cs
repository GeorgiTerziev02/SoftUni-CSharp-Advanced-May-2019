using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[][] matrix = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
                int[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[row] = currentRow;
            }

            int max =int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;

            for(int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int sum = matrix[row][col]
                        + matrix[row + 1][col]
                        + matrix[row + 2][col]
                        + matrix[row][col + 1]
                        + matrix[row][col + 2]
                        + matrix[row + 1][col + 1]
                        + matrix[row + 1][col + 2]
                        + matrix[row + 2][col + 1]
                        + matrix[row+2][col + 2];

                    if (sum > max)
                    {
                        max = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {max}");
        
            for (int row=rowIndex; row < rowIndex+3; row++)
            {
                for (int col = colIndex; col < colIndex+3; col++)
                {
                    Console.Write(matrix[row][col]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
