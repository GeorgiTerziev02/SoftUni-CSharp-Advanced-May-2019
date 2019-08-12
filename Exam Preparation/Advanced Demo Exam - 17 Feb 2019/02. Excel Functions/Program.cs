using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Excel_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var headers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[][] matrix = new string[n - 1][];

            for (int i = 0; i < n-1; i++)
            {
                matrix[i] = new string[headers.Count];

                string[] currentRow = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                matrix[i] = currentRow;
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string action = command[0];

            if(action.ToLower()=="hide")
            {
                string header = command[1];

                int indexOfHeader=headers.IndexOf(header);

                string[][] newMatrix = new string[n - 1][];

                for (int row = 0; row < n-1; row++)
                {
                    newMatrix[row] = new string[headers.Count-1];
                    int k = 0;
                    for (int j = 0; j < headers.Count; j++)
                    {
                        if(j!=indexOfHeader)
                        {
                            newMatrix[row][k] = matrix[row][j];
                            k++;
                        }
                    }
                }

                headers.RemoveAt(indexOfHeader);
                Console.WriteLine(string.Join(" | ",headers));
                PrintM(newMatrix,n-1);
            }
            else if(action.ToLower()=="filter")
            {
                string header = command[1];
                string value = command[2];

                int indexOfHeader = headers.IndexOf(header);

                Console.WriteLine(string.Join(" | ", headers));

                for (int row = 0; row < n-1; row++)
                {
                    if(matrix[row][indexOfHeader]==value)
                    {
                        Console.WriteLine(string.Join(" | ",matrix[row]));
                    }
                }
            }
            else if(action.ToLower()=="sort")
            {
                string header = command[1];
                int indexOfHeader = headers.IndexOf(header);

                matrix =matrix.OrderBy(x=>x[indexOfHeader]).ToArray();

                Console.WriteLine(string.Join(" | ", headers));
                PrintM(matrix, n - 1);
            }
                  
        }
        public static void PrintM(string[][] matrix,int n)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" | ",row));
            }
        }
    }
}
