using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class RaceTower
{
    private List<Driver> drivers;
    public int TotalLaps { get; private set; }
    public int TrackLength { get; private set; }
    public string Weather { get; private set; }   
    public int CurrentLap { get; private set; }



    public RaceTower()
    {
        this.drivers = new List<Driver>();
        this.Weather = "Sunny";
        this.CurrentLap = 0;
    }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.TotalLaps = lapsNumber;
        this.TrackLength = trackLength;

    }
    public void RegisterDriver(List<string> commandArgs)
    {
        try
        {
            var driverArgs = commandArgs.Take(2).ToList();
            var carArgs = commandArgs.Skip(2).Take(2).ToList();
            var tyreArgs = commandArgs.Skip(4).ToList();

            Tyre tyre = TyreFactory.Create(tyreArgs);
            Car car = CarFactory.Create(carArgs, tyre);
            Driver driver = DriverFactory.Create(driverArgs,car);
            
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        //TODO: Add some logic here …
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        var numberOfLaps = int.Parse(commandArgs[0]);
        this.D
        return "";
    }

    public string GetLeaderboard()
    {
        //TODO: Add some logic here …
        return "";
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        var weather = commandArgs[0];
        this.Weather = weather;
    }

}

