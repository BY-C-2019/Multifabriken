using System;
using System.Collections.Generic;
namespace Multifabriken
{
    class Pipes
    {
        //Lista som är skapad i klassen för att kunna användas i hela klassen
        static private List<string> pipeList= new List<string>();

        //Deklarerade variabler i klassen för att kunna användas i hela klassen.
        private double lenght=0;
        private string material="";
        private double diameter=0;

        //Variabler för att spara olika värden till samma index i listan
        private string materialList;
        private string lenghtList;
        private string diameterList;

        //Metod för att hämta data från main
        public double Lenght
        {
            get{
                return lenght;
            } set{
                lenght=value;
                lenghtList=Convert.ToString(value);
            }
        }
        public string Material
        {
            get{
                return material;
            } set{
                material=value;
                materialList=value;
            }
        }
        //Metod för att hämta sista datan från main
        //Sedan läggs det till i listan ihop med den andra infon som angetts.
        public double Diameter
        {
            get{
                return diameter;
            } set{
                diameter=value;
                diameterList=Convert.ToString(value);
                pipeList.Add(materialList+" \nLängd:"+lenghtList+"m"+" \nDiameter:"+diameterList+"cm\n");
            }
        }
        //Metod för att skriva ut listan med rör i kassan i main
        public void InfoPipe()
        {
            Console.WriteLine("Rör!");
            for(int i=0;i<pipeList.Count;i++){
                Console.WriteLine((i+1)+"."+pipeList[i]);
            }
        }
        //Metod för att skriva ut listan och låta kunden ta bort en produkt
        public  void ItemPipe()
        {
            Console.WriteLine("Rör!");
            for(int i=0;i<pipeList.Count;i++){
                Console.WriteLine((i+1)+"."+pipeList[i]);
            }

            Console.Write("Ange siffran på röret du vill ta bort:");
            int answer=Convert.ToInt32(Console.ReadLine());
            pipeList.RemoveAt(answer-1);
            
        }
    }



}