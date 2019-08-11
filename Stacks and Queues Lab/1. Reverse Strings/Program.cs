using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var reverse = new Stack<char>(input);

            while(reverse.Count!=0)
            {
                Console.Write(reverse.Pop());
            }
        
        }
    }
}
