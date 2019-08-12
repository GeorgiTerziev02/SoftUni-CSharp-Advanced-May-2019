using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];
            int allCoal = 0;

            string[] commands = Console.ReadLine().Split().ToArray();

            int sRow = 0;
            int sCol = 0;

            for (int row = 0; row < n; row++)
            {
                matrix[row] = new char[n];
                char[] currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int i = 0; i < currentRow.Length; i++)
                {
                    if (currentRow[i] == 'c') allCoal++;
                    if (currentRow[i] == 's')
                    {
                        sRow = row;
                        sCol = i;
                    }
                }
                matrix[row] = currentRow;
            }
            int collectedCoal = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                string currentCommand = commands[i];

                if (currentCommand == "right")
                {
                    if(IsValid(sRow,sCol+1,n))
                    {
                        sCol++;
                        if (matrix[sRow][sCol]=='e')
                        {
                            Console.WriteLine($"Game over! ({sRow}, {sCol})");
                            return;
                        }
                        else if(matrix[sRow][sCol]=='c')
                        {
                            collectedCoal++;
                            matrix[sRow][sCol] = '*';
                        }

                       if(collectedCoal==allCoal)
                        {
                            Console.WriteLine($"You collected all coals! ({sRow}, {sCol})");
                           return;
                        }
                    }
                }

                else if (currentCommand == "left")
                {
                    if (IsValid(sRow, sCol -1, n))
                    {
                        sCol--;
                        if (matrix[sRow][sCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({sRow}, {sCol})");
                            return;
                        }
                        else if (matrix[sRow][sCol] == 'c')
                        {
                            collectedCoal++;
                            matrix[sRow][sCol] = '*';
                        }

                        if (collectedCoal == allCoal)
                        {
                            Console.WriteLine($"You collected all coals! ({sRow}, {sCol})");
                            return;
                        }
                    }
                }

                else if(currentCommand == "up")
                {
                    if (IsValid(sRow-1, sCol , n))
                    {
                        sRow--;
                        if (matrix[sRow][sCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({sRow}, {sCol})");
                            return;
                        }
                        else if (matrix[sRow][sCol] == 'c')
                        {
                            collectedCoal++;
                            matrix[sRow][sCol] = '*';
                        }

                        if (collectedCoal == allCoal)
                        {
                            Console.WriteLine($"You collected all coals! ({sRow}, {sCol})");
                            return;
                        }
                    }
                }

                else if (currentCommand == "down")
                {
                    if (IsValid(sRow+1, sCol, n))
                    {
                        sRow++;
                        if (matrix[sRow][sCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({sRow}, {sCol})");
                            return;
                        }
                        else if (matrix[sRow][sCol] == 'c')
                        {
                            collectedCoal++;
                            matrix[sRow][sCol] = '*';
                        }

                        if (collectedCoal == allCoal)
                        {
                            Console.WriteLine($"You collected all coals! ({sRow}, {sCol})");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine($"{allCoal-collectedCoal} coals left. ({sRow}, {sCol})");


        }

        private static bool IsValid(int row, int col, int n)
        {
            if (row >= 0 && row < n && col >= 0 && col < n) return true;
            else return false;
        }
    }
}
