using System;
using System.Collections.Generic;
using Products;


namespace Pipes
{
  class pipes : products
  {
    static List<string> myPipes = new List<string>() {
          "Rostfritt",
          "Betong",
          "Stål"
      };
    public int length { get; set; }
    public int diameter { get; set; }
    public string material = "";
    public pipes(int Length, int Diameter, string Material)
    {
      length = Length;
      diameter = Diameter;
      material = Material;
    }
  }
}





