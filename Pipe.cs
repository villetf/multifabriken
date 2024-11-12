using System;

namespace multifabriken;

public class Pipe : Product
{
   public float Length;
   public float Diameter;

   public Pipe(float length, float diameter) {
      this.Length = length;
      this.Diameter = diameter;
   }

   public override string GetProductInfo() {
      return $"Rör med längden {this.Length} meter och diametern {this.Diameter} meter";
   }
}
