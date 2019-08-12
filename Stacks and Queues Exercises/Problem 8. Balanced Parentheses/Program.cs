using System;
using System.Collections.Generic;

namespace Problem_8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> symbols = new Stack<char>();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    symbols.Push(input[i]);
                }
                else
                {
                    if (input[i] == ')')
                    {
                        if (symbols.Pop() != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (input[i] == '}')
                    {
                        if (symbols.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (input[i] == ']')
                    {
                        if (symbols.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
