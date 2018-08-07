using System;
using System.Collections.Generic;
using System.Text;


public abstract class Driver
{

    private string name;
    private double totalTime;
    private Car car;
    private double fuelConsumptionPerKm;
    private double speed;

    protected Driver(string name, Car car)
    {
        this.Name = name;
        this.TotalTime = 0;       
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public double TotalTime
    {
        get { return totalTime; }
        private set { totalTime = value; }
    }

    public double FuelConsumptionPerKm
    {
        get { return fuelConsumptionPerKm; }
        protected set { fuelConsumptionPerKm = value; }
    }

    public virtual double Speed
    {
        get { return speed; }
        protected set
        {
            speed = ((double)this.Car.Hp + this.Car.Tyre.Degradation)/Car.FuelAmount;
        }
    }

    public Car Car { get => car; private set => car = value; }
}

