using System;

namespace multifabriken;

public class Candy : Product
{
   public string Flavour;
   public int Number;

   public Candy(string flavour, int number) {
      this.Flavour = flavour;
      this.Number = number;
   }
}
