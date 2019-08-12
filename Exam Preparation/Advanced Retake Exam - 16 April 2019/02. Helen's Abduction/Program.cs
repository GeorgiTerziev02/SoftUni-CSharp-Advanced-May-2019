using System;
using System.Linq;

namespace _02._Helen_s_Abduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            int pRow = -1;
            int pCol = -1;

            for (int i = 0; i < n; i++)
            {
                string currentRow = Console.ReadLine();

                matrix[i] = new char[n];

                for (int j = 0; j < currentRow.Length; j++)
                {
                    matrix[i][j] = currentRow[j];
                    if (matrix[i][j] == 'P')
                    {
                        pRow = i;
                        pCol = j;
                    }
                }
            }

            matrix[pRow][pCol] = '-';

            while (energy > 0)
            {
                var currentCommand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = currentCommand[0];
               
                int eRow = int.Parse(currentCommand[1]);
                int eCol = int.Parse(currentCommand[2]);
                if (IsValid(matrix, n, eRow, eCol))
                { matrix[eRow][eCol] = 'S'; }
                energy -= 1;

                switch (command.ToLower())
                {
                    case "up": pRow--; break;
                    case "down": pRow++; break;
                    case "right": pCol++; break;
                    case "left": pCol--; break;
                }

                if (!IsValid(matrix, n, pRow, pCol))
                {
                    switch (command.ToLower())
                    {
                        case "up": pRow++; break;
                        case "down": pRow--; break;
                        case "right": pCol--; break;
                        case "left": pCol++; break;
                    }
                    //        matrix[pRow][pCol] = 'P';
                }
                else
                {
                    if (matrix[pRow][pCol] == 'H')
                    {
                        Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
                        matrix[pRow][pCol] = '-';
                        PrintM(matrix, n);
                        return;
                    }
                    else if (matrix[pRow][pCol] == 'S')
                    {
                        energy -= 2;
                        if (energy <= 0)
                        {
                            matrix[pRow][pCol] = 'X';
                            Console.WriteLine($"Paris died at {pRow};{pCol}.");
                            PrintM(matrix, n);
                            return;
                        }
                        else
                        {
                            matrix[pRow][pCol] = '-';
                        }
                    }
                }
            }


            matrix[pRow][pCol] = 'X';
            Console.WriteLine($"Paris died at {pRow};{pCol}.");
            PrintM(matrix, n);
        }
        private static bool IsValid(char[][] matrix, int n, int pRow, int pCol)
        {
            if (pRow >= 0 && pRow < n && pCol >= 0 && pCol < n)
            {
                return true;
            }
            else return false;
        }

        public static void PrintM(char[][] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}
