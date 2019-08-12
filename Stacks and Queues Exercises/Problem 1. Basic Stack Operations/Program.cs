using System;
using System.Collections.Generic;
using System.Linq;

namespace try_out
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split().ToArray();
            int N = int.Parse(input1[0]);
            int S = int.Parse(input1[1]);
            int X = int.Parse(input1[2]);
            string[] input2 = Console.ReadLine().Split().ToArray();
            var stack = new Stack<int>();
            foreach (var number in input2)
            {
                int currentNumber = int.Parse(number);
                stack.Push(currentNumber);
            }
            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }
            int min = int.MaxValue;
            if (stack.Count == 0) {Console.WriteLine("0");return;}
            while (stack.Count != 0)
            {
                int currentNumber = stack.Pop();
                if (currentNumber == X)
                { Console.WriteLine("true"); return; }
                else
                {
                    if (currentNumber < min) min = currentNumber;
                }
            }
            Console.WriteLine(min);
        }
    }
}
