using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vLogger = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            //                         //vlogger //follower/following //name of the follower/following

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] currentCommand = command.Split();
                string name = currentCommand[0];

                if (currentCommand[1] == "joined")
                {
                    if (!vLogger.ContainsKey(name))
                    {
                        vLogger.Add(name, new Dictionary<string, HashSet<string>>());
                        vLogger[name].Add("followers", new HashSet<string>());
                        vLogger[name].Add("following", new HashSet<string>());
                        //creating followers and following for the current person
                    }
                }

                if (currentCommand[1] == "followed")
                {
                    string secondMember = currentCommand[2];

                    if (vLogger.ContainsKey(name) && vLogger.ContainsKey(secondMember) && name != secondMember)
                    {//checking if the names are different
                        vLogger[name]["following"].Add(secondMember);
                        vLogger[secondMember]["followers"].Add(name);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");

            int place = 1;

            foreach (var person in vLogger
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{place}. {person.Key} : {person.Value["followers"].Count} followers, {person.Value["following"].Count} following");

                if (place == 1)
                {
                    foreach (var follower in person.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }

                }
                place++;
            }

        }
    }
}
