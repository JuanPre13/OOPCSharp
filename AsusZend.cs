using System;
public class AsusZend : Laptop
{
    public override bool TouchScreen => true;

    public override void TurnOn(){
        Console.WriteLine("Turning on especific to AsusZend");
    }
}