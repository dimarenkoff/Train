using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class NightWagon:PersonalWagon
    {
        private List<Bed> beds = new List<Bed>();   
        private int numberOfBeads;

        public int NumberOfBeads { get => numberOfBeads; set => numberOfBeads = value; }
        internal List<Bed> Beds { get => beds; set => beds = value; }

        public NightWagon() { }
        public NightWagon(int number) { this.numberOfBeads = number; }
        public override string ToString() { return "Je to " + this.GetType().Name + ", pocet spacichmist: " + this.numberOfBeads + ", pocet sedadel: " + this.NumberOfChairs; }

    }
}
