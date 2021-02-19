using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Chair
    {
        private int number;
        private bool nearWindow;
        private bool reserved;
        public Chair() { }
        public Chair(int number) { this.number = number;this.reserved = false; }

        public bool Reserved { get => reserved; set => reserved = value; }
        public bool NearWindow { get => nearWindow; set => nearWindow = value; }
        public int Number { get => number; set => number = value; }
        public override string ToString() { return "Misto: " + this.number; }
    }
}
