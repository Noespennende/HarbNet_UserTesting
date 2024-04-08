using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarbFramework;
using harbNet;

namespace Harbnet_brukertesting
{
    internal class Oppgave4
    {
        static void Main(string[] args)
        {
           Ship denSorteDame = new Ship ("Den Sorte Dame", ShipSize.Medium, DateTime.Now, false, 5, 20);
           Ship titanic = new Ship("Titanic", ShipSize.Large, DateTime.Now, true, 10, 30);
           Ship bebop = new Ship("Bebop", ShipSize.Small, DateTime.Now, false, 4, 10);

           IList<Ship> shipList = new List<Ship>();

           shipList.Add( denSorteDame );
           shipList.Add( titanic );    
           shipList.Add( bebop );

           Harbor kjuttaviga = new Harbor(shipList, 4, 4, 4, 4, 4, 4, 4, 4, 4);

            // Kjør en simulering på havnen og skipene gitt ovenfor fra dagens dato og 2 uker frem i tid. 

            HarbFramework.Simulation minSimulasjon = new Simulation(kjuttaviga, DateTime.Now, DateTime.Now.Date.AddDays(14));
            minSimulasjon.Run();
        }
    }
}
