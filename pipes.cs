using System;

namespace Multifabriken
{
    class Pipes
    {
        private string diameter = "0";
        private string material = "";
        private string längd = "0";

        public string Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Längd
        {
            get { return längd; }
            set { längd = value; }
        }

        static void AddPipe()

        {
            string input;
            while (true)
            {
                Console.WriteLine("Välj rör:");
                Console.WriteLine("[1] Stål 9mm");
                Console.WriteLine("[2] Stål 5.56mm");
                Console.WriteLine("[3] Plast 9mm");
                Console.WriteLine("[4] Plast 5.56");
                Console.WriteLine("[5] Betong 9mm");
                Console.WriteLine("[6] Betong 5.56mm");
                Console.WriteLine("[7] Gå tillbaka");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Okej du valde Stål 9mm hur många meter vill du ha?");
                        string meter = Console.ReadLine();
                        Console.WriteLine("Okej du beställde " + meter + " meter Stål 9mm rör ");
                        return;

                    case "2":
                        Console.WriteLine("Okej du valde Stål 5.56mm hur många meter vill du ha?");
                        string meter2 = Console.ReadLine();
                        Console.WriteLine("Okej du beställde " + meter2 + " meter Stål 5.56mm rör ");
                        return;

                    case "3":
                        Console.WriteLine("Okej du valde Plast 9mm hur många meter vill du ha?");
                        string meter3 = Console.ReadLine();
                        Console.WriteLine("Okej du beställde " + meter3 + " meter Plast 9mm rör ");
                        return;

                    case "4":
                        Console.WriteLine("Okej du valde Plast 5.56 hur många meter vill du ha?");
                        string meter4 = Console.ReadLine();
                        Console.WriteLine("Okej du beställde " + meter4 + " meter Plast 5.56mm rör ");
                        return;

                    case "5":
                        Console.WriteLine("Okej du valde Betong 9mm hur många meter vill du ha?");
                        string meter5 = Console.ReadLine();
                        Console.WriteLine("Okej du beställde " + meter5 + " meter Betong 9mm rör ");
                        return;

                    case "6":
                        Console.WriteLine("Okej du valde Betong 5.56mm hur många meter vill du ha?");
                        string meter6 = Console.ReadLine();
                        Console.WriteLine("Okej du beställde " + meter6 + " meter Betong 5.56mm rör ");
                        return;

                    case "7":

                        return;
                }
            }
        }

    }
}
