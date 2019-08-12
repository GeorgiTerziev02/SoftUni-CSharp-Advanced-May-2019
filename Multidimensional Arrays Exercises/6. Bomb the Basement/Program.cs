using System;
using System.Linq;

namespace _6._Bomb_the_Basement
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
                //0 is default value
            }

            int[] bomb = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombRow = bomb[0];
            int bombCol = bomb[1];
            int radius = bomb[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2));
                    //Pythagorean theorem
                    //to find the distance from the bomb cel
                    if (distance<=radius)
                    {
                        matrix[row][col] = 1;
                    }
                }
            }

            int[][] secondMatrix = new int[cols][];

            for (int row = 0; row < cols; row++)
            {
                secondMatrix[row] = new int[rows];
                for (int col = 0; col < rows; col++)
                {
                    secondMatrix[row][col] = matrix[col][row];
                }
                secondMatrix[row]=secondMatrix[row].OrderByDescending(x => x).ToArray();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = secondMatrix[col][row];
                }              
            }

            Console.WriteLine(String.Join(Environment.NewLine, matrix.Select(r=>string.Join("",r))));
        }
    }
}
