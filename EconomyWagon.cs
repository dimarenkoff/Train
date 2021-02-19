using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class EconomyWagon:PersonalWagon
    {
        public EconomyWagon(int number ) { this.NumberOfChairs = number; for (int i = 1; i <= number; i++) { this.Seats.Add(new Chair(i)); } }
        public override string ToString() { return "Je to "+this.GetType().Name + " Pocet sedadel: " + this.NumberOfChairs; }
    }
}
