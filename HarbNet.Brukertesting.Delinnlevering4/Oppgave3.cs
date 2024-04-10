using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gruppe8.HarbNet;

namespace HarbNet.Brukertesting
{
    internal class Oppgave3
    {
        static void Main(string[] args)
        {
            /* 
             * ** Havn-detaljer **
             * 6 Loading docks - 2 små, 3 medium, 1 stor
             * 3 Ship docks - 2 medium, 1 stor
             * 4 Loading dock kraner
             * 2 Lagringsplass kraner
             * 30 ADV-er
             * - En kran tar 20 lastinger per time
             * - En ADV tar 15 lastinger per time
             * 10 Trucker kommer til havnen hver time
             * 10% av containerne lastes dirkete på trucker fra skip
             * 20% av containerne lastes på trucker fra lagringsplass
             */

            /* ** OPPGAVE 3 ** */

            // Lag en havn med de spesifiserte detaljene ovenfor.
            // Du kan ta i bruk eksisterende lister og objekter nedenfor.

            List<ContainerStorageRow> storageArea = [];
            List<Ship> ships = new();

            for (int i = 0; i < 15; i++)
            {
                storageArea.Add(new ContainerStorageRow(10));
            }

            Ship titanic = new("Titanic", ShipSize.Large, DateTime.Now, true, 7, 30, 70);
            Ship mcBoatFace = new("Boaty McBoatFace", ShipSize.Medium, DateTime.Now, false, 5, 10, 40);
            Ship denSorteDame = new("Den sorte dame", ShipSize.Small, DateTime.Now, true, 5, 0, 20);

            ships.AddRange(new List<Ship> {titanic, mcBoatFace, denSorteDame});

            /* !! Svar på oppgaven under her !! */

            

        }
    }
}
