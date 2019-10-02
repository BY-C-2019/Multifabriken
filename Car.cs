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

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                carList.Add("Färg" + value);
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
                carList.Add("Model: "+ value);
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
                LyxInredning = value;
                carList.Add("Lyxinredning: "+ value);
            }
        }
        public void InfoCar()
        {
            Console.WriteLine("Bil!");
            for(int i = 0; i < carList.Count;i++)
            {
                Console.WriteLine((i+1) + " " + carList[i]);
            }
        }
        public void ItemCar()
        {
            Console.WriteLine("Bil!");
            for(int i = 0; i < carList.Count;i++)
            {
                Console.WriteLine((i+1) + " " + carList[i]);
            }
            Console.WriteLine("Vilken vill du ta bort?");
            int answer = Convert.ToInt32(Console.ReadLine());
            carList.RemoveAt(answer-1);
        }
    
    }
}