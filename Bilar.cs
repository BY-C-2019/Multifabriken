using System;
using System.Collections.Generic;

namespace Bilar
{
    class Bilar
    {
        static List<string> Billista = new List<string>() { "Tesla", "Audi", "Hyundai" };
        public string carmodel { get; set; }
        public string carcolour { get; set; }
        public bool luxpackage { get; set; }

        public Bilar(string Carmodel, string Carcolour, bool Luxpackage)
        {
            carmodel = Carmodel;
            carcolour = Carcolour;
            luxpackage = Luxpackage;
        }
    }
}

