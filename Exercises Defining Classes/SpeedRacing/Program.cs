using System;
using System.Collections.Generic;

namespace SpeedRacing
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

                string model = currentCar[0];
                double fuelAmount = double.Parse(currentCar[1]);
                double fuelConsumption = double.Parse(currentCar[2]);

                Car car = new Car();

                car.Model = model;
                car.FuelAmount = fuelAmount;
                car.FuelConsumptionPerKilometer = fuelConsumption;
                car.TravelledDistance = 0;
                cars.Add(car);
            }

            string command = Console.ReadLine();

            while(command.ToLower()!="end")
            {
                string[] currentCommand = command.Split();

                string carToTravell = currentCommand[1];
                double kmToTravell = double.Parse(currentCommand[2]);

                for (int i = 0; i < cars.Count; i++)
                {
                    if(cars[i].Model==carToTravell)
                    {
                        cars[i].travelling(kmToTravell);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }

        }
    }
}
