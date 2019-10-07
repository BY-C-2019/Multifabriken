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
            //skapar instans av order
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
                        double candyWeight = getAmmount();
                        if (candyWeight >= 1){             //Om godis är mer än 1kg lägg till det i listan
                            Godis nyttGodis = new Godis(Godis.candyMenu(), candyWeight); //Skapar objekt
                            minOrder.listaGodis.Add(nyttGodis);
                            break;
                        }else{
                            Console.WriteLine("Minst 1kg godis");
                            break;
                        }
                    
                    
                    
                    
                    
                    case "2"://Havremjölk

                        double milkAmmount = getAmmount();
                        if (milkAmmount > 0.5){
                        Havremjölk mjölkOrder = new Havremjölk(Havremjölk.milkFat(), milkAmmount);
                        minOrder.listaHavremjölk.Add(mjölkOrder);
                        break;
                        }
                        else{
                            Console.WriteLine("Du måste ange minst 0.5 liter mjölk");
                            break;
                        }
                    
                    
                    
                    
                    
                    
                    
                    
                    case "3"://Rör
                        Rör nyttRör = new Rör( Rör.pipeMaterial(), Rör.pipeDiameter(), Rör.pipeLength());
                        minOrder.listaRör.Add(nyttRör);

                        break;
                    case "4"://Bilar
                        Bilar nyBil = new Bilar (Bilar.carModel(), Bilar.carColor(), Bilar.carInterior());
                        minOrder.listaBilar.Add(nyBil);
                        break;
                    case "5"://Skriv ut beställning
                    Console.WriteLine("DIN ORDER ÄR:");
                    Console.WriteLine("-----------------------------------------------------------------");
                    int i = 1;
                    int j = 1;
                    int k = 1;
                    foreach (var element in minOrder.listaRör)
                    {
                        Console.WriteLine("Rör " + i);
                        i++;
                        Console.WriteLine("Diameter: " + element.Diameter + " Längd: " + element.Length + " Material: " + element.Material);
                    Console.WriteLine("-----------------------------------------------------------------");
                    }
                    foreach (var element in minOrder.listaBilar)
                    {
                        Console.WriteLine("Bil: " + i);
                        j++;
                        Console.WriteLine("Modell: " + element.Model + " Färg: " + element.Color + " Inredning: " + element.Interor);
                    Console.WriteLine("-----------------------------------------------------------------");
                    }
                    foreach (var element in minOrder.listaHavremjölk)
                    {
                        Console.WriteLine("Havremjölk " + i);
                        k++;
                        Console.WriteLine("Fetthalt: " + element.Fetthalt + " Volym: " + element.Volym);
                    Console.WriteLine("-----------------------------------------------------------------");
                    }
                    foreach (var element in minOrder.listaGodis)
                    {
                        Console.WriteLine("Godis " + i);
                        i++;
                        Console.WriteLine("Smak: " + element.Smak + " Vikt: " + element.Vikt );
                    Console.WriteLine("-----------------------------------------------------------------");
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

