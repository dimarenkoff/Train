using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Locomotive
    {
        
        
        private Person driver;
        private Engine engine;

        public Person Driver { get => driver; set => driver = value; }
        internal Engine Engine { get => engine; set => engine = value; }
        public Locomotive(string typ) { this.engine.Type = typ; }
        public Locomotive(Person driver, Engine engine) { this.Driver = driver; this.Engine = engine; }
        //public Locomotive(string name, string surname, string engine) { this.driver.FirstName = name;this.driver.LastName = surname;this.Engine.Type = engine; }
        public override string ToString() { return "Lokomotiva ma ridice: " + Driver + " Motor typu: " + Engine; }

    }
}
