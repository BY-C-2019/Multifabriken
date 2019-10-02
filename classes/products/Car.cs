using System;
namespace Multifabriken
{
    public class Car : Product 
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public bool LuxuryInteriour { get; set; }
        
        public Car()
        {
            string[] carBrands = new string[]{"Vas lada","Honda","Volvo","MeserSchmidt","Saab","Audi","Wolkswagen","Lotus"};
            string[] colors = new string[]{"Svart","Vit","Grön","Gul","Rosa","Orange","Blå","Silvermetallic"};

            Brand= carBrands[Menu.DisplayMenu(carBrands,"")];            
            Color = colors[Menu.DisplayMenu(colors,"")];
            LuxuryInteriour = Menu.YesOrNo("Vill du ha lyxpaketet?");
        }
    }
}
