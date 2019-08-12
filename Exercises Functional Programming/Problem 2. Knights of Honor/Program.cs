using System;

namespace Problem_2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names =>
                Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", names));

            string[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(inputNames);
        }
    }
}
