using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Hopper
    {
        private double loadingCapacity;

        public double LoadingCapacity { get => loadingCapacity; set => loadingCapacity = value; }
        public Hopper(double capacity) { this.loadingCapacity = capacity; }
        public override string ToString() { return "Je to " + this.GetType().Name + ", kapacita: " + this.loadingCapacity; }
       
    }
}
