using System;
using System.Linq;

namespace Problem_3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> printNumber = number => Console.WriteLine(number);

            Func<int[], int> smallestNumber = numbers =>
             {
                 int minValue = int.MaxValue;

                 foreach (var number in numbers)
                 {
                     if (minValue > number)
                         minValue = number;
                 }

                 return minValue;
             };

            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int minNumber = smallestNumber(inputNumbers);

            printNumber(minNumber);
        }
    }
}
