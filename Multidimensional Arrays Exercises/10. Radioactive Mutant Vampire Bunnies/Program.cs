using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            char[][] matrix = new char[rows][];
            int pRow = 0;
            int pCol = 0;

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];
                string currentRow = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = currentRow[col];
                    if (currentRow[col] == 'P')
                    {
                        pRow = row;
                        pCol = col;
                    }
                }
            }
            string command = Console.ReadLine();

            for (int i = 0; i < command.Length; i++)
            {
                char currentCommand = command[i];
                matrix[pRow][pCol] ='.';
                switch (currentCommand)
                {
                    case 'U': pRow--; break;
                    case 'L': pCol--; break;
                    case 'R': pCol++; break;
                    case 'D': pRow++; break;
                }

                if (IsValid(pRow, pCol, rows, cols) == false)
                {
                    AddBunnies(matrix, rows, cols);
                    PrintMatrix(matrix);
                    switch (currentCommand)
                    {
                        case 'U': pRow++; break;
                        case 'L': pCol++; break;
                        case 'R': pCol--; break;
                        case 'D': pRow--; break;
                    }
                    Console.WriteLine($"won: {pRow} {pCol}");
                    return;
                }
          
                AddBunnies(matrix, rows, cols);

                if (matrix[pRow][pCol] == 'B')
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {pRow} {pCol}");
                    return;
                }
            }   
        }

        private static void AddBunnies(char[][] matrix,int rows,int cols)
        {
            var indexes = new List<string>();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row][col] == 'B')
                        indexes.Add($"{row} {col}"); 
                }
            }

            foreach (var index in indexes)
            {
                int[] ind = index.Split().Select(int.Parse).ToArray();
                int row = ind[0];
                int col = ind[1];

k                if(IsValid(row-1,col,rows,cols))
                {
                    matrix[row - 1][col] = 'B';
                }
                if (IsValid(row,col-1,rows,cols))
                {
                    matrix[row][col-1] = 'B';
                }
                if (IsValid(row,col+1,rows,cols))
                {
                    matrix[row][col+1] = 'B';
                }
                if (IsValid(row+1,col,rows,cols))
                {
                    matrix[row+1][col] = 'B';
                }
            }
        }

        private static void PrintMatrix(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("",row));
            }
        }

        private static bool IsValid(int row, int col, int n,int m)
        {
            if (row >= 0 && row < n && col >= 0 && col < m) return true;
            else return false;
        }
    }
}
