using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_10.___Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<List<string>, List<string>, List<string>> doublePeople = (a, b) =>
            {
                foreach (string doubled in b)
                {
                    for (int i = 0; i < a.Count * 2; i++)
                    {
                        if (i < a.Count)
                        {
                            if (a[i] == doubled)
                            {
                                a.Insert(i, doubled);
                                i++;
                            }
                        }
                    }
                }
                return a;
            };

            string command = Console.ReadLine();

            Func<string, string, bool> startsWith = (name, param) => name.StartsWith(param);
            Func<string, string, bool> endsWith = (name, param) => name.EndsWith(param);
            Func<string, int, bool> lengthFilter = (name, param) => name.Length == param;

            while (command != "Party!")
            {
                string[] currentCommand = command.Split().ToArray();

                if (currentCommand[0] == "Remove")
                {
                    if (names.Count != 0)
                    {
                        if (currentCommand[1] == "Length")
                        {
                            names = names
                                .Where(x => (!lengthFilter(x, int.Parse(currentCommand[2]))))
                                .ToList();
                        }
                        else if (currentCommand[1] == "StartsWith")
                        {
                            names = names
                                .Where(x => (!startsWith(x, currentCommand[2])))
                                .ToList();
                        }
                        else if (currentCommand[1] == "EndsWith")
                        {
                            names = names
                                .Where(x => (!endsWith(x, currentCommand[2])))
                                .ToList();
                        }
                    }
                }
                else if (currentCommand[0] == "Double")
                {
                    if (names.Count != 0)
                    {
                        if (currentCommand[1] == "Length")
                        {
                            names = names
                                .Where(x => (!lengthFilter(x, int.Parse(currentCommand[2]))))
                                .ToList();
                        }
                        else if (currentCommand[1] == "StartsWith")
                        {
                            names = names
                                .Where(x => (!startsWith(x, currentCommand[2])))
                                .ToList();
                        }
                        else if (currentCommand[1] == "EndsWith")
                        {
                            names = names
                                .Where(x => (!endsWith(x, currentCommand[2])))
                                .ToList();
                        }
                    }
                }
                command = Console.ReadLine();
            }

            if (names.Count != 0)
            {
                Console.WriteLine(string.Join(", ",names)+ " are going to the party!");
            }
            else Console.WriteLine("Nobody is going to the party!");
        }
    }
}
