using System;
using System.Collections.Generic;
using Products;


namespace Pipes
{
  class pipes : products
  {

    public int length { get; set; }
    public int diameter { get; set; }
    public string material = "";
    public pipes(int Length, int Diameter, int materialIndex)
    {
      length = Length;
      diameter = Diameter;
      material = products.myPipes[materialIndex];
    }
  }
}





