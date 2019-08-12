using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6.__Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            var notServiced = new Queue<string>(input);
            var serviced = new List<string>();
            string command = Console.ReadLine();

            while(command!="End")
            {
                if(command=="Service")
                {
                    if (notServiced.Count != 0)
                    {
                        string toService = notServiced.Dequeue();
                        Console.WriteLine($"Vehicle {toService} got served.");
                        serviced.Add(toService);
                    }
                }
                else if(command=="History")
                {
                    serviced.Reverse();
                    Console.WriteLine(string.Join(", ",serviced));
                    serviced.Reverse();
                }
                else if(command.Contains("-"))
                {
                    string[] array = command.Split("-").ToArray();
                    string car = array[1];
                    if(serviced.Contains(car))
                    {
                        Console.WriteLine("Served.");
                    }
                    else if(notServiced.Contains(car))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }

                }
                command = Console.ReadLine();
            }

            if(notServiced.Count!=0)
            {
                Console.Write("Vehicles for service: ") ;
                string[] carsNotServiced = notServiced.ToArray();
                Console.WriteLine(string.Join(", ",carsNotServiced));
            }

            if(serviced.Count!=0)
            {
                serviced.Reverse();
                Console.Write("Served vehicles: ");
                Console.WriteLine(string.Join(", ",serviced));
            }

        }
    }
}
