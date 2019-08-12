using System;
using System.Linq;

namespace multidimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int leftToRight = 0;

            for (int i = 0; i < n; i++)
            {
                leftToRight += matrix[i, i];
            }

            int rightToLeft = 0;

            for (int i = 0; i < n; i++)
            {
                rightToLeft += matrix[i, n - i - 1];
            }

            Console.WriteLine(Math.Abs(leftToRight-rightToLeft));
        }
    }
}
