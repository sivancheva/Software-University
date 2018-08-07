using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private string mode;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private List<Harvester> harvesters;
    private List<Provider> providers;


    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.mode = "Full";
        this.totalStoredEnergy = 0;
        this.totalMinedOre = 0;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var currHarvester = HarvesterFactory.CreateHarvester(arguments);
            this.harvesters.Add(currHarvester);
            var type = currHarvester.GetType().Name.Replace("Harvester", String.Empty);
            return $"Successfully registered {type} Harvester - {currHarvester.Id}";
        }
        catch (Exception e )
        {
            return e.Message;
        }
    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var currentProvider = ProviderFactory.CreateProvider(arguments);
            this.providers.Add(currentProvider);
            var type = currentProvider.GetType().Name.Replace("Provider", String.Empty);
            return $"Successfully registered {type} Provider - {currentProvider.Id}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
    public string Day()
    {

        var dayEnergyProvided = providers.Sum(p => p.EnergyOutput);
        totalStoredEnergy += dayEnergyProvided;

        double dayEnergyRequired;
        double dayMinedOre;      

        if (mode == "Full")
        {
            dayEnergyRequired = harvesters.Sum(h => h.EnergyRequirement);
            dayMinedOre = harvesters.Sum(h=>h.OreOutput);

        }
        else if (mode == "Half")
        {
            dayEnergyRequired = harvesters.Sum(h => h.EnergyRequirement)*0.6;
            dayMinedOre = harvesters.Sum(h => h.OreOutput)*0.5;
        }

        else
        {
            dayEnergyRequired = 0;
            dayMinedOre = 0;
        }

        if (dayEnergyRequired <= totalStoredEnergy)
        {
            totalStoredEnergy -= dayEnergyRequired;
            totalMinedOre += dayMinedOre;
        }
        else
        {
            dayMinedOre = 0;
        }

        
        return "A day has passed." + Environment.NewLine +
                $"Energy Provided: {dayEnergyProvided}" + Environment.NewLine +
                $"Plumbus Ore Mined: {dayMinedOre}";

    }
    public string Mode(List<string> arguments)
    {
        var currMode = arguments[0];
        if (currMode == "Full" || currMode == "Half" || currMode == "Energy")
        {
            this.mode = currMode;
        }
        return $"Successfully changed working mode to {this.mode} Mode";
    }
    public string Check(List<string> arguments)
    {
        var currId = arguments[0];
        if (harvesters.All(x=>x.Id != currId) && providers.All(x=>x.Id != currId))
        {
            return $"No element found with id - {currId}";
        }
        if (harvesters.Any(x => x.Id == currId))
        {
            Harvester harv = harvesters.First(x => x.Id == currId);
            return harv.ToString();
        }
        Provider prov = providers.FirstOrDefault(x=>x.Id == currId);
       return  prov.ToString();

    }
    public string ShutDown()
    {
        return "System Shutdown" + Environment.NewLine +
                $"Total Energy Stored: {totalStoredEnergy}" + Environment.NewLine +
                $"Total Mined Plumbus Ore: {totalMinedOre}";

    }

}

