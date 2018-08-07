using System;
using System.Collections.Generic;
using System.Text;


public class WaterBender : Bender
{
    public double WaterClarity { get; private set; }
    public override double TotalPower  => this.Power * this.WaterClarity;

    public WaterBender(string name, int power, double waterClarity)
        : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public override string ToString()
    {
        return $"###Water Bender: {this.Name}, Power: {this.Power}, Water Clarity: {this.WaterClarity:f2}";
    }
}

