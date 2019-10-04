using System;

namespace Multifabriken
{
    class Oatmilk
    {
        private string volume = "";
        private string fat = "";

        public string Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public string Fat
        {
            get { return fat; }
            set { fat = value; }
        }

         static void AddMilk()
            {
                string input;
                Godis myGodis = new Godis();

                Console.WriteLine("Välj smak");
                Console.WriteLine("[1] Hallon");
                Console.WriteLine("[2] Jordgubb");
                Console.WriteLine("[3] Lakris");
                Console.WriteLine("[4] Tillbaka");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        myGodis.Smak = "Hallon";
                        break;

                    case "2":
                        myGodis.Smak = "Jordgubb";
                        break;

                    case "3":
                        myGodis.Smak = "Lakris";
                        break;

                    case "4":
                        break;
                }

                Console.WriteLine("Välj vikt");
                Console.WriteLine("[1] 100g");
                Console.WriteLine("[2] 200g");
                Console.WriteLine("[3] 300g");
                input = Console.ReadLine();
            }

    }
}