using System;


public abstract class Laptop{

    public virtual void TurnOn(){

        Console.WriteLine("Turn ON.");

    }
    public void TurnOff(){

        Console.WriteLine("Turn OFF.");

    }
    
    public abstract bool TouchScreen{ get; }


}