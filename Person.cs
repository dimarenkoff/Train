using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Person
    {
        private string firstName;
        private string lastName;

       

        public Person(string name,string surname) { this.FirstName = name;this.LastName = surname; }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public override string ToString() { return FirstName + " " + LastName; }
    }
}
