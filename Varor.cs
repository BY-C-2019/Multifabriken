using System;
using System.Collections.Generic;
using Milk;
using Cars;
using Pipes;
using Candy;

namespace Products
{
  class products
  {
    public static List<string> godisLista = new List<string>(){"Hallon", "Päron", "Lakris", "Jordgubbar"};
    public static List<string> myPipes = new List<string>() {
      "Rostfritt",
      "Betong",
      "Stål"
  };
    public static List<string> bilLista = new List<string>() { "Tesla", "Audi", "Hyundai" };
    public static List<string> packageList{get;} = new List<string>(){"1 liter", "2 liter", "0.5 liter"};


    public static int antal { get; set; } = 0;
    public static int mängd { get; set; }
  }
}