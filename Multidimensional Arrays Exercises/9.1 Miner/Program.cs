using System;

namespace _9._1_Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            int minerRow = -1;
            int minerCol = -1;
            int coal = 0;

            string[] commands = Console.ReadLine().Split();

            for (int row = 0; row < n; row++)
            {
                matrix[row] = new char[n];
                string[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < n; col++)
                {
                    matrix[row][col] = char.Parse(currentRow[col]);
                    if (matrix[row][col] == 's')
                    {
                        minerCol = col;
                        minerRow = row;
                    }
                    else if (matrix[row][col] == 'c')
                    {
                        coal++;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                string currentCommand = commands[i];

                switch (currentCommand)
                {
                    case "left": minerCol--; break;
                    case "right": minerCol++; break;
                    case "up": minerRow--; break;
                    case "down": minerRow++; break;
                }
                if (!IsValid(minerRow, minerCol, matrix.Length))
                {
                    switch (currentCommand)
                    {
                        case "left": minerCol++; break;
                        case "right": minerCol--; break;
                        case "up": minerRow++; break;
                        case "down": minerRow--; break;
                    }
                }
                else
                {
                    if (matrix[minerRow][minerCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                        return;
                    }
                    else if (matrix[minerRow][minerCol] == 'c')
                    {
                        coal--;
                        matrix[minerRow][minerCol] = '*';
                        if (coal == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine($"{coal} coals left. ({minerRow}, {minerCol})");
        }

        private static bool IsValid(int row, int col, int length)
        {
            if (row >= 0 && row < length && col >= 0 && col < length) return true;
            else return false;
        }
    }
}