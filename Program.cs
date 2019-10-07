using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        //Metod för att hämta mängd på beställning från användaren. 
        static double getAmmount(){
            Console.WriteLine("Hur mycket?");
            double dAmmount = 0;
            string sAmmount = Console.ReadLine();
            try{
                dAmmount = Convert.ToDouble(sAmmount);
            }catch{
                Console.WriteLine("Ange mängden i siffror");
            }
            return dAmmount;
        }
        
        static void Main(string[] args)
        {
            //skapar instans av 
            Order minOrder = new Order ();
            Console.WriteLine("Hej och välkommen till multifabriken!");
            while (true)
            {
                //Meny, loopas
                Console.WriteLine("Vad vill du beställa?");
                Console.WriteLine("1. Godis");
                Console.WriteLine("2. Havremjölk");
                Console.WriteLine("3. Rör");
                Console.WriteLine("4. Bilar");
                Console.WriteLine("5. Skriv ut varor");
                Console.WriteLine("6. Avsluta programmet");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1"://Godis
                        double candyInmatning = getAmmount();
                        Godis.candyMenu();
                        if (candyInmatning < 1){
                            Console.WriteLine("Minst 1kg godis");
                        }else{
                            double candyWeight = candyInmatning;
                        }
                        Godis nyttGodis = new Godis(candyMenu(), candyInmatning); //Skapar objekt
                        minOrder.listaGodis.Add(nyttGodis);
                        break;
                    case "2"://Havremjölk

                        double milkInmatning = getAmmount();
                        if (milkInmatning < 0.5){
                            Console.WriteLine("Du måste ange minst 0.5 liter mjölk");
                        }else{
                            double milkFat = milkInmatning;
                        }
                        Havremjölk mjölkOrder = new Havremjölk(milkFat(), milkInmatning);
                        minOrder.listaHavremjölk.Add(mjölkOrder);
                        
                        break;
                    case "3"://Rör
                        Rör nyttRör = new Rör(pipeMaterial(), pipeDiameter(), pipeLength());
                        minOrder.listaRör.Add(nyttRör);

                        break;
                    case "4"://Bilar
                        Bilar nyBil = new Bilar (carModel(), carColor(), carInterior());
                        minOrder.listaBilar.Add(nyBil);
                        break;
                    case "5"://Skriv ut beställning
                    int i = 1;
                    foreach (var element in minOrder.listaRör)
                    {
                        Console.WriteLine("Rör " + i);
                        i++;
                        Console.WriteLine("Diameter: " + element.diameter + " Längd: " + element.length + " Material: " + element.material);
                    }
                        break;
                    case "6": //Avsluta programmet
                        return;
                    default:
                        Console.WriteLine("Skriv ditt val endast med siffervärde");
                        break;
                }
            }
        }
    } 
}

