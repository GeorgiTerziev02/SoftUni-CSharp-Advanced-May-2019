using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Basic_Queue_Operations
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
            var queue = new Queue<int>();
            foreach (var number in input2)
            {
                queue.Enqueue(int.Parse(number));
            }
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }
            
            if (queue.Count == 0) { Console.WriteLine("0"); return; }
            int min = int.MaxValue;
            while(queue.Count!=0)
            {
                int currentNumber = queue.Dequeue();
                if (currentNumber == X) { Console.WriteLine("true");return; }
                else
                {
                    if (currentNumber < min) min = currentNumber;
                }
            }
            Console.WriteLine(min);
        }
    }
}
