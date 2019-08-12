using System;
using System.Linq;

namespace Problem_9._1_List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            var numbers = new int[endOfRange];

            for (int i = 0; i < endOfRange; i++)
            {
                numbers[i] = i + 1;
            }

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            Func<int, int, int> dividing = (first, second)
                   =>
               {
                   if (second % first == 0)
                       return second;
                   else return first * second;                 
               };

            int finalDivider = 1;

            for (int i = 0; i < dividers.Length; i++)
            {
                finalDivider = dividing(finalDivider, dividers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % finalDivider == 0)
                    Console.Write(numbers[i]+" ");
            }
        }
    }
}
