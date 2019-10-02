using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class OatMilk
    {
        static private List<string> oatMilkList = new List<string>();
        private int fat= 0;
        private double liters = 0;

        public int Fat
        {
            get
            {
                return fat;
            }
            set
            { 
                fat = value;
                oatMilkList.Add("Fetthalt: " + value + "%");
            }
        }
        public double Litres
        {
            get
            {
                return liters;
            }
            set
            {
                liters = value;
                oatMilkList.Add("Liter: " + value);
            }
        }
        public void OatMilkInfo()
        {
            Console.WriteLine("Havremjölk!");
            for(int i = 0; i < oatMilkList.Count;i++)
            {
                Console.WriteLine(oatMilkList[i]);
            }
        }
        public void OatMilkItem()
        {
            Console.WriteLine("Havremjölk!");
            for(int i = 0; i < oatMilkList.Count;i++)
            {
                Console.WriteLine((i+1) + " " + oatMilkList[i]);
            }
            Console.WriteLine("Vilken vill du ta bort?");
            int answer = Convert.ToInt32(Console.ReadLine());
            oatMilkList.RemoveAt(answer-1);
        }

    }
}