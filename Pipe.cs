using System;
using System.Collections.Generic;

namespace Multifabriken
{
    public class Pipe
    {
        private string material;
        private int length;
        private int diameter;

        public string Material
        {
            get 
            {
                return material;
            }
            set 
            {
                material = value;
            }
        }
        public int Length 
        {
            get 
            {
                return length;
            }
            set 
            {
                length = value;
            }
        }
        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }

        public Pipe(string material, int length, int diameter) 
        {
            this.material = material;
            this.length = length;
            this.diameter = diameter;
        }

        public static List<string> ListofTypes()
        {
            List<string> menuTypePipe= new List<string>
                        {
                        "Typ 1",  
                        "Typ 2",
                        "Typ 3"
                        };
                        return menuTypePipe;
        }
    }
}