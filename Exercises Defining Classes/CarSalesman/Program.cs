using System;
using System.Collections.Generic;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                var currentEngine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine;

                if(currentEngine.Length==4)
                {
                    engine = new Engine(currentEngine[0],currentEngine[1],currentEngine[2],currentEngine[3]);
                    engines.Add(engine);
                }
                else if(currentEngine.Length==2)
                {
                    engine = new Engine(currentEngine[0], currentEngine[1], "n/a", "n/a");
                    engines.Add(engine);
                }
                else if(currentEngine.Length==3)
                {
                    int number;
                    bool b = int.TryParse(currentEngine[2],out number);
                    if(b==true)
                    {
                        engine = new Engine(currentEngine[0], currentEngine[1], currentEngine[2], "n/a");
                    }
                    else
                    {
                        engine = new Engine(currentEngine[0], currentEngine[1], "n/a", currentEngine[2]);
                    }
                    engines.Add(engine);
                }

            }

            int m = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                var currentCar = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Car car;

                string engineName = currentCar[1];
                Engine engineFound=FindEngine(engines, engineName);

                if (currentCar.Length == 4)
                {
                    car = new Car(currentCar[0], engineFound, currentCar[2], currentCar[3]);
                    cars.Add(car);
                }
                else if (currentCar.Length == 2)
                {
                    car = new Car(currentCar[0], engineFound, "n/a", "n/a");
                    cars.Add(car);
                }
                else if (currentCar.Length == 3)
                {
                    int number;
                    bool b = int.TryParse(currentCar[2], out number);
                    if (b == true)
                    {
                        car = new Car(currentCar[0], engineFound, currentCar[2], "n/a");
                    }
                    else
                    {
                        car = new Car(currentCar[0], engineFound, "n/a", currentCar[2]);
                    }
                    cars.Add(car);
                }

            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Model+":");
                Console.WriteLine($"  {car.Engine.EModel}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
                
            }

        }

        private static Engine FindEngine(List<Engine> engines, string engineName)
        {
            for (int i = 0; i < engines.Count; i++)
            {
                if(engines[i].EModel==engineName)
                {
                    return engines[i];
                }
            }
            return engines[0];
        }
    }
}
