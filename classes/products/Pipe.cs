using System;
namespace Multifabriken
{
    public class Pipe : Product
    {
        public string Material { get; set; }

        public double Length { get; set; }

        public double Diameter { get; set; }
        public Pipe()
        {
            string[] materials = new string[]{"Plast","Järn","Betong"};
            
            Material = materials[Menu.DisplayMenu(materials,"Välj material:")];
            Length = Menu.MenuForAmount("Hur långt skall ditt rör vara? ", 15, false);
            Diameter = Menu.MenuForAmount("Vilken diameter skall ditt rör ha? ", 1.5, true);
            Name = Material + "rör";
            Price = this.CalculatePrice();
        }
        private decimal CalculatePrice() {
            int pricePerMeter = 0;
            if (Material == "Plast") {
                pricePerMeter = 10;
            }
            else if (Material == "Järn") {
                pricePerMeter = 50;
            }
            else if (Material == "Betong") {
                pricePerMeter = 1000;
            }

            return Convert.ToDecimal(pricePerMeter * Length * Diameter);
        }
        public override string ToString()
        {
            string output = $"{Name}. Längd: {Length}. Diameter: {Diameter}. Pris: {CalculatePrice()}";


            return output;
        }

    }
}