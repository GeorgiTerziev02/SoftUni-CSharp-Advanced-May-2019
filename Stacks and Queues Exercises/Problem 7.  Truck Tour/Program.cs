using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7._Trick_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());

            Queue<int> diff = new Queue<int>();        

            for (int i = 0; i < pumps; i++)
            {
                int[] pumpProps = Console.ReadLine().Split().Select(int.Parse).ToArray();
                diff.Enqueue(pumpProps[0] - pumpProps[1]);
            }

            int index = 0;

            while (true)
            {
                Queue<int> copyDiff = new Queue<int>(diff);
                int fuel = -1;

                while (copyDiff.Any())
                {
                    if (copyDiff.Peek() > 0 && fuel == -1)
                    {
                        fuel = copyDiff.Dequeue();
                        diff.Enqueue(diff.Dequeue());

                    }
                    else if (copyDiff.Peek() < 0 && fuel == -1)
                    {
                        copyDiff.Enqueue(copyDiff.Dequeue());
                        diff.Enqueue(diff.Dequeue());
                        index++;
                    }
                    else
                    {
                        fuel += copyDiff.Dequeue();
                        if (fuel < 0)
                        {
                            break;
                        }
                    }
                }

                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }
                index++;
            }
        }
    }
}