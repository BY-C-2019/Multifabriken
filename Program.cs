using System;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Vad vill du göra");
                Console.WriteLine("[1] Köp bil");
                Console.WriteLine("[2] Köp Rör");
                Console.WriteLine("[3] Köp godis");
                Console.WriteLine("[4] Köp havremjölk");
                Console.WriteLine("[5] Skriv ut inköpslista");
                Console.WriteLine("[6] Avsluta");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        while (true)
                        {
                            Console.WriteLine("Välj modell:");
                            Console.WriteLine("[1] 240");
                            Console.WriteLine("[2] 740");
                            Console.WriteLine("[3] 940");
                            Console.WriteLine("[4] Gå tillbaka");
                            input = Console.ReadLine();

                            switch (input)
                            {
                                case "1":

                                    break;

                                case "2":

                                    break;

                                case "3":

                                    break;

                                case "4":
                                    return;

                                default:
                                    Console.WriteLine("Fel val, försök igen");
                                    break;
                            }
                        }


                    case "2":
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


                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Fel val, försök igen");
                        break;
                }
            }
        }
    }
}
