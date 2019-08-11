using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var supermarketQueue = new Queue<string>();

            string customer = Console.ReadLine();

            while(customer!="End")
            {
                if (customer == "Paid")
                {
                    while (supermarketQueue.Count > 0)
                    {
                        Console.WriteLine(supermarketQueue.Dequeue());
                    }
                }
                else supermarketQueue.Enqueue(customer);

                customer = Console.ReadLine();
            }

            Console.WriteLine($"{supermarketQueue.Count} people remaining.");
        }
    }
}
