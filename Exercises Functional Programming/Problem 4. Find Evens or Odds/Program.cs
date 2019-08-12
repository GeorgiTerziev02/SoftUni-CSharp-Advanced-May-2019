using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lowerNum = input[0];
            int higherNum = input[1];

            List<int> numbers = new List<int>();

            for (int i = lowerNum; i <= higherNum; i++)
            {
                numbers.Add(i);
            }

            string type = Console.ReadLine();

            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;
            Action<List<int>> print = numbersCollection => Console.WriteLine(string.Join(" ",numbersCollection));

            if (type.ToLower() == "even")
            {
                numbers = numbers.Where(x => isEven(x)).ToList();
            }
            else
            {
                numbers = numbers.Where(x => isOdd(x)).ToList();
            }

            print(numbers);
        }
    }
}
