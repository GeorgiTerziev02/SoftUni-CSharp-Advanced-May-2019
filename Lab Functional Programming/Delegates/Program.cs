using System;

namespace Delegates
{
    class Program
    {
        //public delegate string BinaryOperator(int x, int y);
        static void Main(string[] args)
        {
            Func<int, int, string> opMulty = Greater;
            Console.WriteLine(Calculator(4,5,Multiply));
            Console.WriteLine(Calculator(4,5,Add));
            Console.WriteLine(Calculator(4,5,Greater));
            Console.WriteLine(Calculator(35,5,(x,y)=>(x/y).ToString()));
            Console.WriteLine(Calculator(35,5,(x,y)=>(x/y).ToString()));
        }

        public static string Calculator(int x,int y,Func<int,int,string> opr)
        {
            return opr(x, y);
        }

        public static string Substract(int x, int y) => (x - y).ToString();
        public static string Multiply(int x,int y)
        {
            return (x * y).ToString();
        }

        public static string Add(int x,int y)
        {
            return (x + y).ToString();
        }

        public static string Greater(int x,int y)
        {
            return (x > y).ToString();
        }
    }
}
