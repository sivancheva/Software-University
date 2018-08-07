using System;
using System.Collections.Generic;

public class DriverFactory
{

    public static Driver Create(List<string> input, Car car)
    {

        var typeDriver = input[0];
        var name = input[1];


        switch (typeDriver)
        {
            case "AggressiveDriver":
                return new AggressiveDriver(name, car);

            case "EnduranceDriver":
                return new EnduranceDriver(name, car);

            default: throw new ArgumentException();
        }

    }
}

