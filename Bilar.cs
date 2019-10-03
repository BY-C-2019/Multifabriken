using System;
using System.Collections.Generic;

namespace Cars
{
    class cars : products
    {   
        static List<string> bilLista = new List<string>() { "Tesla", "Audi", "Hyundai" };
        public cars(int carmodelIndex, string carColour, bool luxPackage)
        {
            carmodel = bilLista[carmodelIndex];
            carcolour = carColour;
            luxpackage = luxPackage; 
        }
        
        public string carmodel { get; set; }
        public string carcolour { get; set; }
        public bool luxpackage { get; set; }
    }
}

