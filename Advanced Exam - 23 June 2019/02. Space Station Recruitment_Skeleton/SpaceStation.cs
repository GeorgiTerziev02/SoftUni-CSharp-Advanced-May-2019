using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> data;

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count
        {
            get { return this.data.Count; }
        }

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            this.data = new List<Astronaut>();
        }

        public void Add(Astronaut astronaut)
        {
            if (this.data.Count + 1 <= this.Capacity)
            {
                data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {

            foreach (var ast in this.data)
            {
                if(ast.Name==name)
                {
                    data.Remove(ast);
                    return true;
                }

            }

            return false;
        }


        public Astronaut GetOldestAstronaut()
        {
            Astronaut oldest = this.data.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldest;
        }



        public Astronaut GetAstronaut(string name)
        {
            Astronaut ast = this.data.FirstOrDefault(x => x.Name == name);

            return ast;
        }









        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Astronauts working at Space Station {this.Name}");

            foreach (var astronaut in data)
            {
                sb.AppendLine(astronaut.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
