using System;
using System.Collections.Generic;
namespace Multifabriken
{
    class Car
    {
       private string typeCar;
       public string TypeCar
       {
           get { return typeCar; }
           set { typeCar = value; }
       }

       private string colorCar;
       public string ColorCar
       {
           get { return colorCar; }
           set { colorCar = value; }
       }
       
       private string interiorCar;
       public string InteriorCar
       {
           get { return interiorCar; }
           set { interiorCar = value;}
       }
       
       public Car() 
       {
           
       }
       public Car (string inputTypeCar,string inputColorCar,string inputInteriorCar)
       {
           this.typeCar= inputTypeCar;
           this.colorCar=inputColorCar;
           this.interiorCar=inputInteriorCar;
           
       }

        // En Lista som skriver ut vilka bilar som finns att välja mellan
               public static List<string> Cartype()
               {
                List<string> menuItemsCar= new List<string>
                {
                  "Bil typ 1",  
                  "Bil typ 2",
                  "Bil typ 3",
                  "Bil typ 4"

                };
                return menuItemsCar;
               }

                // En lista för att rada upp färgalternativen.
                public static List<string> Carcolor()
                {
                List<string> menuColorCar= new List<string>
                {
                  "Färg 1",  
                  "Färg 2",
                  "Färg 3",
                  "Färg 4"

                };
                Console.Clear();
                return menuColorCar;
                }
                
    }


}