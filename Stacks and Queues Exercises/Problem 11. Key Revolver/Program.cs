using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletCost = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] sizeBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sizeLocks = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            var locks = new Stack<int>(sizeLocks);
            var bullets = new Stack<int>(sizeBullets);

            int usedBullets = 0;

            while (locks.Count != 0 && bullets.Count != 0)
            {
                int bullet = bullets.Pop();
                int @lock = locks.Pop();

                if (bullet > @lock)
                {
                    Console.WriteLine("Ping!");
                    usedBullets++;
                    locks.Push(@lock);
                }
                else
                {
                    Console.WriteLine("Bang!");
                    usedBullets++;
                }
                if (usedBullets % gunBarrelSize == 0 && bullets.Any()) Console.WriteLine("Reloading!");
            }

            if(locks.Count==0)
            {
                int leftm = intelligence - usedBullets * bulletCost;
                Console.WriteLine($"{sizeBullets.Length-usedBullets} bullets left. Earned ${leftm}");
            }
            else 
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }

        }
    }
}
