using System;
using System.Collections.Generic;
namespace Multifabriken
{
    class Candy
    {
        static private List<string> candyList= new List<string>();
        private string candyVarieties="";
        private double weight=0;
        private string candyThing;
        public string CandyVarieties
        {
            get{
                return candyVarieties;
            } set{
                candyVarieties=value;
                candyThing=value;
            }
        }
        public double Weight
        {
            get{
                return weight;
            } set{
                weight=value;
                string weightList=Convert.ToString(value);
                candyList.Add(candyThing+" "+weightList+"kg"+"\n");
            }
        }
        public void InfoCandy()
        {
            Console.WriteLine("Godis!");
            for(int i=0;i<candyList.Count;i++){
                Console.WriteLine((i+1)+"."+candyList[i]);
            }
        }
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