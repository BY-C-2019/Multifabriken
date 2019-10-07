using System;

namespace Multifabriken
{
public class Havremjölk
    {
        //Skapar konstruktor som sätter standardvärde på objektet när de skapas.
        public Havremjölk (int fetthalt, double volym)
        {
            Fetthalt = fetthalt;
            Volym = volym;
        }

        //properties
        public int Fetthalt;
        public double Volym;

    }
}