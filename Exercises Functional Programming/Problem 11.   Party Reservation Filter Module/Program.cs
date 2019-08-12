using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_11.___Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split()
                .ToArray();

            string filter = Console.ReadLine();

            List<string> filters = new List<string>();

            while (filter != "Print")
            {
                string[] filterInfo = filter.Split(';');

                string action = filterInfo[0];

                if (action == "Add filter")
                {
                    filters.Add($"{filterInfo[1]};{filterInfo[2]}");
                }
                else if (action == "Remove filter")
                {
                    filters.Remove($"{filterInfo[1]};{filterInfo[2]}");
                }

                filter = Console.ReadLine();
            }

            for (int i = 0; i < filters.Count; i++)
            {
                string[] currentFilter = filters[i].Split(';');

                string action = currentFilter[0];
                string parameter = currentFilter[1];

                if(action=="Length")
                {
                    Predicate<string> lengthFilter = name => name.Length != int.Parse(parameter);
                    names = names
                        .Where(x => lengthFilter(x))
                        .ToArray();
                }
                else if (action == "Starts with")
                {
                    Func<string,string,bool> startsWithFilter = (name,param) => name.StartsWith(param);
                    names = names
                        .Where(x => startsWithFilter(x,parameter)==false)
                        .ToArray();
                }
                else if(action=="Contains")
                {
                    Func<string, string, bool> containsFilter = (name, param) => name.Contains(param);
                    names = names
                        .Where(x => containsFilter(x, parameter) == false)
                        .ToArray();
                }
                else if(action=="Ends with")
                {
                    Func<string, string, bool> endsWithFilter = (name, param) => name.EndsWith(param);
                    names = names
                        .Where(x => endsWithFilter(x, parameter) == false)
                        .ToArray();
                }
            }

            Console.WriteLine(string.Join(" ",names));
        }
    }
}
