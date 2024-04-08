using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gruppe8.HarbNet;

namespace Harbnet_brukertesting
{
    internal class Oppgave7
    {
        static void Main(string[] args)
        {

           //Forklar hver linje med kode gitt under:

           Ship denSorteDame = new Ship ("Den Sorte Dame", ShipSize.Medium, DateTime.Now, false, 5, 20);

           Ship titanic = new Ship("Titanic", ShipSize.Large, DateTime.Now, true, 10, 30);

           Ship bebop = new Ship("Bebop", ShipSize.Small, DateTime.Now, false, 4, 10);

           IList<Ship> shipList = new List<Ship>();

           shipList.Add( denSorteDame );
           shipList.Add( titanic );    
           shipList.Add( bebop );

           Harbor kjuttaviga = new Harbor(shipList, 4, 4, 4, 4, 4, 4, 4, 4, 4);

           Simulation simulering = new Simulation(kjutstaviga, DateTime.Now, DateTime.Now.AddDays(7));

            simulering.Run();

            simulering.PrintContainerHistory();

            simulering.PrintShipHistory();

            denSorteDame.PrintHistory();

            IList<Log> logList = simulering.History;

            logList[0].PrintInfoForAllShips();

            logList[0].PrintInfoForAllContainers();

        }
    }
}
