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
                string[] lengths = new string[]{"0.5","1.0","2.0","3.0"};
                Material = materials[Menu.DisplayMenu(materials,"")];
                Length = Convert.ToDouble(lengths[Menu.DisplayMenu(lengths,"")]);
        }
    }
}