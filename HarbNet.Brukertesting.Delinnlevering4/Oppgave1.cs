using Gruppe8.HarbNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarbNet.Brukertesting
{
    internal class Oppgave1
    {
        static void Main(string[] args)
        {
            // Opprett ett stort skip med navn "Titanic" for enkeltseilas, med 30 kontainere ombord.

            List<Ship> ships = new List<Ship>();

            
            Ship tatanic = new Ship("tatinac", ShipSize.Large, DateTime.Now, true, 4, 30);
            ships.Add(tatanic);


                

            // Opprett ett lite skip med navn "Bebop" for en 6 dagers tur retur seilas, med 10 kontainere ombord.



            // Opprett ett medium skip med navn "Den sorte dame" for 10 dagers tur retur seilas, med 20 kontainere.

            
        }
    }
}
