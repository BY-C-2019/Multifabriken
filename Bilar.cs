using System;
namespace Multifabriken
{
    public class Bilar
    {
        public Bilar (int model, int color, string interior)
        {
            Model = model;
            Color = color;
            Interor = interior;
        }

        public int Model; //Efter val 
        public int Color; //int pga färgkod
        public string Interor; //antingen lyx eller standard

    }
}