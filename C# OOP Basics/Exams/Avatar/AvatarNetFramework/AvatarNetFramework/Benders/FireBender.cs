using System;
using System.Collections.Generic;
using System.Text;

public class FireBender : Bender
{
    public double HeatAggression { get; private set; }
    public override double TotalPower => this.Power * this.HeatAggression;

    public FireBender(string name, int power, double heatAggression)
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }


    public override string ToString()
    {
        return $"###Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.HeatAggression:f2}";
    }
}
