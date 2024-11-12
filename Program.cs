using System.Text.RegularExpressions;
using multifabriken;

bool continueRepeat = true;
Factory Factory = new Factory("Multifabriken AB");
Cart Cart = new Cart();
while (continueRepeat)
{
   Console.Clear();
   Console.WriteLine($"Välkommen till {Factory.Name}!");
   Console.WriteLine("");
   Console.WriteLine("Välj något av följande valalterantiv:");
   Console.WriteLine("1. Lägg till bil i varukorg");
   Console.WriteLine("2. Lägg till godis i varukorg");
   Console.WriteLine("3. Lägg till rör i varukorg");
   Console.WriteLine("4. Lägg till havremjölk i varukorg");
   Console.WriteLine("5. Visa varukorg");
   Console.WriteLine("6. Avsluta");
   string? stringAnswer = Console.ReadLine();
   int answer;
   if (!int.TryParse(stringAnswer, out answer))
   {
      Console.WriteLine("Du måste ange en siffra, försök igen");
      Thread.Sleep(2000);
      continue;
   } 

   switch (answer)
   {
      case 1:
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
         Cart.Products.Add(NewCar);
         break;
      case 2:
         Console.WriteLine("Vilken smak vill du ha?");
         string? flavour = Console.ReadLine();
         Console.WriteLine("Hur många vill du ha?");
         int number = int.Parse(Console.ReadLine());
         Candy NewCandy = new Candy(flavour!, number);
         Cart.Products.Add(NewCandy);
         break;
      case 3:
         Console.WriteLine("Vilken diameter vill du ha på röret?");
         float diameter = float.Parse(Console.ReadLine());
         Console.WriteLine("Hur långt rör vill du ha?");
         float length = float.Parse(Console.ReadLine());
         Pipe NewPipe = new Pipe(length, diameter);
         Cart.Products.Add(NewPipe);
         break;
      case 4:
         Console.WriteLine("Hur många liter vill du ha?");
         float amount = float.Parse(Console.ReadLine());
         Console.WriteLine("Vilken fetthalt vill du ha?");
         float fat = float.Parse(Console.ReadLine());
         Oatmilk NewOatMilk = new Oatmilk(fat, amount);
         Cart.Products.Add(NewOatMilk);
         break;
      case 5:
         Console.WriteLine("Din kundkorg innehåller:");
         Console.WriteLine("");
         foreach (var product in Cart.Products)
         {
            Console.WriteLine(product.GetProductInfo());
         }
         Console.WriteLine("");
         Console.WriteLine("Tryck på en tangent att gå tillbaka");
         Console.ReadKey();
         break;
      case 6:
         continueRepeat = false;
         break;
      default:
         Console.WriteLine("Du måste välja en siffra mellan 1 och 6.");
         break;
   }
}