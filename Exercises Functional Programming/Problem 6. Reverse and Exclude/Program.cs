using System;
using System.Linq;

namespace Problem_6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int[]> reverseArray = array =>
            {
                int[] reversed = new int[array.Length];
                int index = 0;

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    reversed[index] = array[i];
                    index++;
                }
                return reversed;
            };

            Action<int[]> printNumbers = numbersToPrint => Console.WriteLine(string.Join(" ", numbersToPrint));

            numbers = reverseArray(numbers);

            int numberToDivideBy = int.Parse(Console.ReadLine());

            Predicate<int> nonDivisible = number => number % numberToDivideBy != 0;

            numbers = numbers
                .Where(x => nonDivisible(x))
                .ToArray();

            printNumbers(numbers);
        }
    }
}
