using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            var halls = new Dictionary<char,Queue<int>>();

            var letters = new Queue<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i][0];
                if(char.IsLetter(ch))
                {
                    letters.Enqueue(ch);
                    halls.Add(ch, new Queue<int>());
                }
                else 
                {
                    int visitors=int.Parse(input[i]);
                    if (letters.Count != 0)
                    {
                        char currentLetter = letters.Peek();

                        if(halls[currentLetter].Sum()+visitors>capacity)
                        {
                            Console.WriteLine($"{currentLetter} -> "+string.Join(", ",halls[currentLetter]));
                            halls.Remove(currentLetter);
                            letters.Dequeue();
                            if (letters.Count != 0)
                            { halls[letters.Peek()].Enqueue(visitors); }
                        }
                        else
                        {
                            halls[currentLetter].Enqueue(visitors);
                        }
                    }
                }
            }
        }
    }
}
