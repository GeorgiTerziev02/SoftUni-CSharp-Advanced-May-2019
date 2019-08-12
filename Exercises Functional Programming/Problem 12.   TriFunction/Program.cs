using System;
using System.Linq;

namespace Problem_12.___TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> isLarger = (name, charsLength)
                    => name.Sum(x => x) >= charsLength;

            Func<string[], Func<string, int, bool>, string> nameFilter =
               (inputNames, isLargerFilter) => inputNames.FirstOrDefault(x=>isLarger(x,length));

            string firstName = nameFilter(names,isLarger);

            Console.WriteLine(firstName);
        }
    }
}
