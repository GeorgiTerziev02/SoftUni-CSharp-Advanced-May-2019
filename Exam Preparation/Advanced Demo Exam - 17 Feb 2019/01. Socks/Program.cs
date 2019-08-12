using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] socksLeft = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] socksRight = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var leftSocks = new Stack<int>(socksLeft);
            var rightSocks = new Queue<int>(socksRight);

            var pairs = new List<int>();

            while (leftSocks.Count != 0 && rightSocks.Count != 0)
            {
                int currentLeft = leftSocks.Pop();
                int currentRight = rightSocks.Peek();

                if(currentLeft==currentRight)
                {
                    rightSocks.Dequeue();
                    currentLeft++;
                    leftSocks.Push(currentLeft);
                }
                else if(currentLeft<currentRight)
                {
                    continue;
                }
                else
                {
                    int newPair = currentLeft + currentRight;
                    pairs.Add(newPair);
                    rightSocks.Dequeue();
                }
            }

            Console.WriteLine( pairs.Max());
            Console.WriteLine(string.Join(" ",pairs));
        }
    }
}
