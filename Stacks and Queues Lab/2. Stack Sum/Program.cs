using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(numbers);

            string input = Console.ReadLine();

            while(input.ToLower()!="end")
            {
                string[] currentCommand = input.Split();
                
                if(currentCommand[0].ToLower()=="add")
                {
                    stack.Push(int.Parse(currentCommand[1]));
                    stack.Push(int.Parse(currentCommand[2]));
                }

                if (currentCommand[0].ToLower() == "remove")
                {
                    int count = int.Parse(currentCommand[1]);
                    if (count <= stack.Count)
                    {
                        while (stack.Count != 0 && count > 0)
                        {
                            stack.Pop();
                            count--;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");

        }
    }
}
