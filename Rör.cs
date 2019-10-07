    namespace Multifabriken
    {
    public class Rör
    {
        //Konstruktor
        public Rör(string material, double diameter, double length)
        {
            Material = material;
            Diameter = diameter;
            Length = length;
        }

        //Properties
        public string Material;
        public double Diameter; 
        public double Length;
    }
    }