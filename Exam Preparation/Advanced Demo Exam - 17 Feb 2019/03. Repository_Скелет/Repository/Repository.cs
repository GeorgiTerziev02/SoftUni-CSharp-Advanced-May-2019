using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private List<Person> data;

        public int Count
        {
            get { return this.data.Count; }
        }
        public Repository()
        {
            this.data = new List<Person>();
        }

        public void Add(Person person)
        {
            this.data.Add(person);
        }

        public Person Get(int id)
        {
            return data[id];
        }

        public bool Update(int id, Person newPerson)
        {
            if (id >= 0 && id < data.Count)
            {
                data[id] = newPerson;
                return true;
            }
            else return false;
        }

        public bool Delete(int id)
        {
            if (id >= 0 && id < data.Count)
            {
                data.RemoveAt(id);
                return true;
            }
            else return false;

        }

    }
}
