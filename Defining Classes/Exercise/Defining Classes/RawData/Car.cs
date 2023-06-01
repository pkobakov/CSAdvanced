using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        //Model: a string property
        //Engine: a class with two properties – speed and power,
        //Cargo: a class with two properties – type and weight
        //Tires: a collection of exactly 4 tires.Each tire should have two properties: age and pressure.

        private string model;
        private Engine engine;
        private Cargo cargo;
        public Car( string model, Engine engine, Cargo cargo, Tire[] tires) 
        { 
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;

        
        }

        public string Model { get { return model; } set { model = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Cargo Cargo { get {  return cargo; } set {  cargo = value; } }
        public Tire[] Tires { get; set; }

    }
}
