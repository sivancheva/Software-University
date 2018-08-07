using System;
using System.Collections.Generic;
using System.Text;



public class Car
{
    private const int MaxTankCapacity = 160;
    private int hp;
    private double fuelAmount;
    private Tyre tyre;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public int Hp
    {
        get { return hp; }
        private set { hp = value; }
    }

    public double FuelAmount
    {
        get { return fuelAmount; }
        private set
        {
            if (value < 0 )
            {
                throw new ArgumentException("Out of fuel");
            }
            if (value + this.fuelAmount > 160)
            {
                this.FuelAmount = MaxTankCapacity;
            }
            else
            {
                fuelAmount += value;
            }
                        
        }
    }

    public Tyre Tyre
    {
        get { return tyre; }
        private set { tyre = value; }
    }

}

