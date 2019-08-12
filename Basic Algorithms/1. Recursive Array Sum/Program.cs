using System;
using System.Linq;

namespace _1._Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToSum = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var result = Sum(arrayToSum, 0);

            Console.WriteLine(result);
            
        }

        public static int Sum(int[] array,int index)
        {
            if(index<array.Length)
            {
                return array[index] + Sum(array, ++index);
            }

            return 0;
        }
    }
}
