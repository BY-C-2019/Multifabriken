using System;
using milk;

namespace multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk myMilk = new Milk(11, 4);

            Console.WriteLine(myMilk.package);
            Console.WriteLine(myMilk.fat);

        }
    }
}
