using System;
using System.Collections.Generic;
using System.Text;


public class CarFactory
{
    public static Car Create(List<string> arguments, Tyre tyre)
    {

        var hp = int.Parse(arguments[0]);
        var fuelAmount = double.Parse(arguments[1]);

        return new Car(hp, fuelAmount, tyre);
    }
}

