using System;
namespace Multifabriken
{
    public class Godis
    {
        //Metod för att välja godistyp
        public static string candyMenu()
        {

            do
            {
                Console.WriteLine("Vilken typ av godis vill du ha?");
                Console.WriteLine("1. Hallon");
                Console.WriteLine("2. Lakris");
                Console.WriteLine("3. Jordgubb");
                Console.WriteLine("4. Päron");
                string flavourChoise = Console.ReadLine();
                string flavour = flavourChoise.ToUpper();
                switch (flavour)
                {
                    case "HALLON":
                        return flavour;

                    case "LAKRIS":
                        return flavour;

                    case "JORDGUBB":
                        return flavour;

                    case "PÄRON":
                        return flavour;
                } while (flavour == "HALLON" || flavour == "LAKRIS" || flavour == "PÄRON") ;


                // Console.WriteLine("Vilken typ av godis vill du ha?");
                // Console.WriteLine("1. Hallon");
                // Console.WriteLine("2. Lakris");
                // Console.WriteLine("3. Jordgubb");
                // Console.WriteLine("4. Päron");
                // string flavourChoise = Console.ReadLine();
                // string flavour = flavourChoise.ToUpper();
                // switch (flavour){
                //     case "HALLON":
                //         return flavour;

                //     case "LAKRIS":
                //         return flavour;

                //     case "JORDGUBB":
                //         return flavour;

                //     case "PÄRON":
                //         return flavour;

                //     default:
                //         Console.WriteLine("Ange endast smakerna som erbjuds");
                //         return "";


                // }
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