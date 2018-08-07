using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public string Id
    {
        get { return id; }
        protected set { id = value; }
    }

    public virtual double OreOutput
    {
        get { return oreOutput; }
        protected set
        {
            if (value<0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }
            this.oreOutput = value;
        }
    }
    public virtual double EnergyRequirement
    {
        get { return energyRequirement; }
         protected set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            energyRequirement = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var type = this.GetType().Name.Replace("Harvester", String.Empty);
        sb.AppendLine($"{type} Harvester - {this.Id}")
            .AppendLine($"Ore Output: {this.OreOutput}")
            .AppendLine($"Energy Requirement: {this.EnergyRequirement}");

        return sb.ToString().TrimEnd();
    }

}

