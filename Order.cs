using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Order
    {
        // Konstruktor
        public Order () 
        {
        listaRör = new List<Rör>();
        listaBilar = new List<Bilar>();
        listaGodis = new List<Godis>();
        listaHavremjölk = new List<Havremjölk>();
        }
        
        //Skapar listor som properties
        public List<Rör> listaRör;
        public List<Bilar> listaBilar;
        public List<Godis> listaGodis;
        public List <Havremjölk> listaHavremjölk;
    
    
    }
}

