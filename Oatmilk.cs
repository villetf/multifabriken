using System;

namespace multifabriken;

public class Oatmilk : Product
{
   public float Fat;
   public float Litres;

   public Oatmilk(float fat, float litres) {
      this.Fat = fat;
      this.Litres = litres;
   }
}
