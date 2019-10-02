using System;
using System.Collections.Generic;

namespace bilar
{
    class Bilar
    {   
        public Bilar(int Carmodelindex, string Carcolour, bool Luxpackage)
        {
            carmodel = Billista[Carmodelindex];
            carcolour = Carcolour;
            luxpackage = Luxpackage;

            
        }
        static List<string> Billista = new List<string>() { "Tesla", "Audi", "Hyundai" };
        public string carmodel { get; set; }
        public string carcolour { get; set; }
        public bool luxpackage { get; set; }
 
    }
}

