using System;
using System.Linq;

namespace Problem_7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Predicate<string> checkNames = name => name.Length <= length;

            names = names
                .Where(x => checkNames(x))
                .ToArray();

            Action<string[]> print = toPrint => Console.WriteLine(string.Join(Environment.NewLine,toPrint));

            print(names);
        }
    }
}
