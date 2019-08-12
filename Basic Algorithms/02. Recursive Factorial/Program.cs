using System;

namespace _02._Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            int result = Fact(number);

            Console.WriteLine(result);
            
        }

        public static int Fact(int n)
        {
            if(n==0)
            {
                return 1;
            }

            return n * Fact(n-1);
        }
    }
}
