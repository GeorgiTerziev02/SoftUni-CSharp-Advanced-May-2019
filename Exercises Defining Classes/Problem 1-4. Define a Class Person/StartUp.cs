using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] memberData = Console.ReadLine().Split();

                int memberAge = int.Parse(memberData[1]);
                string memberName = memberData[0];

                Person member = new Person(memberName, memberAge);

                people.Add(member);
            }

            foreach (Person person in people.OrderBy(x=>x.Name))
            {
                person.Over30ty();
            }
        }
    }
}
