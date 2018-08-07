using System;


public abstract class Vehicle:IVehicle
{
    private double fuelQuantity;
    private double fuelConsumptionLperKm;
    private double drivenKm;

    public Vehicle(double fuelQuantity, double fuelConsumptionLperKm)
    {
        this.fuelQuantity = fuelQuantity;
        this.FuelConsumptionLperKm = fuelConsumptionLperKm;
        this.DrivenKm = 0;
    }

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }

    public virtual double FuelConsumptionLperKm
    {
        get { return fuelConsumptionLperKm; }
        set { fuelConsumptionLperKm = value; }
    }

    public double DrivenKm
    {
        get { return drivenKm; }
        set { drivenKm = value; }
    }

    public void Drive(double kmToDrive)
    {
        if (this.FuelQuantity / this.FuelConsumptionLperKm < kmToDrive)
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
        else 
        {
            Console.WriteLine($"{this.GetType().Name} travelled {kmToDrive} km");
            this.FuelQuantity -= kmToDrive * this.FuelConsumptionLperKm;
            this.DrivenKm += kmToDrive;
        }
        
    }

    public virtual void  Refuel(double litersToRefuel)
    {
        this.FuelQuantity += litersToRefuel;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
