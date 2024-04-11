using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gruppe8.HarbNet;

namespace HarbNet.Brukertesting
{
    internal class Oppgave4
    {
        static void Main(string[] args)
        {

            /* ** OPPGAVE 4 ** */

            // Opprett en simulasjon, med startdato 10.04.2024 kl 00:00, og sluttdato 10.05.2024 kl 00:00.
            // Simuleringen skal simulere det gitte havn-objektet.

            List<ContainerStorageRow> storageArea = [];
            List<Ship> ships = new();

            for (int i = 0; i < 15; i++)
            {
                storageArea.Add(new ContainerStorageRow(10));
            }

            Ship titanic = new("Titanic", ShipSize.Large, DateTime.Now, true, 7, 30, 70);
            Ship mcBoatFace = new("Boaty McBoatFace", ShipSize.Medium, DateTime.Now, false, 5, 10, 40);
            Ship denSorteDame = new("Den sorte dame", ShipSize.Small, DateTime.Now, true, 5, 0, 20);

            ships.AddRange(new List<Ship> { titanic, mcBoatFace, denSorteDame });

            Harbor kjuttavika = new(ships, storageArea, 2, 3, 1, 4, 20, 2, 0, 2, 1, 10, 10, 20, 30, 15);

            /* !! Svar på oppgaven under her !! */

            Gruppe8.HarbNet.Simulation simulation = new Simulation(kjuttavika, new DateTime(2024, 04, 10), new DateTime(2024, 05, 10));


        }
    }
}
