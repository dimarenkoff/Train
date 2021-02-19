using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine diesel = new Engine("Diesel");
            Engine parni = new Engine("Steam");
            Person Kozakova = new Person("Lenka", "Kozakova");
            Person Novak = new Person("Karel", "Novak");
            Person Pohodlny = new Person("Zdenek", "Pohodlny");
            BusinessWagon b1 = new BusinessWagon(30,Kozakova);
            NightWagon n1 = new NightWagon(15);
            EconomyWagon e1 = new EconomyWagon(7);
            Hopper h1 = new Hopper(8000);
            Hopper h2 = new Hopper(10000);
            Locomotive lok1 = new Locomotive(Novak, diesel);
            Train vlak1 = new Train(lok1);
            vlak1.ConnectWagon(b1);
            vlak1.ConnectWagon(n1);
            vlak1.ConnectWagon(e1);
            vlak1.ConnectWagon(h1);
            vlak1.ConnectWagon(h2);
            

            BusinessWagon b2 = new BusinessWagon(30, Kozakova);
            NightWagon n2 = new NightWagon(15);
            EconomyWagon e2 = new EconomyWagon(57);
            Hopper h3 = new Hopper(8000);
            Hopper h4 = new Hopper(10000);
            Hopper h5 = new Hopper(10000);
            Locomotive Parni = new Locomotive(Pohodlny, parni);
            Train vlak2 = new Train(Parni);
            vlak2.ConnectWagon(b2);
            vlak2.ConnectWagon(n2);
            vlak2.ConnectWagon(e2);
            vlak2.ConnectWagon(h3);
            vlak2.ConnectWagon(h4);
            vlak2.ConnectWagon(h5);

            vlak1.ReserveChair(e1, 5);
            vlak1.AllReservedChairs();
            vlak1.ReserveChair(e1, 5);
            vlak1.ReserveChair(h1, 1);

            Console.WriteLine(vlak1);
            Console.WriteLine(vlak2);




        }
    }
}
