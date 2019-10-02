using System;
namespace Multifabriken
{
    public class Car : Product 
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public bool LuxuryInteriour { get; set; }
<<<<<<< HEAD

        Car() :base()
        {
      
            string[] carBrands = new string[]{"Vas lada","Honda","Volvo","MeserSchmidt","Saab","Audi","Wolkswagen","Lotus"};
=======
        
        Car() :base()
        {
            string[] carBrands = new string[]{"Vas lada","Honda","Volvo","MeserSchmidt","Saab","Audi","Wolkswagen","Lotus"};
            string[] colors = new string[]{"Svart","Vit","Grön","Gul","Rosa","Orange","Blå","Silvermetallic"};

>>>>>>> 6a758d34dfd4793f380ee1d946959b551ea40e0e
            Brand= carBrands[Menu.DisplayMenu(carBrands,"")];
            string[] colors = new string[]{"Svart","Vit","Grön","Gul","Rosa","Orange","Blå","Silvermetallic"};
            Color = colors[Menu.DisplayMenu(colors,"")];
<<<<<<< HEAD
            LuxuryInteriour = Menu.YesOrNo("Vill du ha lyxpaketet?");

=======
            Console.WriteLine("Önskas lyxinredning?");
            
            LuxuryInteriour = Menu.YesOrNo("Vill du ha lyxpaketet?");
>>>>>>> 6a758d34dfd4793f380ee1d946959b551ea40e0e
        }
        
    }
}