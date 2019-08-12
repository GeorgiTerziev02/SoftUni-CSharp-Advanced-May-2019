using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            cars = new List<Car>(capacity);
            this.capacity = capacity;
        }

        public string AddCar(Car car)
        {
            string result; 

            if (cars.Contains(car))
            {
                result = "Car with that registration number, already exists!";
            }
            else if (cars.Count == capacity)
            {
                result = "Parking is full!";
            }
            else
            {
                cars.Add(car);
                result = $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
            return result;
        }

        public string RemoveCar(string registrationNumber)
        {
            bool b = false;
            string result = string.Empty;

            for (int i = 0; i < cars.Count; i++)
            {
                Car currentCar = cars[i];
                if(currentCar.RegistrationNumber==registrationNumber)
                {
                    b = true;
                    result=$"Successfully removed {registrationNumber}";
                    cars.Remove(currentCar);
                }
            }

            if(b==false)
            {
                result="Car with that registration number, doesn't exist!";
            }

            return result;
        }

        public Car GetCar(string registrationNumber)
        {
            int index = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                Car currentCar = cars[i];
                if (currentCar.RegistrationNumber == registrationNumber)
                {
                    index = i;
                }
            }
            return cars[index];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            for (int i = 0; i < registrationNumbers.Count; i++)
            {
                bool b = false;
                foreach (var car in cars)
                {
                    if(car.RegistrationNumber==registrationNumbers[i])
                    {
                        b = true;                            
                    }
                }
                if(b==true)
                {
                    Car carToRemove=GetCar(registrationNumbers[i]);
                    cars.Remove(carToRemove);
                }
            }
        }

        public int Count
        {
            get { return cars.Count; }
        }
    }
}
