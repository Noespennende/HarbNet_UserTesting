﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarbFramework;
using harbNet;

namespace Harbnet_brukertesting
{
    internal class Oppgave3
    {
        static void Main(string[] args)
        {
            Ship denSorteDame = new Ship ("Den Sorte Dame", ShipSize.Medium, DateTime.Now, false, 5, 20);

            Ship titanic = new Ship("Titanic", ShipSize.Large, DateTime.Now, true, 10, 30);

            Ship bebop = new Ship("Bebop", ShipSize.Small, DateTime.Now, false, 4, 10);

            // Lag en havn som inneholder skipene gitt ovenfor:


        }
    }
}
