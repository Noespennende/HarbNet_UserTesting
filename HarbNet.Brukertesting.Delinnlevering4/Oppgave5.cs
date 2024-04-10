using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gruppe8.HarbNet;

namespace HarbNet.Brukertesting
{
    internal class Oppgave5
    {
        static void Main(string[] args)
        {
            /* ** OPPGAVE 5 ** */

            /* Abonner på eventer for følgende hendelser:
             * 1. Når et skip ankrer
             * 2. Når et skip laster av en container
             * 3. Når en truck laster på en container fra lagringsplass
             * 4. Når en time har passert
             * 5. Når en dag er passert og logget i simuleringens historie
             * 
             * Du kan ta i bruk HandleEvent ved abonnering. ( += HandleEvent; )
             * 
             * Syntaks er ikke viktig.
             * 
            */

            static void HandleEvent(object? sender, EventArgs e)
            { }

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

            DateTime startTime = new(2024, 4, 10, 0, 0, 0);
            DateTime endTime = new(2024, 5, 10, 0, 0, 0);

            Simulation simulasjon = new(kjuttavika, startTime, endTime);


            /* !! Svar på oppgaven under her !! */



        }
    }
}
