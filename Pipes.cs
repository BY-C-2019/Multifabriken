using System;
using System.Collections.Generic;

namespace Pipes
{
  class Pipes
  {
    static List<string> myPipes = new List<string>() {
          "Rostfritt",
          "Betong",
          "Stål"
      };
    public int length { get; set; }
    public int diameter { get; set; }
    public string material = "";
    public Pipes(int Length, int Diameter, string Material)
    {
      length = Length;
      diameter = Diameter;
      material = Material;
    }
  }
}





