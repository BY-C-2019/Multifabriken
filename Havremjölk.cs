using System;

namespace Multifabriken
{
public class Havremjölk
    {
                //Metod för fetthalt på mjölk
        static int milkFat(){
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
        //Skapar konstruktor som sätter standardvärde på objektet när de skapas.
        public Havremjölk (int fetthalt, double volym)
        {
            Fetthalt = fetthalt;
            Volym = volym;
        }

        //properties
        public int Fetthalt;
        public double Volym;

    }
}