
using System;

public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
       : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
       
    }


    public int SonicFactor
    {
        get { return sonicFactor; }
        protected set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("Harvester is not registered, because of it's SonicFactor");
            }
            sonicFactor = value;
        }
    }


    public override double EnergyRequirement
    {
        get => base.EnergyRequirement / this.SonicFactor;
    }

}