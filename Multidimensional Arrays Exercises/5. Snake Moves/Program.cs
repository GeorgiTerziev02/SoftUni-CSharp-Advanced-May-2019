using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string snake = Console.ReadLine();

            char[,] matrix = new char[rows, cols];

            int k = rows * cols;
            int row = 0;
            int col = 0;

            int symbol = 0;

            while (k != 0)
            {
                if (col < cols)
                {
                    if (symbol < snake.Length)
                    {
                        matrix[row, col] = snake[symbol];
                        k--;
                        col++;
                        symbol++;
                    }
                    else symbol = 0;
                }
                else
                {
                    col = 0;
                    if (row < rows) { row++;}
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
