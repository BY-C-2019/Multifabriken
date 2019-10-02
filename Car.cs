using System;

namespace Multifabriken
{
    class Car
    {
        private string model = "";
        private string color = "";
        private bool luxury = true;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool Luxury
        {
            get { return luxury; }
            set { luxury = value; }
        }
    }
}