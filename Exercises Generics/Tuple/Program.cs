using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();

            string[] personBeer = Console.ReadLine().Split();

            string[] numbers = Console.ReadLine().Split();

            string pName = personInfo[0] + " " + personInfo[1];
            string pAdress = personInfo[2];
            string pTown = personInfo[3];

            if (personInfo.Length == 5)
            {
                pTown = pTown + " " + personInfo[4];
            }

            string beerName = personBeer[0];
            int beerL = int.Parse(personBeer[1]);
            bool isDrunk = false;
            if (personBeer[2].ToLower() == "drunk") isDrunk = true;

            string myName = numbers[0];
            double myDouble = double.Parse(numbers[1]);

            var person = new Tuple<string, string, string>(pName, pAdress, pTown);

            var beer = new Tuple<string, int, bool>(beerName, beerL, isDrunk);

            var numTuple = new Tuple<string, double, string>(myName, myDouble, numbers[2]);

            Console.WriteLine(person.GetInfo());
            Console.WriteLine(beer.GetInfo());
            Console.WriteLine(numTuple.GetInfo());

        }
    }
}
