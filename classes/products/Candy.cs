using System;
namespace Multifabriken
{
    public class Candy : Product
    {
        public double Weight { get; set; }
        public string Flavour { get; set; }
        public Candy()
        {
            string[] flavours = new string[]{"Choklad","Mint","Lakrits","Hallon","Jordgubb","Salmiak","Päron"};
            
            //weight in kilo            
            int selection= Menu.DisplayMenu(flavours, "Välj smak: ");
            Flavour = flavours[selection];
            Weight = Menu.MenuForAmount("Hur många kg " + Flavour + "godis vill du ha? ", -1, false);
            Name = Flavour + "godisar";
            Price = Convert.ToDecimal(79 * Weight);
        }

        public override string ToString()
        {
            return $"{Name}, Smak: {Flavour}, Mängd: {Weight} kg.";
        }
    }
}