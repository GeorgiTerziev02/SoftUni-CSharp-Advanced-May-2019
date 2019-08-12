using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            List<int> numbers = Enumerable.Range(1, endOfRange).ToList();

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var currentNumber in dividers)
            {
                predicates.Add(x => x % currentNumber == 0);
            }

            var resultNumbers = new List<int>();

            foreach (var number in numbers)
            {
                bool isValid = true;

                foreach (var currentPredicate in predicates)
                {
                    if(!currentPredicate(number))
                    {
                        isValid = false;
                        break;
                    }
                }

                if(isValid)
                {
                    resultNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", resultNumbers));
        }
    }
}
