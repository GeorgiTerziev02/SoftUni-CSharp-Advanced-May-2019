using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = input[0];
            int m = input[1];

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int elementForFirstSet = int.Parse(Console.ReadLine());
                firstSet.Add(elementForFirstSet);
            }

            for (int i = 0; i < m; i++)
            {
                int elementForSecondSet = int.Parse(Console.ReadLine());
                secondSet.Add(elementForSecondSet);
            }

            foreach (var number in firstSet)
            {
                if(secondSet.Contains(number))
                {
                    Console.Write(number+" ");
                }
            }
        }
    }
}
