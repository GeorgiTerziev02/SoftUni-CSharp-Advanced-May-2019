using System;
using System.Linq;

namespace Problem_5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int> incrementByOne = number => number + 1;
            Func<int, int> multiplyByTwo = number => number * 2;
            Func<int, int> decreaseByOne = number => number - 1;

            string command = Console.ReadLine();

            Action<int[]> printNumbers = numbers => Console.WriteLine(string.Join(" ", numbers));

            while (command != "end")
            {
                if (command == "add")
                {
                    inputNumbers = inputNumbers.Select(incrementByOne).ToArray();
                }
                else if (command == "multiply")
                {
                    inputNumbers = inputNumbers.Select(multiplyByTwo).ToArray();
                }
                else if (command == "subtract")
                {
                    inputNumbers = inputNumbers.Select(decreaseByOne).ToArray();
                }
                else if (command == "print")
                {
                    printNumbers(inputNumbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
