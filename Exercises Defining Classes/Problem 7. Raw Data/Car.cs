using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        private string model;
        private Cargo cargo;
        private Engine engine;
        private Tire[] tire;

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.model=model;
            this.engine=engine;
            this.cargo=cargo;
            this.tire=tires;
        }

        public string Model
        {
            get { return this.model; }
        }

        public Engine Engine
        {
            get { return this.engine; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
        }

        public Tire[] Tire
        {
            get { return this.tire; }
        }
    }
}
