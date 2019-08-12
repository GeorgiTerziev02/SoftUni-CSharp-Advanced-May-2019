using System;
using System.Collections.Generic;

namespace Problem_1._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            //no guaranteed order
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string currentName = Console.ReadLine();
                names.Add(currentName);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
