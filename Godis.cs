using System;
namespace Multifabriken
{
public class Godis
    {
        //Konstruktor
        public Godis (int flavour, double weight)
        {
            Smak = flavour;
            Vikt = weight;
        }

        //Properties
        public int Smak;
        public double Vikt;
    }
}