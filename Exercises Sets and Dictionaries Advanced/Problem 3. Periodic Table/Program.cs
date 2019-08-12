using System;
using System.Collections.Generic;

namespace Problem_3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var chemicalElements = new SortedSet<string>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] currentLine = Console.ReadLine().Split();

                for (int j = 0; j < currentLine.Length; j++)
                {
                    chemicalElements.Add(currentLine[j]);
                }

            }

            Console.WriteLine(string.Join(" ",chemicalElements));
        }
    }
}
