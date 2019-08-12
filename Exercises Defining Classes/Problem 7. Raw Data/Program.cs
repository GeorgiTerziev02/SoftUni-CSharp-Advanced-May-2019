using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < number; i++)
            {
                string[] currentCar = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var model = currentCar[0];
                var engine = new Engine(int.Parse(currentCar[1]), int.Parse(currentCar[2]));
                var cargo = new Cargo(int.Parse(currentCar[3]), currentCar[4]);
                var tires = new Tire[]
                {
                  new Tire( double.Parse(currentCar[5]),int.Parse(currentCar[6])),
                  new Tire( double.Parse(currentCar[7]),int.Parse(currentCar[8])),
                  new Tire( double.Parse(currentCar[9]),int.Parse(currentCar[10])),
                  new Tire( double.Parse(currentCar[11]),int.Parse(currentCar[12])),

                };

                Car newCar = new Car(model, engine, cargo, tires);
                cars.Add(newCar);
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                
                foreach (var car in cars.Where(x => x.Cargo.Type == command))
                {
                    if(car.Tire.Where(y=>y.Pressure<1).FirstOrDefault()!=null)
                        Console.WriteLine(car.Model);
                  
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == command && x.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
