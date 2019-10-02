using System;

namespace Multifabriken
{
    class Pipes
    {
        private string diameter = "0";
        private string material = "";
        private string längd = "0";

        public string Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Längd
        {
            get { return längd; }
            set { längd = value; }
        }
    }
}
