using System.Text.RegularExpressions;
using System;

namespace multifabriken;

public class Cart
{
   public List<Product> Products;
   
   public Cart() {
      this.Products = [];
   }

   public void AddCar() {
      Console.WriteLine("Vilket märke vill du ha?");
      string? brand = Console.ReadLine();
      Console.WriteLine("Vilken färg vill du ha?");
      string? color = Console.ReadLine();
      bool continueLicenseLoop = true;
      string? licensePlate = "";
      while (continueLicenseLoop)
      {
         Console.WriteLine("Vilket registreringsnummer vill du ha?");
         licensePlate = Console.ReadLine();
         if (!Regex.IsMatch(licensePlate!, @"^\w{3}(\d{3}|\d{2}\w)$"))
         {
            Console.WriteLine("Du måste ange ett registreringsnummer i formatet ABC123 alternativt ABC12X.");
         } else
         {
            licensePlate = licensePlate!.ToUpper();
            continueLicenseLoop = false;
         }
      }
      Car NewCar = new Car(licensePlate!, color!, brand!);
      this.Products.Add(NewCar);
   }

   public void AddCandy() {
      Console.WriteLine("Vilken smak vill du ha?");
      string? flavour = Console.ReadLine();
      Console.WriteLine("Hur många vill du ha?");
      int number = int.Parse(Console.ReadLine());
      Candy NewCandy = new Candy(flavour!, number);
      this.Products.Add(NewCandy);
   }

   public void AddPipe() {
      Console.WriteLine("Vilken diameter vill du ha på röret?");
      float diameter = float.Parse(Console.ReadLine());
      Console.WriteLine("Hur långt rör vill du ha?");
      float length = float.Parse(Console.ReadLine());
      Pipe NewPipe = new Pipe(length, diameter);
      this.Products.Add(NewPipe);
   }

   public void AddOatmilk() {
      Console.WriteLine("Hur många liter vill du ha?");
      float amount = float.Parse(Console.ReadLine());
      Console.WriteLine("Vilken fetthalt vill du ha?");
      float fat = float.Parse(Console.ReadLine());
      Oatmilk NewOatMilk = new Oatmilk(fat, amount);
      this.Products.Add(NewOatMilk);
   }
}
