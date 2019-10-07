using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Car
    {
        static private List<string> carList = new List<string>();
        private string color;
        private string model;
        private string lyxInredning;
        
        private string colorList;
        private string modelList;
        private string lyxInredningList;

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                colorList=value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
                modelList=value;
            }
        }
        public string LyxInredning
        {
            get
            {
                return lyxInredning;
            }
            set 
            {
                lyxInredning = value;
                lyxInredningList=value;
                carList.Add("Model:"+modelList+"\nFärg:"+colorList+"\nLyxinredning:"+lyxInredningList+"\n");
            }
        }
        public void InfoCar()
        {
            Console.WriteLine("Bil!");
            for(int i = 0; i < carList.Count;i++)
            {
                Console.WriteLine((i+1) + "." + carList[i]);
            }
        }
        public void ItemCar()
        {
            Console.WriteLine("Bil!");
            for(int i = 0; i < carList.Count;i++)
            {
                Console.WriteLine((i+1) + "." + carList[i]);
            }
            Console.WriteLine("Vilken vill du ta bort?");
            int answer = Convert.ToInt32(Console.ReadLine());
            carList.RemoveAt(answer-1);
        }
    
    }
}