using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class BusinessWagon:PersonalWagon
    {
        private Person steward;
        public BusinessWagon() { }
        public BusinessWagon(int number, Person steward) { this.NumberOfChairs = number; this.steward = steward; }
        //public BusinessWagon(int number,string name, string surname) { this.NumberOfChairs = number; this.steward.FirstName = name;this.steward.LastName = surname; }
        public Person Steward { get => steward; set => steward = value; }

        public override string ToString() { return "Je to " + this.GetType().Name + " Pocet sedadel " + this.NumberOfChairs + " Stewar: " + this.Steward; }

    }
}
