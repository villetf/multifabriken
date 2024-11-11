using multifabriken;

bool continueRepeat = true;
Factory factory = new Factory("Multifabriken AB");
while (continueRepeat)
{
   Console.Clear();
   Console.WriteLine($"Välkommen till {factory.Name}!");
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
   if (int.TryParse(stringAnswer, out answer))
   {
      Console.WriteLine(answer);
      Thread.Sleep(5000);
   } else
   {
      Console.WriteLine("Du måste ange en siffra, försök igen");
      Thread.Sleep(2000);
   }
}