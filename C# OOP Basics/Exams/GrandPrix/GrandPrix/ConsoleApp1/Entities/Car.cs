using System;

public class Car
{
    private const int MaxTankCapacity = 160;

    public int Hp { get; private set; }
    private double fuelAmount;
    private Tyre tyre;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public double FuelAmount
    {
        get { return fuelAmount; }
        private set
        {
            if ( value < 0 )
            {
                throw new ArgumentException("Out of fuel");    
            }
            this.fuelAmount = value > MaxTankCapacity ? MaxTankCapacity : value;
        }
    }
    public Tyre Tyre
    {
        get { return tyre; }
        private set { tyre = value; }
    }
}