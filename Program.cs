using System;

namespace Inheritace
{
    class Program
    {
        static void Main(string[] args)
        {
          Laptop macBookAir = new MacBookAir();
          Laptop asusZend = new AsusZend();


          macBookAir.TurnOn();
          macBookAir.TurnOff();


          asusZend.TurnOn();
          asusZend.TurnOff();


          Console.WriteLine(macBookAir.TouchScreen);
          Console.WriteLine(asusZend.TouchScreen);

        }
    }
}
