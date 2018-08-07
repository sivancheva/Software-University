using System;
using System.Collections.Generic;
using System.Text;


public class Bus : Vehicle
{
    private const double ExtraFuelConsumption = 1.4;
    public Bus(double fuelQuantity, double fuelConsumptionLperKm, double tankCapacity)
        : base(fuelQuantity, fuelConsumptionLperKm, tankCapacity) { }

   
    public void DriveEmpty(double kmToDrive)
    {
        base.Drive(kmToDrive);
    }
    
    public override void Drive(double kmToDrive)
    {
        var fuelNeeded = kmToDrive * (this.FuelConsumptionLperKm + ExtraFuelConsumption);

        if (fuelNeeded > this.FuelQuantity)
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name} travelled {kmToDrive} km");
            this.FuelQuantity -= kmToDrive * this.FuelConsumptionLperKm;
            this.DrivenKm += kmToDrive;
        }

        this.FuelQuantity -= fuelNeeded;
    }
}

