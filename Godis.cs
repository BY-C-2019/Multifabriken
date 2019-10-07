using System;
namespace Multifabriken
{
    public class Godis
    {
        //Metod för att välja godistyp
        public static string candyMenu()
        {   
            bool loop = true;
            string val = "";

            while(loop) {
                Console.WriteLine("Vilken typ av godis vill du ha?");
                Console.WriteLine("1. Hallon");
                Console.WriteLine("2. Lakris");
                Console.WriteLine("3. Jordgubb");
                Console.WriteLine("4. Päron");
                string input = Console.ReadLine();
                int inmatning = 5;
                try{
                inmatning = Convert.ToInt32(input);
                }catch{
                    Console.WriteLine("Mata endast in siffervärde");
                }
                if (inmatning>4)
                {
                    Console.WriteLine("Fel inmatning testa igen");
                } else
                {
                    switch (inmatning) {
                        case 1:
                        loop = false;
                        val = "Hallon";
                        break;
                        case 2:
                        loop = false;
                        val =  "Laktris";
                        break;
                        case 3:
                        loop = false;
                        val = "Jordgubb";
                        break;
                        case 4:
                        loop = false;
                        val = "Päron";
                        break;
                        default:
                        break;
                    }  
                }
            }
                return val; 
}
        //Konstruktor
        public Godis (string flavour, double weight)
            {
                Smak = flavour;
                Vikt = weight;
            }

        //Properties
        public string Smak;
        public double Vikt;
    }
}