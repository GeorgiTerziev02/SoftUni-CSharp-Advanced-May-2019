using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var submissions = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while(input!="end of contests")
            {
                string[] tokens = input.Split(':');
                string contestName = tokens[0];
                string password = tokens[1];

                contests.Add(contestName,password);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input!="end of submissions")
            {
                string[] tokens = input.Split("=>");
                string contestName = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if(contests.ContainsKey(contestName))
                {
                    if(contests[contestName]==password)
                    {
                        if (submissions.ContainsKey(username))
                        {
                            if (!submissions[username].ContainsKey(contestName))
                            {
                                //submissions.Add(username, new Dictionary<string, int>());
                                submissions[username].Add(contestName, points);
                            }
                            else
                            {
                                if (submissions[username][contestName] < points)
                                {
                                    submissions[username][contestName] = points;
                                }
                            }
                        }
                        else
                        {
                            submissions.Add(username, new Dictionary<string, int>());
                            submissions[username].Add(contestName, points);
                        }
                    }

                }

                input = Console.ReadLine();

            }

            var bestCandidate = submissions
                .OrderByDescending(x => x.Value.Values.Sum())
                .FirstOrDefault();

            string bestName = bestCandidate.Key;
            int topPoints = bestCandidate.Value.Values.Sum();

            Console.WriteLine($"Best candidate is {bestName} with total {topPoints} points.");

            Console.WriteLine("Ranking:");
            foreach (var submission in submissions.OrderBy(x=>x.Key))
            {
                Console.WriteLine(submission.Key);

                foreach (var contest in submission.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }

        }
    }
}
