using System;
using System.Collections.Generic;

namespace Problem_5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if(!symbols.ContainsKey(input[i]))
                {
                    symbols.Add(input[i], 1);
                }
                else
                {
                    symbols[input[i]]++;
                }
            }

            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }

        }
    }
}
