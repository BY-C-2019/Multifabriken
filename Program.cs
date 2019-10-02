using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>();
            List<Godis> myGodises = new List<Godis>();
            List<Pipes> myPipes = new List<Pipes>();
            List<Oatmilk> myMilks = new List<Oatmilk>();

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
                        Car myCar = new Car();

                        Console.WriteLine("Välj modell:");
                        Console.WriteLine("[1] 240");
                        Console.WriteLine("[2] 740");
                        Console.WriteLine("[3] 940");
                        input = Console.ReadLine();

                        if (input == "1")
                        {
                            myCar.Model = "240";
                        }
                        else if (input == "2")
                        {
                            myCar.Model = "740";
                        }
                        else
                        {
                            myCar.Model = "940";
                        }

                        Console.WriteLine("Välj färg:");
                        Console.WriteLine("[1] Röd");
                        Console.WriteLine("[2] Grön");
                        Console.WriteLine("[3] Blå");
                        input = Console.ReadLine();

                        myCar.Color = Console.ReadLine();

                        Console.WriteLine("Välj färg:");
                        Console.WriteLine("[1] Röd");

                        myCars.Add(myCar);
                        break;


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

                        switch (input)
                        {
                            case "1":
                                myGodis.Vikt = "100g";
                            break;

                            case "2":
                                myGodis.Vikt = "200g";
                            break;

                            case "3":
                                myGodis.Vikt = "300g";
                            break;

                        }
                        myGodises.Add(myGodis);

                        for (int i = 0; i < myGodises.Count; i++)
                        {
                            Console.WriteLine("[{0}]. {1} {2}", i + 1, myGodis.Smak, myGodis.Vikt);
                            
                        }
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
