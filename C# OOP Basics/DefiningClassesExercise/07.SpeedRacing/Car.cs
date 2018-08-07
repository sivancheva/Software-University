using System;

public class Car
{
    private string model;
    private decimal fuelAmount;
    private decimal fuelConsumption;
    private decimal distanceTravelled;

    public Car()
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.DistanceTravelled = 0m;

    }

    public void DriveCar(decimal kmToDrive)
    {
        if (kmToDrive <= this.fuelAmount/this.fuelConsumption )
        {
            this.fuelAmount -= this.fuelConsumption * kmToDrive;
            this.distanceTravelled += kmToDrive;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public decimal FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }

    public decimal FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }


    public decimal DistanceTravelled
    {
        get { return distanceTravelled; }
        set { distanceTravelled = value; }
    }

}

