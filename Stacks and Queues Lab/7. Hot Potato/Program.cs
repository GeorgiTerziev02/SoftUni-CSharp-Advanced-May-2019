using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var children = new Queue<string>(input);
            int rotation = int.Parse(Console.ReadLine());
            
            while(children.Count>1)
            {
                for (int i = 1; i <= rotation; i++)
                {
                    if (i == rotation) { Console.WriteLine($"Removed {children.Dequeue()}"); }
                    else children.Enqueue(children.Dequeue());
                }
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
