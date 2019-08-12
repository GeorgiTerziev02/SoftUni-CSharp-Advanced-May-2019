using System;
using System.Linq;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<double> myBox = new Box<double>();

            double n = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                myBox.Add(input);
            }

            //int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            // myBox.Swap(indexes[0], indexes[1]);

            double stringToCompare = double.Parse(Console.ReadLine());

            myBox.Compare(stringToCompare);

            Console.WriteLine(myBox.CountGreater);

            //var result = myBox.ToString();

           // Console.WriteLine(result);
        }
    }
}
