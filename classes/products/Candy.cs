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
            int[] weight = new int[]{7,4,5,6,7,2,6};
            int selection= Menu.DisplayMenu(flavours,"");
            Weight = weight[selection];
            Flavour = flavours[selection];



        }
    }
}