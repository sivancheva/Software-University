using System;
using System.Collections.Generic;
using System.Text;

public class HammerHarvester : Harvester
{
    
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        :base(id, oreOutput, energyRequirement) { }

    public override double OreOutput { get => base.OreOutput + 2*base.OreOutput; }
    public override double EnergyRequirement { get => base.EnergyRequirement*2 ; }
};

