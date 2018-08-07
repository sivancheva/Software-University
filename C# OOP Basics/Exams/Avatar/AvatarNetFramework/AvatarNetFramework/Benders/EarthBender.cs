using System;
using System.Collections.Generic;
using System.Text;

public class EarthBender : Bender
{
    public double GroundSaturation { get; private set; }
    public override double TotalPower => this.Power * this.GroundSaturation;

    public EarthBender(string name, int power, double groundSaturation)
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }


}
