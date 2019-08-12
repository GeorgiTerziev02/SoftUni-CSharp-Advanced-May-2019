using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private string emodel;
        private string power;
        private string displacement;
        private string efficiency;

        public Engine(string emodel, string power, string displacement,string efficiency)
        {
            this.emodel = emodel;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public string Power
        {
            get { return this.power; }
            set { this.power = value; }
        }
        public string EModel
        {
            get { return this.emodel; }
            set { this.emodel = value; }
        }
        public string Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }
        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }


    }
}
