using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_12.__Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottleValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bottles = new Stack<int>(bottleValues);
            var cups = new Queue<int>(cupValues);
            int wasted = 0;

            while(bottles.Count!=0&&cups.Count!=0)
            {
                int currentBottle = bottles.Pop();
                int currentCup = cups.Dequeue();
                int diff = currentBottle - currentCup;

                if(diff>=0)
                {
                    wasted = wasted + diff;
                }
                else
                {    
                    while(bottles.Any()&&diff<0)
                    {
                        diff+= bottles.Pop(); 
                    }
                    wasted += diff;
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
  
            Console.WriteLine($"Wasted litters of water: {wasted}");
        }
    }
}
