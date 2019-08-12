using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._1_Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());

            var diff = new Queue<int>();

            for (int i = 0; i < pumps; i++)
            {
                int[] pumpProps = Console.ReadLine().Split().Select(int.Parse).ToArray();
                diff.Enqueue(pumpProps[0] - pumpProps[1]);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;
                foreach (var pump in diff)
                {
                    totalFuel += pump;
                    if (totalFuel < 0)
                    {
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
                else
                {
                    index++;
                    diff.Enqueue(diff.Dequeue());
                }
            }
            Console.WriteLine(index);
        }
    }
}
