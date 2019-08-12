using System;
using System.Collections.Generic;

namespace _10._1_Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            var cars = new Queue<string>();
            int passedCars = 0;
            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else if (input == "green")
                {
                    int time = greenLight;

                    while (cars.Any() && time > 0)
                    {
                        string car = cars.Peek();
                        int current = cars.Dequeue().Length;

                        if (current > time)
                        {
                            time = time + freeWindow;
                            if (current > time)
                            {
                                Console.WriteLine("A crash happened!");
                                char x = car[time];
                                Console.WriteLine($"{car} was hit at {x}.");
                                return;
                            }
                            else
                            {
                                time = 0;
                                passedCars++;
                            }
                        }
                        else
                        {
                            time -= current;
                            passedCars++;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
