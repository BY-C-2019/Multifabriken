using System;
namespace Multifabriken
{
    public class Car : Product 
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public bool LuxuryInteriour { get; set; }
        
        public override string ToString()
        {
                if(LuxuryInteriour)
                {
                    return "Modell: "+ Brand+ "\nFärg: "+Color+ "Lyxutrustad: Ja";
                }
                else
                {
                       return "Modell: "+ Brand+ "\nFärg: "+Color+ "\nLyxutrustad: Nej";
                }
                
        }
        public Car()
        {
            Price = 120000;            
            string[] carBrands = new string[]{"Vas lada","Honda","Volvo","MeserSchmidt","Saab","Audi","Wolkswagen","Lotus"};
            string[] colors = new string[]{"Svart","Vit","Grön","Gul","Rosa","Orange","Blå","Silvermetallic"};

            Brand= carBrands[Menu.DisplayMenu(carBrands,"")];            
            Color = colors[Menu.DisplayMenu(colors,"")];
            Name = Color + " " + Brand;
            LuxuryInteriour = Menu.YesOrNo("Vill du ha lyxpaketet?");
            Price += (LuxuryInteriour) ? 15000 : 0 ;
        }
    }
}
