using System;
using System.Collections.Generic;
using System.Text;


public class CarFactory
{
    public static Car Create(List<string> input, Tyre tyre)
    {
        var hp = int.Parse(input[0]);
        var fuelAmount = double.Parse(input[1]);
        return new Car(hp, fuelAmount, tyre);

    }
}

