using System;
namespace Multifabriken
{
    public class Pipe : Product
    {
        public int Material { get; set; }

        public double Length { get; set; }

        public double Diameter { get; set; }
        Pipe() : base()
        {

        }
    }
}