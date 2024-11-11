using System;
using System.Drawing;

namespace multifabriken;

public class Car : Product
{
   public string LicensePlate;
   public string Color;
   public string Brand;

   public Car(string licensePlate, string color, string brand) {
      this.LicensePlate = licensePlate;
      this.Color = color;
      this.Brand = brand;
   }
}
