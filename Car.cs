using System;

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
       
       private bool interiorCar;
       public bool InteriorCar
       {
           get { return interiorCar; }
           set { interiorCar = value; }
       }
       
       
       public Car (string inputTypeCar,string inputColorCar,bool inputInteriorCar)
       {
           this.typeCar= inputTypeCar;
           this.colorCar=inputColorCar;
           this.interiorCar=inputInteriorCar;
           
       }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}