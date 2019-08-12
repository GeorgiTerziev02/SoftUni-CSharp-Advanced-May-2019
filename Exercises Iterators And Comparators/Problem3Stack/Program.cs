using System;
using System.Linq;

namespace Problem3Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] tokens = command.Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 1)
                {
                    stack.Pop();
                }
                else
                {
                    int[] array = tokens.Skip(1).Select(int.Parse).ToArray();

                    stack.Push(array);
                }

                command = Console.ReadLine();
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
