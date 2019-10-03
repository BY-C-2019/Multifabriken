using System;
using System.Collections.Generic;

namespace Cars
{
    class Cars
    {   
        static List<string> bilLista = new List<string>() { "Tesla", "Audi", "Hyundai" };
        public Cars(int carmodelIndex, string carColour, bool luxPackage)
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

