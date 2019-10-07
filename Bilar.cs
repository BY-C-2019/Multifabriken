using System;
namespace Multifabriken
{
    
    public class Bilar
    {
        //Metod för att välja modell på bilen
        public static int carModel()
        {
            Console.WriteLine("Vilken bilmodell vill du ha?");
            Console.WriteLine("1. Volvo");
            Console.WriteLine("2. Saab");
            Console.WriteLine("3. Ford");
            string modelChoise = Console.ReadLine(); //try catch
            int model = 0;
            try{
                model = Convert.ToInt32(modelChoise);
            }catch{
                Console.WriteLine("Ange endast siffervärde på bilen");
            }
            return model;
        }
                //Metod för att välja färg på bilen 
        public static int carColor()
        {
            Console.WriteLine("Vilken färg ska bilen ha? Mata in din färgkod i hex värde: ");
            string colorChoise = Console.ReadLine();
            int color = 00000000;
            try {
                color = Convert.ToInt32(colorChoise);
            }catch{
                Console.WriteLine("Skriv endast siffervärde på hexfärgen");
            }
            return color;
        }
                //Metod för att välja lyx eller interiör
        public static string carInterior()
        {
            Console.WriteLine("Välj din inredning:");
            Console.WriteLine("1. Lyx");
            Console.WriteLine("2. Standard");
            string interiorChoise = Console.ReadLine();
            
            return interiorChoise;
        }
        public int modell; 
        public int färg; //int pga färgkod
        public int inredning; //antingen lyx eller standard

    }
}