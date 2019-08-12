using System;
using System.Collections.Generic;

namespace Problem_4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Dictionary<int, int>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers.Add(currentNumber, 1);
                }
                else
                {
                    numbers[currentNumber]++;
                }

            }

            foreach (var item in numbers)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }

            }
        }
    }
}
