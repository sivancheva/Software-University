using System;
using System.Collections.Generic;
using System.Text;


public class TyreFactory
{
    public static Tyre Create(List<string> arguments)
    {
        var tyreType = arguments[0];
        var tyreHardness = double.Parse(arguments[1]);

        switch (tyreType)
        {
            case "Hard":
                return new HardTyre(tyreHardness);
            case "Ultrasoft":
                double grip = double.Parse(arguments[2]);
                return new UltrasoftTyre(tyreHardness, grip);
           default:
                throw new ArgumentException();
        }
        
    }

}

