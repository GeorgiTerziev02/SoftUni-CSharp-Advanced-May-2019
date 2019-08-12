using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age)
            :this()
        {
            Age = age;
        }

        public Person(string name,int age)
            :this(age)
        {
            Name = name;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        
        public void Over30ty()
        {
            if (Age > 30)
                Console.WriteLine($"{Name} - {Age}");
        }

    }
}
