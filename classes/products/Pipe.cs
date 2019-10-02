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
            string[] lengths = new string[]{"0,5","1,0","2,0","3,0"};
            string[] diameters =  {"0,1", "0,5", "1,0", "15,5"};
            Material = materials[Menu.DisplayMenu(materials,"Välj material:")];
            Length = Convert.ToDouble(lengths[Menu.DisplayMenu(lengths,"Välj längd:")]);
            Diameter = Convert.ToDouble(diameters[Menu.DisplayMenu(diameters, "Välj diameter: ")]);
            Name = Material + "rör: " + Length + " meter.";
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
    }
}