using System;
using System.Collections.Generic;
namespace Multifabriken
{
    class Candy
    {
        //Lista som är skapad i klassen för att kunna användas i hela klassen
        static private List<string> candyList= new List<string>();

        //Deklarerade variabler i klassen för att kunna användas i hela klassen.
        private string candyVarieties="";
        private double weight=0;
        
        //Variabel för att spara olika värden till samma index i listan
        private string candyThing;
        
        //Metod för att hämta data från main
        public string CandyVarieties
        {
            get{
                return candyVarieties;
            } set{
                candyVarieties=value;
                candyThing=value;
            }
        }
        //Metod för att hämta sista datan från main
        //Sedan läggs det till i listan ihop med den andra infon som angetts.
        public double Weight
        {
            get{
                return weight;
            } set{
                weight=value;
                string weightList=Convert.ToString(value);
                candyList.Add("Godissort:"+candyThing+"\nVikt:"+weightList+"kg"+"\n");
            }
        }
        //Metod för att skriva ut listan med godis i kassan i main
        public void InfoCandy()
        {
            Console.WriteLine("Godis!");
            for(int i=0;i<candyList.Count;i++){
                Console.WriteLine((i+1)+"."+candyList[i]);
            }
        }
        //Metod för att skriva ut listan och låta kunden ta bort en produkt
        public  void ItemCandy()
        {
            Console.WriteLine("Godis!");
            for(int i=0;i<candyList.Count;i++){
                Console.WriteLine((i+1)+"."+candyList[i]);
            }

            Console.Write("Ange siffran på godiset du vill ta bort:");
            int answer=Convert.ToInt32(Console.ReadLine());
            candyList.RemoveAt(answer-1);
            
        }
    }

}