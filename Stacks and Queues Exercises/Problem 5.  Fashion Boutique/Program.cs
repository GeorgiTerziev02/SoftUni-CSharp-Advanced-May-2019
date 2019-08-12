using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5.__Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            var clothes = new Stack<int>(input);
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;

            while (clothes.Any())
            {
                if (sum + clothes.Peek() > capacity) { sum = 0; racks++; }
                else
                {
                    sum += clothes.Pop();
                }
            }

            Console.WriteLine(racks);
        }
    }
}
