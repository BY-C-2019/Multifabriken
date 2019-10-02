using System;

namespace Multifabriken
{
    class Program
    {
        static string candyMenu(){
            Console.WriteLine("Vilken typ av godis vill du ha?");
            Console.WriteLine("1. Hallon");
            Console.WriteLine("2. Lakris");
            Console.WriteLine("3. Jordgubb");
            Console.WriteLine("4. Päron");
            string flavourChoise = Console.ReadLine();//try catch / switch?
            return flavourChoise;
        }
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
        static int milkType(){
            Console.WriteLine("Vilken fetthalt vill du ha? ");
            Console.WriteLine("(Mellan 2% och 11%)");
            string fat = Console.ReadLine();
            int partFat = 0;
            try{
                partFat = Convert.ToInt32(fat);
            }catch{
                Console.WriteLine("Ange fetthalt i heltal");
            }
            if (partFat < 2 || partFat > 11){
                Console.WriteLine("Fetthalten måste vara mellan 2% och 11%");
            }
            return partFat;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till multifabriken!");
            while (true)
            {
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
                        candyMenu();
                        getAmmount();
                        break;
                    case "2"://Havremjölk
                        milkType();
                        getAmmount();
                        break;
                    case "3"://Rör

                        break;
                    case "4"://Bilar

                        break;
                    case "5"://Skriv ut beställning

                        break;//Avsluta programmet
                    case "6":

                        return;
                    default:
                        Console.WriteLine("Skriv ditt val endast med siffervärde");
                        break;
                }
            }
        }
    } 
}

