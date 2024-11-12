
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
         Cart.AddCar();
         break;
      case 2:
         Cart.AddCandy();
         break;
      case 3:
         Cart.AddPipe();
         break;
      case 4:
         Cart.AddOatmilk();
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