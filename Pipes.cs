using System;
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
      if(Diameter > 100 || Diameter < 1) // 
      {
        throw new ArgumentOutOfRangeException();
      }
      length = Length;
      diameter = Diameter;
      material = products.myPipes[materialIndex];
    }
  }
}





