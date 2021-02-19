using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Train
    {
        private List<object> conectedWagons = new List<object>();
        private List<Chair> listReservedChairs = new List<Chair>(); 
        private Locomotive locomotive;

        public List<object> ConectedWagons { get => conectedWagons; set => conectedWagons = value; }
        internal Locomotive Locomotive { get => locomotive; set => locomotive = value; }
        internal List<Chair> ListReservedChairs { get => listReservedChairs; set => listReservedChairs = value; }

        public void AllReservedChairs()
        {
            string s = "Reservovana mista: ";
           
                foreach (Chair sedadlo in listReservedChairs)
                {
                    s += sedadlo;
                }
            Console.WriteLine(s);
        }
        public void ReserveChair(Object vagon, int number)
        {
            if (vagon is PersonalWagon)
            {
                if ((vagon as PersonalWagon).Seats[number].Reserved != true)
                {
                    this.listReservedChairs.Add((vagon as PersonalWagon).Seats[number]);
                    (vagon as PersonalWagon).Seats[number].Reserved = true;
                }
                else { Console.WriteLine("Misto je obsazene"); }
                
            }
            else { Console.WriteLine("Vagon neni urcen pro pasazery"); }}
        public void ConnectWagon(Object wagon)
        {
            if ((this.Locomotive.Engine.Type == "Steam") && (this.ConectedWagons.Count < 5)){ this.ConectedWagons.Add(wagon); }
            else if (this.Locomotive.Engine.Type != "Steam") { this.ConectedWagons.Add(this); }
            else if ((this.Locomotive.Engine.Type == "Steam") && (this.ConectedWagons.Count == 5)) { Console.WriteLine("Parni lokomotiva nesmi mit vic jak 5 vagonu!"); }
        } 

        public void DisconnectWagon(Object wagon) { foreach (Object z in this.ConectedWagons) { if (z == this) { this.ConectedWagons.Remove(this); } else { Console.WriteLine("Tento vagon neni napojen na tuto lokomativu!"); } } }
        public override string ToString() { string vagony = ""; foreach (Object z in this.ConectedWagons) { vagony += z.GetType().Name + ", "; } return this.locomotive + ", pripojene vagony: " + vagony; }
        
        public Train(Locomotive lok) { this.locomotive = lok; }
        public Train(Locomotive lok,  List<Object> list) { this.locomotive = lok; }//??
    }
}
