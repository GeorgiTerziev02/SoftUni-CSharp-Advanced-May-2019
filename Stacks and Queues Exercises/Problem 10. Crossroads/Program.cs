using System;
using System.Collections.Generic;

namespace Problem_10.__Crossroads
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

            while(input!="END")
            {
                if(input!="green")
                {
                    cars.Enqueue(input);
                }
                else if(input=="green")
                {
                    int time = greenLight;

                    while (cars.Count!=0&&time>0)
                    {
                        string currentCar = cars.Dequeue();
                        if(currentCar.Length<=time)
                        {
                            time = time - currentCar.Length;
                            passedCars++;
                        }

                        else if(currentCar.Length<=time+freeWindow)
                        {
                            passedCars++;
                            time = 0;
                        }

                        else
                        {
                            Console.WriteLine("A crash happened!");
                            int hit = time + freeWindow;
                            char x = currentCar[hit];
                            Console.WriteLine($"{currentCar} was hit at {x}.");
                            return;
                        }
                    }
                }
                input=Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
