using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class RaceTower
{
    private readonly Dictionary<string, Driver> drivers;
    private int lapsNumber;
    private int trackLength;

    public RaceTower()
    {
        this.drivers = new Dictionary<string, Driver>();
    }


    void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.lapsNumber = lapsNumber;

    }
    void RegisterDriver(List<string> commandArgs)
    {

        try
        {
            var tyreArgs = commandArgs.Skip(4).ToList();
            var carArgs = commandArgs.Skip(2).Take(2).ToList();
            var driverArgs = commandArgs.Take(2).ToList();

            var tyre = TyreFactory.Create(tyreArgs);
            var car = CarFactory.Create(carArgs, tyre);
            var driver = DriverFactory.Create(driverArgs, car);
            drivers[driver.Name] = driver;

        }
        catch ( Exception e)
        {

            Console.WriteLine(e.Message);
        }
         

    }

    void DriverBoxes(List<string> commandArgs)
    {
        //TODO: Add some logic here …
    }

    string CompleteLaps(List<string> commandArgs)
    {
        return "";
    }

    string GetLeaderboard()
    {
        //TODO: Add some logic here …
        return "";
    }

    void ChangeWeather(List<string> commandArgs)
    {
        //TODO: Add some logic here …
    }

}

