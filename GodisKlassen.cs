using System.Collections.Generic;
using System;

namespace eyyo
{

    public class Candy
    {  
            private List<string> godisLista = new List<string>(){"Hallon", "Päron", "Lakris", "Jordgubbar"};

            public string taste = "";


            public Candy(int candyIndex)
            {
                taste = godisLista[candyIndex];
                
            }
       
    }

}
