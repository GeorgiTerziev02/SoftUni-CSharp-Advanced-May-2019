using System;
using System.Collections.Generic;

namespace Problem5ComparingObects
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                Person newPerson = new Person(name, age, town);

                people.Add(newPerson);

                input = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            int countOfMathches = 1;
            int countOfNotEqual = 0;

            Person targetPerson = people[n - 1];

            foreach (var person in people)
            {
                if (targetPerson == person)
                {
                    continue;
                }

                if (person.CompareTo(targetPerson) == 0)
                {
                    countOfMathches++;
                }
                else
                {
                    countOfNotEqual++;
                }
            }

            if (countOfMathches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMathches} {countOfNotEqual} {people.Count}");
            }
        }
    }
}
