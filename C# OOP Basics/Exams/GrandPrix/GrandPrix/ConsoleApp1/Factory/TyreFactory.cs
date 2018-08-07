using System;
using System.Collections.Generic;
using System.Text;


public class TyreFactory
{
    public static Tyre Create(List<string> input)
    {

        var tyreType = input[0];

        switch (tyreType)
        {
            case "Hard":
                return new HardTyre(double.Parse(input[1]));

            case "Ultrasoft":
                return new UltrasoftTyre(double.Parse(input[1]), double.Parse(input[2]));

            default: throw new ArgumentException();
        }

    }
}

