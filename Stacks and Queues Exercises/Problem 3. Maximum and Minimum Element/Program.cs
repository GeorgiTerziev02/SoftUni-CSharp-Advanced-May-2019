using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var someStack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (command[0] == 1)
                {
                    someStack.Push(command[1]);
                }
                else if (command[0] == 2)
                {
                    if (someStack.Any()) someStack.Pop();
                }
                else if (command[0] == 3)
                {
                    if (someStack.Any())
                    {
                        var newStack = new Stack<int>();
                        int max = int.MinValue;

                        while (someStack.Any())
                        {
                            if (someStack.Peek() > max) max = someStack.Peek();
                            newStack.Push(someStack.Peek());
                            someStack.Pop();
                        }
                        Console.WriteLine(max);

                        while (newStack.Any())
                        {
                            someStack.Push(newStack.Pop());
                        }
                    }
                }
                else if(command[0]==4)
                {
                    if (someStack.Any())
                    {
                        var newStack = new Stack<int>();
                        int min = int.MaxValue;

                        while (someStack.Any())
                        {
                            if (someStack.Peek() < min) min = someStack.Peek();
                            newStack.Push(someStack.Peek());
                            someStack.Pop();
                        }
                        Console.WriteLine(min);

                        while (newStack.Any())
                        {
                            someStack.Push(newStack.Pop());
                        }
                    }
                }
            }

            int[] array = someStack.ToArray();
            Console.WriteLine(string.Join(", ",array));

        }
    }
}
