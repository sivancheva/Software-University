using System;
using System.Collections.Generic;

public class HarvesterFactory
{
    public static Harvester CreateHarvester(List<string> inputArgs)
    {
        var type = inputArgs[0];
        var id = inputArgs[1];
        var oreOutput = double.Parse(inputArgs[2]);
        var energyRequirement = double.Parse(inputArgs[3]);

        Harvester harvester;

        switch (type)
        {
            case "Hammer":
                 harvester =  new HammerHarvester(id, oreOutput, energyRequirement);
                break;
            case "Sonic":
                harvester = new SonicHarvester(id, oreOutput, energyRequirement, int.Parse(inputArgs[4]));
                break;

            default:
                throw new ArgumentException();
        }
        return harvester;
    }
}

