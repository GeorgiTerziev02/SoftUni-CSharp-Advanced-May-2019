using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[][] matrix = new char[rows][];
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];
                char[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                matrix[row] = currentRow;
            }

            int counter = 0;

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col <cols- 1; col++)
                {
                    if (matrix[row][col] == matrix[row][col + 1] 
                        && matrix[row + 1][col] == matrix[row + 1][col + 1] 
                        && matrix[row][col] == matrix[row + 1][col + 1])
                    {
                        counter++;
                    }
                }

            }

            Console.WriteLine(counter);    
        }
    }
}
