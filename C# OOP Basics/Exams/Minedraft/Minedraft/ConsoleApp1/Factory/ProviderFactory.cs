using System;
using System.Collections.Generic;

public class ProviderFactory
{
    public static Provider CreateProvider(List<string> inputArgs)
    {
        var type = inputArgs[0];
        var id = inputArgs[1];
        var energyOutput = double.Parse(inputArgs[2]);
        Provider provider;

        switch (type)
        {
            case "Pressure":
                provider = new PressureProvider(id, energyOutput);
                break;
            case "Solar":
                provider = new SolarProvider(id, energyOutput);
                break;
            default:
                throw new ArgumentException("Provider is not registered, because of it's Type");
        }
        return provider;
    }
}

