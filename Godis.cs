using System;
namespace Multifabriken
{
    class Godis
    {
        private static string vikt = "";
        private static string smak = "";

        public string Vikt
        {
            get
            {
                return vikt;
            }
            set
            {
                vikt = value;
            }
        }
        public string Smak
        {
            get
            {
                return smak;
            }
            set
            {
                smak = value;
            }
        }
        public static void AddGodis()
        {
            string input;

            bool loop = false;

            while (!loop)
            {
                Console.WriteLine("Välj smak");
                Console.WriteLine("[1] Hallon");
                Console.WriteLine("[2] Jordgubb");
                Console.WriteLine("[3] Lakris");
                input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":
                        smak = "Hallon";
                        loop = true;
                    break;

                    case "2":
                        smak = "Jordgubb";
                        loop = true;
                    break;

                    case "3":
                        smak = "Lakris";
                        loop = true;
                    break;

                    default:
                        Console.WriteLine("Vänligen ange endast ett nummer mellan 1 och 3");
                    break;

                }
            }

            loop = false;
            
            while (!loop)
            {
                Console.WriteLine("Välj vikt");
                Console.WriteLine("[1] 100g");
                Console.WriteLine("[2] 200g");
                Console.WriteLine("[3] 300g");
                input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":
                        vikt = "100g";
                        loop = true;
                    break;

                    case "2":
                        vikt = "200g";
                        loop = true;
                    break;

                    case "3":
                        vikt = "300g";
                        loop = true;
                    break;

                    default:
                        Console.WriteLine("Vänligen ange endast ett nummer mellan 1 och 3");
                    break;
                }
            }
        }


    }
}