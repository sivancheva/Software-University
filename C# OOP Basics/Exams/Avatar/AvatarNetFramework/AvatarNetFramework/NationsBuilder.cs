using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class NationsBuilder
{
    private List<Bender> benders;
    private List<Monument> monuments;
    private List<string> issuedWars;
    private double AirTotalPower;
    private double EarthTotalPower;
    private double FireTotalPower;
    private double WaterTotalPower;


    public NationsBuilder()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
        this.issuedWars = new List<string>();
        this.AirTotalPower = 0;
        this.EarthTotalPower = 0;
        this.FireTotalPower = 0;
        this.WaterTotalPower = 0;
        
    }


    public void AssignBender(List<string> benderArgs)
    {
        Bender bender = null;
        var benderType = benderArgs[0];
        var benderName = benderArgs[1];
        var benderPower = int.Parse(benderArgs[2]);
        var secondaryParam = double.Parse(benderArgs[3]);


        switch (benderType)
        {
            case "Air":
                bender = new AirBender(benderName, benderPower, secondaryParam);
                break;
            case "Earth":
                bender = new EarthBender(benderName, benderPower, secondaryParam);
                break;
            case "Fire":
                bender = new FireBender(benderName, benderPower, secondaryParam);
                break;
            case "Water":
                bender = new WaterBender(benderName, benderPower, secondaryParam);
                break;
        }

        benders.Add(bender);

    }
    public void AssignMonument(List<string> monumentArgs)
    {
        Monument monument = null;
        var monumentType = monumentArgs[0];
        var monumentName = monumentArgs[1];
        var affinity = int.Parse(monumentArgs[2]);

        switch (monumentType)
        {
            case "Air":
                monument = new AirMonument(monumentName, affinity);
                break;
            case "Earth":
                monument = new EarthMonument(monumentName, affinity);
                break;
            case "Fire":
                monument = new FireMonument(monumentName, affinity);
                break;
            case "Water":
                monument = new WaterMonument(monumentName, affinity);
                break;
        }
        monuments.Add(monument);
    }
    public string GetStatus(string nationsType)
    {
        var sb = new StringBuilder();
        sb.Append($"{nationsType} Nation" + Environment.NewLine + "Benders:");
        if (benders.Where(x => x.GetType().Name.StartsWith(nationsType)).Count() > 0)
        {
            sb.AppendLine();
            foreach (var bender in benders.Where(b => b.GetType().Name.StartsWith(nationsType)))
            {
                sb.AppendLine(bender.ToString());
            }
        }
        else
        {
            sb.AppendLine(" None");
        }

        sb.Append("Monuments:");

        if (monuments.Where(x=>x.GetType().Name.StartsWith(nationsType)).Count() > 0)
        {
            sb.AppendLine();
            foreach (var monument in monuments.Where(m => m.GetType().Name.StartsWith(nationsType)))
            {
                sb.AppendLine(monument.ToString());
            }
        }
        else
        {
            sb.AppendLine(" None");
        }
        return sb.ToString().TrimEnd();

    }
    public void IssueWar(string nationsType)
    {
        issuedWars.Add(nationsType);
        var currMaxPowerNationValue = 0d;
        string winnernation = string.Empty;


        var airBender = new List<Bender>();
        var airMonuments = new List<Monument>();
        airBender = benders.Where(x => x.GetType().Name.StartsWith("Air")).ToList();
        airMonuments = monuments.Where(x => x.GetType().Name.StartsWith("Air")).ToList();
        var airPower = airBender.Sum(x => x.TotalPower);
        var sumAffinitiesAir = airMonuments.Sum(x => x.Affinity);
        this.AirTotalPower += airPower + (airPower*sumAffinitiesAir)/ 100;
        if (AirTotalPower > currMaxPowerNationValue)
        {
            currMaxPowerNationValue = this.AirTotalPower;
            winnernation = "Air";
        }        

        var fireBender = new List<Bender>();
        var fireMonuments = new List<Monument>();
        fireBender = benders.Where(x => x.GetType().Name.StartsWith("Fire")).ToList();
        fireMonuments = monuments.Where(x => x.GetType().Name.StartsWith("Fire")).ToList();
        var firePower = fireBender.Sum(x => x.TotalPower);
        var sumAffinitiesFire = fireMonuments.Sum(x => x.Affinity);
        this.FireTotalPower += firePower + (firePower * sumAffinitiesFire) / 100;
        if (FireTotalPower > currMaxPowerNationValue)
        {
            currMaxPowerNationValue = this.FireTotalPower;
            winnernation = "Fire";
        }

        var waterBender = new List<Bender>();
        var waterMonuments = new List<Monument>();
        waterBender = benders.Where(x => x.GetType().Name.StartsWith("Water")).ToList();
        waterMonuments = monuments.Where(x => x.GetType().Name.StartsWith("Water")).ToList();
        var waterPower = waterBender.Sum(x => x.TotalPower);
        var sumAffinitiesWater = waterMonuments.Sum(x => x.Affinity);
        this.WaterTotalPower += waterPower + (waterPower * sumAffinitiesWater) / 100;
        if (WaterTotalPower > currMaxPowerNationValue)
        {
            currMaxPowerNationValue = this.WaterTotalPower;
            winnernation = "Water";
        }
        
        var earthBender = new List<Bender>();
        var earthMonuments = new List<Monument>();
        earthBender = benders.Where(x => x.GetType().Name.StartsWith("Earth")).ToList();
        earthMonuments = monuments.Where(x => x.GetType().Name.StartsWith("Earth")).ToList();
        var earthPower = earthBender.Sum(x => x.TotalPower);
        var sumAffinitiesEarth = earthMonuments.Sum(x => x.Affinity);
        this.EarthTotalPower += earthPower + (earthPower * sumAffinitiesEarth) / 100;
        if (EarthTotalPower > currMaxPowerNationValue)
        {
            currMaxPowerNationValue = this.EarthTotalPower;
            winnernation = "Earth";
        }

        benders.RemoveAll(x => !x.GetType().Name.StartsWith(winnernation));
        monuments.RemoveAll(x => !x.GetType().Name.StartsWith(winnernation));

    }
    public string GetWarsRecord()
    {
        var sb = new StringBuilder();
        int counter = 1;
        foreach (var war in issuedWars)
        {
            sb.AppendLine($"War {counter} issued by {issuedWars[counter - 1]}");
            counter++;
        }

        return sb.ToString().TrimEnd();

    }


}

