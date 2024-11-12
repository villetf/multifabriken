using System.Text.RegularExpressions;

namespace multifabriken;

public class Cart
{
   public List<Product> Products;
   
   public Cart() {
      this.Products = [];
   }

   public void AddCar() {
      Console.Clear();
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
      Console.WriteLine("Produkten har lagts till i varukorgen.");
      Thread.Sleep(2000);
   }

   public void AddCandy() {
      Console.Clear();
      Console.WriteLine("Vilken smak vill du ha?");
      string? flavour = Console.ReadLine();

      bool continueRepeat = true;
      int amount = 0;
      while (continueRepeat)
      {
         Console.WriteLine("Hur många vill du ha?");
         string? amountString = Console.ReadLine();
         if (!int.TryParse(amountString, out amount))
         {
            Console.WriteLine("Du måste ange ett heltal.");
         } else
         {
            continueRepeat = false;
         }
      }

      Candy NewCandy = new Candy(flavour!, amount);
      this.Products.Add(NewCandy);
      Console.WriteLine("Produkten har lagts till i varukorgen.");
      Thread.Sleep(2000);
   }

   public void AddPipe() {
      Console.Clear();
      bool continueRepeat = true;
      float diameter = 0;
      while (continueRepeat)
      {
         Console.WriteLine("Vilken diameter vill du ha på röret (i meter)?");
         string? diameterString = Console.ReadLine();
         if (!float.TryParse(diameterString, out diameter))
         {
            Console.WriteLine("Du måste ange ett heltal eller decimaltal.");
         } else
         {
            continueRepeat = false;
         }
      }

      continueRepeat = true;
      float length = 0;
      while (continueRepeat)
      {
         Console.WriteLine("Hur långt rör vill du ha (i meter)?");
         string? lengthString = Console.ReadLine();
         if (!float.TryParse(lengthString, out length))
         {
            Console.WriteLine("Du måste ange ett heltal eller decimaltal.");
         } else
         {
            continueRepeat = false;
         }
      }

      Pipe NewPipe = new Pipe(length, diameter);
      this.Products.Add(NewPipe);
      Console.WriteLine("Produkten har lagts till i varukorgen.");
      Thread.Sleep(2000);
   }

   public void AddOatmilk() {
      Console.Clear();
      bool continueRepeat = true;
      float amount = 0;
      while (continueRepeat)
      {
         Console.WriteLine("Hur många liter vill du ha?");
         string? amountString = Console.ReadLine();
         if (!float.TryParse(amountString, out amount))
         {
            Console.WriteLine("Du måste ange ett heltal eller decimaltal.");
         } else
         {
            continueRepeat = false;
         }
      }

      continueRepeat = true;
      float fat = 0;
      while (continueRepeat)
      {
         Console.WriteLine("Vilken fetthalt vill du ha (i procent)?");
         string? fatString = Console.ReadLine();
         if (!float.TryParse(fatString, out fat))
         {
            Console.WriteLine("Du måste ange ett heltal eller decimaltal.");
         } else
         {
            continueRepeat = false;
         }
      }

      Oatmilk NewOatMilk = new Oatmilk(fat, amount);
      this.Products.Add(NewOatMilk);
      Console.WriteLine("Produkten har lagts till i varukorgen.");
      Thread.Sleep(2000);
   }
}
