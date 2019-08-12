using System;

namespace _02._Tron_Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            int fRow = -1;
            int fCol = -1;

            int sRow = -1;
            int sCol = -1;

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new char[n];

                string currentRow = Console.ReadLine();

                for (int j = 0; j < currentRow.Length; j++)
                {
                    matrix[i][j] = currentRow[j];
                    if (currentRow[j] == 'f')
                    {
                        fRow = i;
                        fCol = j;
                    }
                    else if (currentRow[j] == 's')
                    {
                        sRow = i;
                        sCol = j;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string playerOneCommand = command[0];
                string playerTwoCommand = command[1];

                switch (playerOneCommand.ToLower())
                {
                    case "up": fRow--; break;
                    case "down": fRow++; break;
                    case "right": fCol++; break;
                    case "left": fCol--; break;

                }

                switch (playerTwoCommand.ToLower())
                {
                    case "up": sRow--; break;
                    case "down": sRow++; break;
                    case "right": sCol++; break;
                    case "left": sCol--; break;
                }

                fRow = RotationIfNeeded(fRow, n);
                fCol = RotationIfNeeded(fCol, n);
                sRow = RotationIfNeeded(sRow, n);
                sCol = RotationIfNeeded(sCol, n);

                if (matrix[fRow][fCol] == 's')
                {
                    matrix[fRow][fCol] = 'x';
                    break;
                }
                else
                {
                    matrix[fRow][fCol] = 'f';
                }

                if (matrix[sRow][sCol] == 'f')
                {
                    matrix[sRow][sCol] = 'x';
                    break;
                }
                else
                {
                    matrix[sRow][sCol] = 's';
                }

            }

            PrintMatrix(matrix, n);

        }
        public static void PrintMatrix(char[][] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }
        public static bool IsValid(int x, int y, int n)
        {
            if (x >= 0 && y >= 0 && x < n && y < n)
            {
                return true;
            }

            else return false;
        }
        public static int RotationIfNeeded(int x, int n)
        {
            if (x < 0)
            {
                return n - 1;
            }
            else if (x >= n)
            {
                return 0;
            }
            else
            {
                return x;
            }
        }
    }
}
