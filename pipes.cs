using System;

namespace Multifabriken
{
    class Pipes
    {
        private int diameter = 0;
        private string material = "";
        private int längd = 0;

        public int Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public int Längd
        {
            get { return längd; }
            set { längd = value; }
        }
    }
}
