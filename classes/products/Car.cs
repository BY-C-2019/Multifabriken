using System;
namespace Multifabriken
{
    public class Car : Product 
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public bool LuxuryInteriour { get; set; }

        Car() :base()
        {
      
            string[] carBrands = new string[]{"Vas lada","Honda","Volvo","MeserSchmidt","Saab","Audi","Wolkswagen","Lotus"};
            Brand= carBrands[Menu.DisplayMenu(carBrands,"")];
            string[] colors = new string[]{"Svart","Vit","Grön","Gul","Rosa","Orange","Blå","Silvermetallic"};
            Color = colors[Menu.DisplayMenu(colors,"")];
            LuxuryInteriour = Menu.YesOrNo("Vill du ha lyxpaketet?");

        }
        
    }
}