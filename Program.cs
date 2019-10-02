using System;

namespace eyyo
{
    class Program
    {

        static void Main(string[] args)
        {
                Candy godiKlass = new Candy(0);

                Console.WriteLine(godiKlass.taste);

            
        }
        static void Vadförgodis()
            {   

                string val = Console.ReadLine();

                switch (val)
                {
                   case "1":
                   Console.WriteLine("Hallon");
                    break;

                   case "2":
                   Console.WriteLine("Lakris");
                    break;

                   case "3":
                   Console.WriteLine("Jordgubbar");
                    break;

                   case "4":
                   Console.WriteLine("Päron");
                    break;

                }


            }
    }
}
