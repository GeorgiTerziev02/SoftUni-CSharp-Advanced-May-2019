using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new Queue<string>();

            int toPass = int.Parse(Console.ReadLine());
            int passedCars = 0;

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < toPass; i++)
                    {
                        if (cars.Any())
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;
                        }
                    }
                }
                else cars.Enqueue(command);

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
