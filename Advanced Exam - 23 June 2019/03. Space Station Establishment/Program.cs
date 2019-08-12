using System;

namespace _03._Space_Station_Establishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];
            int blackHoleCount = 0;

            int sRow = -1;
            int sCol = -1;

            for (int i = 0; i < size; i++)
            {
                string currentRow = Console.ReadLine();
                matrix[i] = new char[size];

                for (int j = 0; j < size; j++)
                {
                    matrix[i][j] = currentRow[j];
                    if (matrix[i][j] == 'S')
                    {
                        sRow = i;
                        sCol = j;
                    }

                    if (matrix[i][j] == 'O')
                    {
                        blackHoleCount++;
                    }
                }
            }

            string command = Console.ReadLine();

            int starPower = 0;

            while(true)
            {
                matrix[sRow][sCol] = '-';

                switch(command.ToLower())
                {
                    case "up": sRow--;break;
                    case "down": sRow++;break;
                    case "left": sCol--;break;
                    case "right": sCol++;break;
                }                

                if(!IsValid(sRow,sCol,size))
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    
                    break;
                }
                else
                {
                    if(matrix[sRow][sCol]=='O')
                    {
                        matrix[sRow][sCol] = '-';
                        int x = sRow;
                        int y = sCol;
                        sRow = FindOtherHoleRow(matrix, size, x, y);
                        sCol = FindOtherHoleCol(matrix, size, x, y);
                        matrix[sRow][sCol] = 'S';
                    }
                    else if(char.IsDigit(matrix[sRow][sCol]))
                    {
                        int toAdd = (int)matrix[sRow][sCol]-48;

                        starPower += toAdd;
                        matrix[sRow][sCol] = 'S';
                    }

                }

                if (starPower >= 50)
                {
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    break;
                }



                command = Console.ReadLine();
            }

            //if (starPower >= 50)
            //{
            //    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            //}

            Console.WriteLine($"Star power collected: {starPower}");
            PrintMatrix(matrix);
        }

        private static int FindOtherHoleCol(char[][] matrix, int size, int sRow, int sCol)
        {
            int index = -1;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i][j] == 'O' && i != sRow && j != sCol)
                    {
                        index = j;
                        break;
                    }
                }
            }

            return index;
        }

        private static int FindOtherHoleRow(char[][] matrix, int size, int sRow, int sCol)
        {
            int index = -1;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(matrix[i][j]=='O'&&i!=sRow&&j!=sCol)
                    {
                        index = i;
                        break;
                    }
                }
            }

            return index;
        }

        public static void PrintMatrix(char[][] matrix/*, int size*/)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        public static bool IsValid(int row,int col,int size)
        {
            if (row >= 0 && row < size && col >= 0 && col < size)
            {
                return true;
            }
            else return false;
        }
    }
}
