using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class PersonalWagon
    {
        private List<Door> doors = new List<Door>();
        private List<Chair> seats = new List<Chair>();
        private int numberOfChairs;

        public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }
        internal List<Chair> Seats { get => seats; set => seats = value; }
        internal List<Door> Doors { get => doors; set => doors = value; }

        public PersonalWagon(int number) { this.NumberOfChairs = number;for (int i = 1; i <= numberOfChairs; i++) { seats.Add(new Chair(i)); } }
        public PersonalWagon() { }
    }

}

