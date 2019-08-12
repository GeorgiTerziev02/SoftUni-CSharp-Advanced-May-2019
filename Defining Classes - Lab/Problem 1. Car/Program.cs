using System;

namespace Problem_1._Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar=new Car("BMW","7series",2019,50,50);
            Console.WriteLine(myCar.HowPowerfulAMI());

            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Year);

            Console.WriteLine(myCar.Fuel);

        }
    }
}
