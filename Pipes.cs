using System;
using System.Collections.Generic;
namespace Multifabriken
{
    class Pipes
    {
        static private List<string> pipeList= new List<string>();
        private double lenght=0;
        private string material="";
        private double diameter=0;

        public double Lenght
        {
            get{
                return lenght;
            } set{
                lenght=value;
            }
        }
        public string Material
        {
            get{
                return material;
            } set{
                material=value;
            }
        }
        public double Diameter
        {
            get{
                return diameter;
            } set{
                diameter=value;
            }
        }
        public void InfoPipe()
        {
            Console.WriteLine("Rör!");
            for(int i=0;i<pipeList.Count;i++){
                Console.WriteLine((i+1)+"."+pipeList[i]);
            }
        }
        public  void ItemPipe()
        {
            Console.WriteLine("Rör!");
            for(int i=0;i<pipeList.Count;i++){
                Console.WriteLine((i+1)+"."+pipeList[i]);
            }

            Console.Write("Ange siffran på godiset du vill ta bort:");
            int answer=Convert.ToInt32(Console.ReadLine());
            pipeList.RemoveAt(answer-1);
            
        }
    }



}