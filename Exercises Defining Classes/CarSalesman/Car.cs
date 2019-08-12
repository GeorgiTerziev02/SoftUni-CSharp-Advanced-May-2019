using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine, string weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model= value; }
        }
        public string Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

    }
}
