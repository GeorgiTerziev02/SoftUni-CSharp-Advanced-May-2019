using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>(numbers);
            var list = new List<int>();

            while(queue.Any())
            {
                int currenNumber = queue.Dequeue();
                if (currenNumber % 2 == 0) list.Add(currenNumber);
            }

            Console.WriteLine(string.Join(", ",list));
        }
    }
}
