using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gruppe8.HarbNet;

namespace HarbNet.Brukertesting
{
    internal class Oppgave5Fasit
    {
        static void Main(string[] args)
        {
            /* ** TENKT SVAR TIL OPPGAVE 5 ** */

            static void HandleEvent(object? sender, EventArgs e)
            { }

            List<ContainerStorageRow> storageArea = [];
            List<Ship> ships = new List<Ship>();

            for (int i = 0; i < 15; i++)
            {
                storageArea.Add(new ContainerStorageRow(10));
            }

            Ship titanic = new Ship("Titanic", ShipSize.Large, DateTime.Now, true, 7, 30, 70);
            Ship mcBoatFace = new Ship("Boaty McBoatFace", ShipSize.Medium, DateTime.Now, false, 5, 10, 40);
            Ship denSorteDame = new Ship("Den sorte dame", ShipSize.Small, DateTime.Now, true, 5, 0, 20);

            ships.AddRange(new List<Ship> { titanic, mcBoatFace, denSorteDame });

            Harbor kjuttavika = new(ships, storageArea, 2, 3, 1, 4, 20, 2, 0, 2, 1, 10, 10, 20, 30, 15);

            DateTime startTime = new DateTime(2024, 4, 10, 0, 0, 0);
            DateTime endTime = new DateTime(2024, 5, 10, 0, 0, 0);

            Simulation simulasjon = new(kjuttavika, startTime, endTime);

            /* !! Svar på oppgaven under her !! */

            simulasjon.ShipAnchoring += HandleEvent;
            simulasjon.ShipUnloadedContainer += HandleEvent;
            simulasjon.TruckLoadingFromStorage += HandleEvent;
            simulasjon.OneHourHasPassed += HandleEvent;
            simulasjon.DayLoggedToSimulationHistory += HandleEvent;

        }
    }
}