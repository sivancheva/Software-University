using System;
using System.Collections.Generic;
using System.Text;


public class AggressiveDriver : Driver
{

    public override double Speed => base.Speed * 1.3;

    public AggressiveDriver(string name, Car car)
        :base(name, car)
    {
        this.FuelConsumptionPerKm = 2.7;
    }
}

