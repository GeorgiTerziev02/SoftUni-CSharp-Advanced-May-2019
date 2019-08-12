using System;
using System.Linq;

namespace _4._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n * 1.2)
                .ToArray();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}") ;
            }
        }
    }
}
