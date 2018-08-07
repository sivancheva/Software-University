using System;


public class Vehicle:IVehicle
{
   

    private double fuelQuantity;
    private double fuelConsumptionLperKm;
    private double drivenKm;
    private double tankCapacity;


    public Vehicle(double fuelQuantity, double fuelConsumptionLperKm, double tankCapacity)
    {
        this.fuelQuantity = fuelQuantity;
        this.FuelConsumptionLperKm = fuelConsumptionLperKm;
        this.TankCapacity = tankCapacity;
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

    public double TankCapacity
    {
        get { return tankCapacity; }
        set { tankCapacity = value; }
    }

    public virtual void Drive(double kmToDrive)
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
        if (litersToRefuel <=0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else if (litersToRefuel + this.FuelQuantity > this.TankCapacity)
        {
            Console.WriteLine($"Cannot fit {litersToRefuel} fuel in the tank");
        }
        else
        {
            this.FuelQuantity += litersToRefuel;
        }
        
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
