using System;
using System.Collections.Generic;
using System.Text;


public abstract class Driver
{
    
    private string Name { get; }  
    private double fuelConsumption;
    private double speed;
    private Car Car { get; set; }
    private double totalTime;
    private string failureReason;
       


    protected Driver(string name, Car car)
    {
        this.Name = name;
        this.Car = car;
        this.FailureReason = failureReason;
        this.totalTime = 0;
    }
    
    public double FuelConsumption
    {
        get { return fuelConsumption; }
        protected set { fuelConsumption = value; }
    }

    public double Speed
    {
        get { return speed; }
        protected set
        {
            speed = (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
        }
    }

    public string FailureReason
    {
        get { return failureReason; }
        protected set { failureReason = value; }
    }

    public double Totaltime
    {
        get { return totalTime; }
        set { totalTime = value; }
    }
}

