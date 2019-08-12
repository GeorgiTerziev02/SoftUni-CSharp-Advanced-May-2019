using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4.__Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var orders = new Queue<int>(input);
            int max = input.Max();

            while (orders.Any())
            {
                if (quantity - orders.Peek() < 0) { break; }
                else
                {
                    quantity = quantity - orders.Dequeue();
                }
            }

            Console.WriteLine(max);

            if (!orders.Any()) Console.WriteLine("Orders complete");
            else
            {
                int[] array = orders.ToArray();
                Console.WriteLine($"Orders left: {string.Join(" ", array)}");
            }
        }
    }
}