using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(input);

            Console.WriteLine(string.Join(", ", lake));

            //foreach (var currentStone in lake)
            //{
            //    Console.Write(currentStone+" ");
            //}
        }
    }
}
