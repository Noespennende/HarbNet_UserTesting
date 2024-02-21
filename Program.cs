using HarbFramework;
using harbNet;

namespace Harbnet_brukertesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship("Den sorte Dame", ShipSize.Large, DateTime.Now, true, 6, 10);
        }
    }
}
